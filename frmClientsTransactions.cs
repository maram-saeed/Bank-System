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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Bank_System
{
    public partial class frmClientsTransactions : Form
    {
        DataTable _dtClients = clsClient.GetAllClients();
        clsClient _Client;
        DataTable dtResult = new DataTable();
        DataTable _dtBalance = new DataTable();
        DataTable _dtTransferLog = new DataTable();
        clsClient _DestinationClient;

        string _UserName = "";
        string _PreviousSelection = null;

        public double WithdrawAmount { get; set; }

        frmManageClients _manageClients;
        public frmClientsTransactions(frmManageClients frmClients, string currentUserName)
        {
            InitializeComponent();
            _manageClients = frmClients;
            _UserName = currentUserName;
        }

        private void _FillAccountNumbersInDepositComboBox()
        {
            DataTable dt = clsClient.GetAllClients();

            foreach (DataRow row in dt.Rows)
            {
                cbAccountNumbers.Items.Add(row["AccountNumber"]);
            }
        }

        private void _FillAccountNumbersInWithdrawComboBox()
        {
            DataTable dt = clsClient.GetAllClients();

            foreach (DataRow row in dt.Rows)
            {
                cbWithDrawAccountNumbers.Items.Add(row["AccountNumber"]);
            }
        }

        private void _FillFromToAccountNumberComboBox()
        {
            DataTable dt = clsClient.GetAllClients();

            foreach (DataRow row in dt.Rows)
            {
                cbFromAccNumber.Items.Add(row["AccountNumber"]);
                cbToAccNumber.Items.Add(row["AccountNumber"]);
            }
        }

        public void FillDgvClientsList()
        {
            DataTable _dtClients = clsClient.GetAllClients();
            _dtBalance.Clear();
            foreach (DataRow row in _dtClients.Rows)
            {
                _dtBalance.Rows.Add(row["ClientID"], row["AccountNumber"], row["Balance"]);
            }

            _dtBalance.DefaultView.Sort = "ClientID asc";
            _dtBalance = _dtBalance.DefaultView.ToTable();
            dgvAllClients.DataSource = _dtBalance;
            dgvAllClients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public void FillDgvTransferLogList()
        {
            DataTable _dtTransfersLog = clsTransferLog.GetAllTransferLog();
            _dtTransferLog.Clear();
            foreach (DataRow row in _dtTransfersLog.Rows)
            {
                _dtTransferLog.Rows.Add(row["DateTime"], row["SourceAccountNumber"], row["DestinationAccountNumber"],
                    row["SourceBalance"], row["DestinationBalance"], row["Amount"], row["UserName"]);
            }

            _dtTransferLog.DefaultView.Sort = "DateTime asc";
            _dtTransferLog = _dtTransferLog.DefaultView.ToTable();
            dgvAllTransfersLog.DataSource = _dtTransferLog;
            dgvAllTransfersLog.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void frmClientsTransactions_Load(object sender, EventArgs e)
        {
            dtResult.Columns.Add("AccountNumber", typeof(string));
            dtResult.Columns.Add("Balance", typeof(double));

            _FillAccountNumbersInDepositComboBox();
            _FillAccountNumbersInWithdrawComboBox();
            _FillFromToAccountNumberComboBox();

            // Table of TotalBalances
            _dtBalance.Columns.Add("ClientID", typeof(int));
            _dtBalance.Columns.Add("AccountNumber", typeof(string));
            _dtBalance.Columns.Add("Balance", typeof(double));

            lblTotalBalances.Text = "$" + clsClient.GetTotalBalances().ToString();
            lblTotalBalancesInLetters.Text = $"({clsUtil.NumberToText(Convert.ToInt32(clsClient.GetTotalBalances()))}) Dollar(s)";

            FillDgvClientsList();
            lblNumberOfClients.Text = (dgvAllClients.RowCount - 1).ToString();

            // Table of TransferLog

            _dtTransferLog.Columns.Add("DateTime", typeof(DateTime));
            _dtTransferLog.Columns.Add("SourceAccountNumber", typeof(string));
            _dtTransferLog.Columns.Add("DestinationAccountNumber", typeof(string));
            _dtTransferLog.Columns.Add("SourceBalance", typeof(double));
            _dtTransferLog.Columns.Add("DestinationBalance", typeof(double));
            _dtTransferLog.Columns.Add("Amount", typeof(double));
            _dtTransferLog.Columns.Add("UserName", typeof(string));

            FillDgvTransferLogList();
            lblNumberOfClientsFromLog.Text = (dgvAllTransfersLog.RowCount - 1).ToString();


            // frmManageClients frmClients = new frmManageClients(this);
        }

        private void _GetDepositClient()
        {
            _Client = clsClient.Find(cbAccountNumbers.SelectedItem.ToString());

            if (_Client != null)
            {
                lblCurrentBalance.Text = "$" + _Client.Balance;
            }
            else
            {
                lblCurrentBalance.Text = "$" + 0;
            }
        }

        private void _GetWithdrawClient()
        {
            _Client = clsClient.Find(cbWithDrawAccountNumbers.SelectedItem.ToString());

            if (_Client != null)
            {
                lblWithdrawCurrentBalance.Text = "$" + _Client.Balance;
                ncWithdrawBalance.Value = Convert.ToDecimal(_Client.Balance);
            }
            else
            {
                lblWithdrawCurrentBalance.Text = "$" + 0;
            }
        }

        private void _GetFromAccNumberClient()
        {
            _Client = clsClient.Find(cbFromAccNumber.SelectedItem.ToString());

            if (_Client != null)
            {
                lblFromCurrentBalance.Text = "$" + _Client.Balance;
                ncTransferAmount.Value = Convert.ToDecimal(_Client.Balance);
            }
            else
            {
                lblFromCurrentBalance.Text = "$" + 0;
            }
        }

        private void _GetToAccNumberClient()
        {
            _DestinationClient = clsClient.Find(cbToAccNumber.SelectedItem.ToString());

            if (_DestinationClient != null)
            {
                lblToCurrentBalance.Text = "$" + _DestinationClient.Balance;
            }
            else
            {
                lblToCurrentBalance.Text = "$" + 0;
            }
        }

        private void _ClearDepositData()
        {
            cbAccountNumbers.SelectedIndex = -1;
            lblCurrentBalance.Text = "$0";
            ncDepositBalance.Value = 0;

        }

        private void _ClearWithDrawData()
        {
            cbWithDrawAccountNumbers.SelectedIndex = -1;
            lblWithdrawCurrentBalance.Text = "$0";
            ncWithdrawBalance.Value = 0;

        }

        private void cbAccountNumbers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbAccountNumbers.SelectedIndex == -1)
                return;
            _GetDepositClient();
        }

        private void cbWithDrawAccountNumbers_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnWithdraw.Enabled = true;
            if (cbWithDrawAccountNumbers.SelectedIndex == -1)
                return;
            _GetWithdrawClient();
            if (_Client.Balance == 0)
            {
                MessageBox.Show("Empty Balance", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnWithdraw.Enabled = false;
                return;
            }
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure to perfotme this transaction ? ", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                _Client.Deposit(Convert.ToDouble(ncDepositBalance.Value));
                _GetDepositClient();
                _manageClients.RefreshClientsList();
                MessageBox.Show($"Amount has been deposited (${Convert.ToDouble(ncDepositBalance.Value)}) succefully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FillDgvClientsList();
            }
        }

        private void btnDepositClearData_Click(object sender, EventArgs e)
        {
            _ClearDepositData();
        }

        private void btnWithDrawClearData_Click(object sender, EventArgs e)
        {
            _ClearWithDrawData();
        }

        private void ncWithdrawBalance_ValueChanged(object sender, EventArgs e)
        {
            if(ncWithdrawBalance.Value > Convert.ToDecimal(_Client.Balance))
            {
                ncWithdrawBalance.Value = Convert.ToDecimal(_Client.Balance);
            }

            else
            {
                WithdrawAmount = Convert.ToDouble(ncWithdrawBalance.Value);
            }
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to perfotme this transaction ? ", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                _Client.Withdraw(Convert.ToDouble(ncWithdrawBalance.Value));
                MessageBox.Show($"Amount has been withdrawn (${WithdrawAmount}) succefully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _GetWithdrawClient();
                _manageClients.RefreshClientsList();
                FillDgvClientsList();
            }

            _ClearWithDrawData();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            _dtClients = clsClient.GetAllClients();
            DataTable dt = _dtBalance;

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

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tcTransactions.SelectedTab == tpTotalBalances)
            {
                lblTotalBalances.Text = "$" + clsClient.GetTotalBalances().ToString();
                lblTotalBalancesInLetters.Text = $"({clsUtil.NumberToText(Convert.ToInt32(clsClient.GetTotalBalances()))}) Dollar(s)";
                FillDgvClientsList();
            }
        }

        private void cbFromAccNumber_SelectedIndexChanged(object sender, EventArgs e)
        {

            _GetFromAccNumberClient();

            if (_Client.Balance == 0)
            {
                MessageBox.Show("Empty Balance", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnTransfer.Enabled = false;
                return;
            }

            string currentSelection = cbFromAccNumber.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(_PreviousSelection) && !_PreviousSelection.Equals(currentSelection))
            {
                if (!cbToAccNumber.Items.Contains(_PreviousSelection))
                {
                    cbToAccNumber.Items.Add(_PreviousSelection);
                }
            }

            if (!string.IsNullOrEmpty(currentSelection))
            {
                for(int i = 0; i < cbToAccNumber.Items.Count; i++)
                {
                    if (cbToAccNumber.Items[i].ToString() == currentSelection)
                    {
                        cbToAccNumber.Items.RemoveAt(i);
                        break;
                    }
                }
                cbToAccNumber.Enabled = true;
                _PreviousSelection = currentSelection;
            }
        }

        private void ncTransferAmount_ValueChanged(object sender, EventArgs e)
        {
            btnTransfer.Enabled = true;
        }

        private void cbToAccNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            _GetToAccNumberClient();
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            double Amount = Convert.ToDouble(ncTransferAmount.Value);

            if (_Client.Transfer(Amount, _DestinationClient, _UserName))
            {
                if (MessageBox.Show("Are you sure to perfotme this transaction ? ", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    _GetToAccNumberClient();
                    _GetFromAccNumberClient();
                    FillDgvTransferLogList();
                    lblNumberOfClientsFromLog.Text = (dgvAllTransfersLog.RowCount - 1).ToString();
                    MessageBox.Show("Transfer done successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Transfer Faild", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSearchTransferLog_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = _dtTransferLog;

            // تجنب الأخطاء في حال المستخدم كتب ' داخل النص
            string searchValue = txtSearchTransferLog.Text.Replace("'", "''");

            DataRow[] resultRows = dt.Select($"UserName LIKE '{searchValue}%'");

            DataTable filteredTable = dt.Clone();

            foreach (DataRow row in resultRows)
            {
                filteredTable.ImportRow(row);
            }

            dgvAllTransfersLog.DataSource = filteredTable;
            lblNumberOfClientsFromLog.Text = (dgvAllTransfersLog.RowCount - 1).ToString();
        }
    }
}
