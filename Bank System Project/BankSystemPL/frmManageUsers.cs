using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankBusinessLayer;

namespace Bank_System
{
    public partial class frmManageUsers : Form
    {
        public enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode = enMode.AddNew;

        public enum enPermissions
        {
            eAll = -1, pManageClients = 1, pManageUsers = 2, pTranactions = 4,
            pCurrency = 8
        };

        int _UserID = -1;
        int _PersonID = -1;

        clsPerson _Person;
        clsUser _User;
        DataTable dtPersons = clsPerson.GetAllPersons();
        DataTable dtUsers = clsUser.GetAllCUsers();
        DataTable dtLoginRegisters = clsLoginRegister.GetAllLoginRegisters();
        DataTable dtResult = new DataTable();
        public frmManageUsers()
        {
            InitializeComponent();
        }

        private void _LoadData()
        {
            if (_Mode == enMode.AddNew)
            {
                _Person = new clsPerson();
                _User = new clsUser();

            }
        }

        private void _ClearData()
        {
            if (_Mode == enMode.AddNew)
            {
                txtAddUserName.Clear();
                txtAddFirstName.Clear();
                txtAddLastName.Clear();
                txtAddEmail.Clear();
                txtAddPhone.Clear();
                txtAddPassword.Clear();

                chkManageClients.Checked = false;
                chkManageUsers.Checked = false;
                chkClientsTransactions.Checked = false;
                chkCurrencyExchange.Checked = false;
            }
            else
            {
                txtUpdateUserName.Clear();
                txtUpdateFirstName.Clear();
                txtUpdateLastName.Clear();
                txtUpdateEmail.Clear();
                txtUpdatePhone.Clear();
                txtUpdatePassword.Clear();

                chkManageClientsUpdate.Checked = false;
                chkManageUsersUpdate.Checked = false;
                chkClientsTransactionsUpdate.Checked = false;
                chkCurrencyExchangeUpdate.Checked = false;
            }
        }

        private void _AddOrUpdateData()
        {
            string firstName = "", lastName = "", email = "", phone = "", userName = "";
            string password = "";
            int permissions = 0;
            bool hasAllAccess = false;

            if (_Mode == enMode.AddNew)
            {
                _Person = new clsPerson();
                _User = new clsUser();

                userName = txtAddUserName.Text;
                firstName = txtAddFirstName.Text;
                lastName = txtAddLastName.Text;
                email = txtAddEmail.Text;
                phone = txtAddPhone.Text;
                password = txtAddPassword.Text;

                if (rbNo.Checked)
                {
                    hasAllAccess = false;
                    if (chkManageClients.Checked)
                        permissions += (int)enPermissions.pManageClients;

                    if (chkManageUsers.Checked)
                        permissions += (int)enPermissions.pManageUsers;

                    if (chkClientsTransactions.Checked)
                        permissions += (int)enPermissions.pTranactions;

                    if (chkCurrencyExchange.Checked)
                        permissions += (int)enPermissions.pCurrency;
                }

                if (rbYes.Checked)
                {
                    hasAllAccess = true;
                    permissions += (int)enPermissions.eAll;
                }

                _ClearData();
            }
            else // Update
            {
                if (_User == null || _Person == null)
                {
                    MessageBox.Show("Error: Person or User not loaded.");
                    return;
                }

                userName = txtUpdateUserName.Text;
                firstName = txtUpdateFirstName.Text;
                lastName = txtUpdateLastName.Text;
                email = txtUpdateEmail.Text;
                phone = txtUpdatePhone.Text;
                password = txtUpdatePassword.Text;

                if (rbNoUpdate.Checked)
                {
                    hasAllAccess = false;
                    if (chkManageClientsUpdate.Checked)
                        permissions += (int)enPermissions.pManageClients;

                    if (chkManageUsersUpdate.Checked)
                        permissions += (int)enPermissions.pManageUsers;

                    if (chkClientsTransactionsUpdate.Checked)
                        permissions += (int)enPermissions.pTranactions;

                    if (chkCurrencyExchangeUpdate.Checked)
                        permissions += (int)enPermissions.pCurrency;
                }

                if (rbYesUpdate.Checked)
                {
                    hasAllAccess = true;
                    permissions += (int)enPermissions.eAll;
                }
            }

            _Person.FirstName = firstName;
            _Person.LastName = lastName;
            _Person.Email = email;
            _Person.Phone = phone;

            if (_Person.Save())
            {
                _User.UserName = userName;
                _User.Password = password;
                _User.Permissions = permissions;
                _User.HasAllAccess = hasAllAccess;
                _User.PersonID = _Person.PersonID;

                if (_User.Save())
                {
                    MessageBox.Show(_Mode == enMode.AddNew ? "User added successfully." : "User updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error: User not saved.");
                }
            }
            else
            {
                MessageBox.Show("Error: Person not saved.");
            }

            _Mode = enMode.Update;
            _ClearData();
        }

