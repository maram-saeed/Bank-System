using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Windows.Forms;
using BankBusinessLayer;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Bank_System
{
    public partial class frmManageClients : Form
    {
        public enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode = enMode.AddNew;

        int _ClientID = -1;
        int _PersonID = -1;

        clsPerson _Person;
        clsClient _Client;
        DataTable dtPersons = clsPerson.GetAllPersons();
        DataTable dtClients = clsClient.GetAllClients();
        DataTable dtResult = new DataTable();

      //  frmClientsTransactions _frmTransactions;

        public frmManageClients()
        {
            InitializeComponent();
        }

        private void _ClearData()
        {
            if(_Mode == enMode.AddNew)
            {
                txtAddAccNumber.Clear();
                txtAddPinCode.Clear();
                txtAddFirstName.Clear();
                txtAddLastName.Clear();
                txtAddEmail.Clear();
                txtAddPhone.Clear();
                txtAddUserID.Clear();
                ncAddBalance.Value = 0;
            }
            else
            {
                txtUpdateAccNumber.Clear();
                txtUpdatePinCode.Clear();
                txtUpdateFirstName.Clear();
                txtUpdateLastName.Clear();
                txtUpdateEmail.Clear();
                txtUpdatePhone.Clear();
                txtUpdateUserID.Clear();
                ncUpdateBalance.Value = 0;
            }
        }

        private void _AddOrUpdateData()
        {
            string firstName, lastName, email, phone, accountNumber;
            short pinCode;
            double balance;
            int userID;

            if (_Mode == enMode.AddNew)
            {
                _Person = new clsPerson();
                _Client = new clsClient();

                firstName = txtAddFirstName.Text;
                lastName = txtAddLastName.Text;
                email = txtAddEmail.Text;
                phone = txtAddPhone.Text;
                accountNumber = txtAddAccNumber.Text;
             
                string pinText = txtAddPinCode.Text?.Trim();

                if (string.IsNullOrWhiteSpace(pinText) || !short.TryParse(pinText, out pinCode))
                {
                    MessageBox.Show("Please enter a valid numeric Pin Code.");
                    return;
                }

                _Client.PinCode = pinCode;

                balance = Convert.ToDouble(ncAddBalance.Value);
                userID = Convert.ToInt32(txtAddUserID.Text);

                _ClearData();
            }
            else // Update
            {
                if (_Client == null || _Person == null)
                {
                    MessageBox.Show("Error: Person or Client not loaded.");
                    return;
                }

                firstName = txtUpdateFirstName.Text;
                lastName = txtUpdateLastName.Text;
                email = txtUpdateEmail.Text;
                phone = txtUpdatePhone.Text;
                accountNumber = txtUpdateAccNumber.Text;

                string pinText = txtUpdatePinCode.Text?.Trim();

                if (int.TryParse(pinText, out int pin))
                {
                    _Client.PinCode = (short)pin;
                }
                else
                {
                    MessageBox.Show("Please enter a valid numeric Pin Code.");
                    return;
                }


                balance = Convert.ToDouble(ncUpdateBalance.Value);
                userID = Convert.ToInt32(txtUpdateUserID.Text);
            }

            _Person.FirstName = firstName;
            _Person.LastName = lastName;
            _Person.Email = email;
            _Person.Phone = phone;

            if (_Person.Save())
            {
                _Client.AccountNumber = accountNumber;
                _Client.Balance = balance;
                _Client.UserID = userID;
                _Client.PersonID = _Person.PersonID;

                if (_Client.Save())
                {
                    MessageBox.Show(_Mode == enMode.AddNew ? "Client added successfully." : "Client updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error: Client not saved.");
                }
            }
            else
            {
                MessageBox.Show("Error: Person not saved.");
            }

            _Mode = enMode.Update;
            _ClearData();
        }

        public void RefreshClientsList()
        {
            //    dgvAllClients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dtPersons = clsPerson.GetAllPersons();
            dtClients = clsClient.GetAllClients();

            dtResult.Clear();
            var result = from person in dtPersons.AsEnumerable()
                         join client in dtClients.AsEnumerable()
                         on person.Field<int>("PersonID") equals client.Field<int>("PersonID")
                         select new
                         {
                             ClientID = client.Field<int>("ClientID"),
                             FirstName = person.Field<string>("FirstName") ?? "",
                             LastName = person.Field<string>("LastName") ?? "",
                             AccountNumber = client.Field<string>("AccountNumber") ?? "",
                             PinCode = client.Field<short?>("PinCode") ?? 0,
                             Balance = client.Field<decimal?>("Balance") ?? 0,
                             Email = person.Field<string>("Email") ?? "",
                             Phone = person.Field<string>("Phone") ?? "",
                             UserID = client.Field<int?>("UserID") ?? 0,
                             PersonID = person.Field<int>("PersonID")
                         };

            foreach (var row in result)
            {
                dtResult.Rows.Add(row.ClientID, row.FirstName, row.LastName, row.AccountNumber, row.PinCode,
                                     row.Balance, row.Email, row.Phone, row.UserID, row.PersonID);
            }

            dtResult.DefaultView.Sort = "ClientID asc";
            dtResult = dtResult.DefaultView.ToTable();

            dgvAllClients.DataSource = dtResult;
            lblNumberOfClients.Text = (dgvAllClients.RowCount - 1).ToString();

            

        }

        private void _LoadData()
        {
            if(_Mode == enMode.AddNew)
            {
                _Person = new clsPerson();
                _Client = new clsClient();

            }
        }

        private void frmManageClients_Load(object sender, EventArgs e)
        {
            _LoadData();
            dtResult.Columns.Add("ClientID", typeof(int));
            dtResult.Columns.Add("FirstName", typeof(string));
            dtResult.Columns.Add("LastName", typeof(string));
            dtResult.Columns.Add("AccountNumber", typeof(string));
            dtResult.Columns.Add("PinCode", typeof(short));
            dtResult.Columns.Add("Balance", typeof(double));
            dtResult.Columns.Add("Email", typeof(string));
            dtResult.Columns.Add("Phone", typeof(string));
            dtResult.Columns.Add("UserID", typeof(int));
            dtResult.Columns.Add("PersonID", typeof(int));

            RefreshClientsList();
        //    frmClientsTransactions frmTransactions = new frmClientsTransactions(this);
            //dgvAllClients.DataSource = dtResult;
            //lblNumberOfClients.Text = (dgvAllClients.RowCount - 1).ToString();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = dtResult;

            // تجنب الأخطاء في حال المستخدم كتب ' داخل النص
            string searchValue = txtSearch.Text.Replace("'", "''"); 

            DataRow[] resultRows = dt.Select($"AccountNumber LIKE '{searchValue}%'");

            DataTable filteredTable = dt.Clone();

            foreach (DataRow row in resultRows)
            {
                filteredTable.ImportRow(row);
            }

            dgvAllClients.DataSource = filteredTable;
            lblNumberOfClients.Text = (dgvAllClients.RowCount - 1).ToString();


        }

        private void btnAddNewClient_Click(object sender, EventArgs e)
        {
            _Mode = enMode.AddNew;
            _AddOrUpdateData();

            dtPersons = clsPerson.GetAllPersons();
            dtClients = clsClient.GetAllClients();

            RefreshClientsList();
         //   _frmTransactions.FillDgvClientsList();

        }

        private void dgvAllClients_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAllClients.CurrentRow == null)
                return;

            if (dgvAllClients.CurrentRow.Cells["ClientID"].Value != System.DBNull.Value
                && dgvAllClients.CurrentRow.Cells["PersonID"].Value != System.DBNull.Value)
            {
                _ClientID = Convert.ToInt32(dgvAllClients.CurrentRow.Cells["ClientID"].Value);
                _PersonID = Convert.ToInt32(dgvAllClients.CurrentRow.Cells["PersonID"].Value);
            }
            else
            {
                MessageBox.Show("You Can Not Update This Row It is Null!", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataRow[] drFindClient;
            drFindClient = dtResult.Select($"ClientID = {_ClientID} and PersonID = {_PersonID}");

            foreach (DataRow row in drFindClient)
            {
                txtUpdateAccNumber.Text = row["AccountNumber"].ToString();
                txtUpdatePinCode.Text = row["PinCode"].ToString();
                txtUpdateFirstName.Text = row["FirstName"].ToString();
                txtUpdateLastName.Text = row["LastName"].ToString();
                txtUpdateEmail.Text = row["Email"].ToString();
                txtUpdatePhone.Text = row["Phone"].ToString();
                txtUpdateUserID.Text = row["UserID"].ToString();
                ncUpdateBalance.Value = Convert.ToDecimal(row["Balance"]);
            }

            tcShowClients.SelectedTab = tpUpdateClient;
           // _frmTransactions.FillDgvClientsList();
        }

        private void btnUpdateClient_Click(object sender, EventArgs e)
        {
            _Mode = enMode.Update;
            if (dgvAllClients.CurrentRow == null)
            {
                MessageBox.Show("Please select a client to update.");
                return;
            }

            _Client = clsClient.Find(_ClientID);
            _Person = clsPerson.Find(_PersonID);

            if (_Client == null || _Person == null)
            {
                MessageBox.Show("Error: Client or Person not found.");
                return;
            }

            _AddOrUpdateData();

            dtPersons = clsPerson.GetAllPersons();
            dtClients = clsClient.GetAllClients();

            RefreshClientsList();
           // _frmTransactions.FillDgvClientsList();
        }

        private void tcShowClients_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshClientsList();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (dgvAllClients.CurrentRow.Cells["ClientID"].Value != System.DBNull.Value
                && dgvAllClients.CurrentRow.Cells["PersonID"].Value != System.DBNull.Value)
            {
                _ClientID = Convert.ToInt32(dgvAllClients.CurrentRow.Cells["ClientID"].Value);
                _PersonID = Convert.ToInt32(dgvAllClients.CurrentRow.Cells["PersonID"].Value);
            }
            else
            {
                MessageBox.Show("You Can Not Delete This Row It is Null!", "Delete Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
          
            
            if(MessageBox.Show("Are you sure you want to delete client [" + dgvAllClients.CurrentRow.Cells[0].Value + "]", "Confirm Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if(clsClient.DeleteClient(_ClientID) && clsPerson.DeletePerson(_PersonID))
                {
                    MessageBox.Show("Client Deleted Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Client is not deleted.");
            }
            RefreshClientsList();
          //  _frmTransactions.FillDgvClientsList();

        }

        private void txtAddAccNumber_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtAddAccNumber.Text))
            {
                e.Cancel = true;
                txtAddAccNumber.Focus();
                errorProvider1.SetError(txtAddAccNumber, "Account Number Should Has a Value !");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtAddAccNumber, "");
            }
        }

        private void txtAddPinCode_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAddPinCode.Text))
            {
                e.Cancel = true;
                txtAddPinCode.Focus();
                errorProvider1.SetError(txtAddPinCode, "Pin Code Should Has a Value !");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtAddPinCode, "");
            }
        }

        private void txtAddFirstName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAddFirstName.Text))
            {
                e.Cancel = true;
                txtAddFirstName.Focus();
                errorProvider1.SetError(txtAddFirstName, "First Name Should Has a Value !");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtAddFirstName, "");
            }
        }

        private void txtAddLastName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAddLastName.Text))
            {
                e.Cancel = true;
                txtAddLastName.Focus();
                errorProvider1.SetError(txtAddLastName, "Last Name Should Has a Value !");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtAddLastName, "");
            }
        }

        private void txtAddEmail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAddEmail.Text))
            {
                e.Cancel = true;
                txtAddEmail.Focus();
                errorProvider1.SetError(txtAddEmail, "Email Should Has a Value !");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtAddEmail, "");
            }
        }

        private void txtAddPhone_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAddPhone.Text))
            {
                e.Cancel = true;
                txtAddPhone.Focus();
                errorProvider1.SetError(txtAddPhone, "Phone Should Has a Value !");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtAddPhone, "");
            }
        }

        private void txtAddUserID_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAddUserID.Text))
            {
                e.Cancel = true;
                txtAddUserID.Focus();
                errorProvider1.SetError(txtAddUserID, "User ID Should Has a Value !");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtAddUserID, "");
            }
        }

        private void txtUpdateAccNumber_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUpdateAccNumber.Text))
            {
                e.Cancel = true;
                txtUpdateAccNumber.Focus();
                errorProvider1.SetError(txtUpdateAccNumber, "Account Number Should Has a Value !");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtUpdateAccNumber, "");
            }
        }

        private void txtUpdatePinCode_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUpdatePinCode.Text))
            {
                e.Cancel = true;
                txtUpdatePinCode.Focus();
                errorProvider1.SetError(txtUpdatePinCode, "Pin Code Should Has a Value !");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtUpdatePinCode, "");
            }
        }

        private void txtUpdateFirstName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUpdateFirstName.Text))
            {
                e.Cancel = true;
                txtUpdateFirstName.Focus();
                errorProvider1.SetError(txtUpdateFirstName, "First Name Should Has a Value !");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtUpdateFirstName, "");
            }
        }

        private void txtUpdateLastName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUpdateLastName.Text))
            {
                e.Cancel = true;
                txtUpdateLastName.Focus();
                errorProvider1.SetError(txtUpdateLastName, "Last Name Should Has a Value !");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtUpdateLastName, "");
            }
        }

        private void txtUpdateEmail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUpdateEmail.Text))
            {
                e.Cancel = true;
                txtUpdateEmail.Focus();
                errorProvider1.SetError(txtUpdateEmail, "Email Should Has a Value !");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtUpdateEmail, "");
            }
        }

        private void txtUpdatePhone_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUpdatePhone.Text))
            {
                e.Cancel = true;
                txtUpdatePhone.Focus();
                errorProvider1.SetError(txtUpdatePhone, "Phone Should Has a Value !");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtUpdatePhone, "");
            }
        }

        private void txtUpdateUserID_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUpdateUserID.Text))
            {
                e.Cancel = true;
                txtUpdateUserID.Focus();
                errorProvider1.SetError(txtUpdateUserID, "User ID Should Has a Value !");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtUpdateUserID, "");
            }
        }
    }
}