        private void _RefreshUsersList()
        {
            dtPersons = clsPerson.GetAllPersons();
            dtUsers = clsUser.GetAllCUsers();

            dtResult.Clear();
            var result = from person in dtPersons.AsEnumerable()
                         join user in dtUsers.AsEnumerable()
                         on person.Field<int>("PersonID") equals user.Field<int>("PersonID")
                         select new
                         {
                             UserID = user.Field<int>("UserID"),
                             FirstName = person.Field<string>("FirstName") ?? "",
                             LastName = person.Field<string>("LastName") ?? "",
                             UserName = user.Field<string>("UserName") ?? "",
                             Password = user.Field<string>("Password") ?? "",
                             Email = person.Field<string>("Email") ?? "",
                             Phone = person.Field<string>("Phone") ?? "",
                             Permissions = user.Field<int?>("Permissions") ?? 0,
                             HasAllAccess = user.Field<bool>("HasAllAccess"),
                             PersonID = person.Field<int>("PersonID")
                         };

            foreach (var row in result)
            {
                dtResult.Rows.Add(row.UserID, row.FirstName, row.LastName, row.UserName, row.Password,
                                    row.Email, row.Phone, row.Permissions, row.HasAllAccess, row.PersonID);
            }

            dtResult.DefaultView.Sort = "UserID asc";
            dtResult = dtResult.DefaultView.ToTable();

            dgvAllUsers.DataSource = dtResult;
            lblNumberOfUsers.Text = (dgvAllUsers.RowCount - 1).ToString();

        }

        private void frmManageUsers_Load(object sender, EventArgs e)
        {
            _LoadData();
            dtResult.Columns.Add("UserID", typeof(int));
            dtResult.Columns.Add("FirstName", typeof(string));
            dtResult.Columns.Add("LastName", typeof(string));
            dtResult.Columns.Add("UserName", typeof(string));
            dtResult.Columns.Add("Password", typeof(string));
            dtResult.Columns.Add("Email", typeof(string));
            dtResult.Columns.Add("Phone", typeof(string));
            dtResult.Columns.Add("Permissions", typeof(int));
            dtResult.Columns.Add("HasAllAccess", typeof(bool));
            dtResult.Columns.Add("PersonID", typeof(int));

            _RefreshUsersList();

            dgvAllLoginRegisters.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtLoginRegisters.DefaultView.Sort = "LoginRegisterID asc";
            dtLoginRegisters = dtLoginRegisters.DefaultView.ToTable();
            dgvAllLoginRegisters.DataSource = dtLoginRegisters;
            lblNumberOfLoginUsers.Text = (dgvAllLoginRegisters.RowCount - 1).ToString();
        }

        private void rbYes_CheckedChanged(object sender, EventArgs e)
        {
            chkManageClients.Checked = true;
            chkManageUsers.Checked = true;
            chkClientsTransactions.Checked = true;
            chkCurrencyExchange.Checked = true;
        }

        private void rbNo_CheckedChanged(object sender, EventArgs e)
        {
            chkManageClients.Checked = false;
            chkManageUsers.Checked = false;
            chkClientsTransactions.Checked = false;
            chkCurrencyExchange.Checked = false;
        }

        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            _Mode = enMode.AddNew;
            _AddOrUpdateData();

            dtPersons = clsPerson.GetAllPersons();
            dtUsers = clsUser.GetAllCUsers();

            _RefreshUsersList();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = dtResult;

            // تجنب الأخطاء في حال المستخدم كتب ' داخل النص
            string searchValue = txtSearch.Text.Replace("'", "''");

            DataRow[] resultRows = dt.Select($"UserName LIKE '{searchValue}%'");

            DataTable filteredTable = dt.Clone();

            foreach (DataRow row in resultRows)
            {
                filteredTable.ImportRow(row);
            }

            dgvAllUsers.DataSource = filteredTable;
            lblNumberOfUsers.Text = (dgvAllUsers.RowCount - 1).ToString();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvAllUsers.CurrentRow.Cells["UserID"].Value != System.DBNull.Value
                && dgvAllUsers.CurrentRow.Cells["PersonID"].Value != System.DBNull.Value)
            {
                _UserID = Convert.ToInt32(dgvAllUsers.CurrentRow.Cells["UserID"].Value);
                _PersonID = Convert.ToInt32(dgvAllUsers.CurrentRow.Cells["PersonID"].Value);
            }
            else
            {
                MessageBox.Show("You Can Not Delete This Row It is Null!", "Delete Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (MessageBox.Show("Are you sure you want to delete user [" + dgvAllUsers.CurrentRow.Cells[0].Value + "]", "Confirm Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (clsUser.DeleteUser(_UserID) && clsPerson.DeletePerson(_PersonID))
                {
                    MessageBox.Show("User Deleted Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("User is not deleted.");
            }
            _RefreshUsersList();
        }

        private void dgvAllUsers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            bool HasAllAccess = false;
            
            if (dgvAllUsers.CurrentRow == null)
                return;

            if (dgvAllUsers.CurrentRow.Cells["UserID"].Value != System.DBNull.Value
                && dgvAllUsers.CurrentRow.Cells["PersonID"].Value != System.DBNull.Value)
            {
                _UserID = Convert.ToInt32(dgvAllUsers.CurrentRow.Cells["UserID"].Value);
                _PersonID = Convert.ToInt32(dgvAllUsers.CurrentRow.Cells["PersonID"].Value);
            }
            else
            {
                MessageBox.Show("You Can Not Update This Row It is Null!", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataRow[] drFindClient;
            drFindClient = dtResult.Select($"UserID = {_UserID} and PersonID = {_PersonID}");

            foreach (DataRow row in drFindClient)
            {
                txtUpdateUserName.Text = row["UserName"].ToString();
                txtUpdateFirstName.Text = row["FirstName"].ToString();
                txtUpdateLastName.Text = row["LastName"].ToString();
                txtUpdateEmail.Text = row["Email"].ToString();
                txtUpdatePhone.Text = row["Phone"].ToString();
                txtUpdatePassword.Text = row["Password"].ToString();
                HasAllAccess = Convert.ToBoolean(row["HasAllAccess"]);

                if(HasAllAccess)
                {
                    rbYesUpdate.Checked = true;
                    chkManageClientsUpdate.Checked = true;
                    chkManageUsersUpdate.Checked = true;
                    chkClientsTransactionsUpdate.Checked = true;
                    chkCurrencyExchangeUpdate.Checked = true;
                }
                else
                {
                    rbNoUpdate.Checked = true;
                    chkManageClientsUpdate.Checked = false;
                    chkManageUsersUpdate.Checked = false;
                    chkClientsTransactionsUpdate.Checked = false;
                    chkCurrencyExchangeUpdate.Checked = false;
                }

            }

            tcShowUsers.SelectedTab = tpUpdateUser;
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            _Mode = enMode.Update;
            if (dgvAllUsers.CurrentRow == null)
            {
                MessageBox.Show("Please select a user to update.");
                return;
            }

            _User = clsUser.Find(_UserID);
            _Person = clsPerson.Find(_PersonID);

            if (_User == null || _Person == null)
            {
                MessageBox.Show("Error: User or Person not found.");
                return;
            }

            _AddOrUpdateData();

            dtPersons = clsPerson.GetAllPersons();
            dtUsers = clsUser.GetAllCUsers();

            _RefreshUsersList();
        }

        private void txtSearchInLoginRegister_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = dtLoginRegisters;

            // تجنب الأخطاء في حال المستخدم كتب ' داخل النص
            string searchValue = txtSearchInLoginRegister.Text.Replace("'", "''");

            DataRow[] resultRows = dt.Select($"UserName LIKE '{searchValue}%'");

            DataTable filteredTable = dt.Clone();

            foreach (DataRow row in resultRows)
            {
                filteredTable.ImportRow(row);
            }

            dgvAllLoginRegisters.DataSource = filteredTable;
            lblNumberOfLoginUsers.Text = (dgvAllLoginRegisters.RowCount - 1).ToString();
        }
    }
}
