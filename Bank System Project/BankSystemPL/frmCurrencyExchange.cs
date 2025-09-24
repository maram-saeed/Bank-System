using System;
using System.Data;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using BankBusinessLayer;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Bank_System
{
    public partial class frmCurrencyExchange : Form
    {
        public enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode = enMode.AddNew;

        DataTable _dtCurrency = new DataTable();
        clsCurrency _Currency;
        clsCurrency _CurrencyFrom;
        clsCurrency _CurrencyTo;
        public frmCurrencyExchange()
        {
            InitializeComponent();
        }

        public void FillDgvCurrencyList()
        {
            DataTable _dtCurrencies = clsCurrency.GetAllCurrencies();
            _dtCurrency.Clear();
            foreach (DataRow row in _dtCurrencies.Rows)
            {
                _dtCurrency.Rows.Add(row["Country"], row["Code"], row["Name"], row["Rate"]);
            }

            _dtCurrency.DefaultView.Sort = "Country asc";
            _dtCurrency = _dtCurrency.DefaultView.ToTable();
            dgvAllCurrencies.DataSource = _dtCurrency;
            dgvAllCurrencies.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void _FillCurrencyCodeComboBox()
        {
            //foreach (DataRow row in _dtCurrency.Rows)
            //{
            //    cbCurrencyCode.Items.Add(row["Code"]);
            //}

            cbCurrencyCode.Items.Clear();

            var uniqueCodes = _dtCurrency.AsEnumerable()
                                         .Select(r => r["Code"].ToString())
                                         .Distinct();

            foreach (var code in uniqueCodes)
            {
                cbCurrencyCode.Items.Add(code);
                cbFromCurrencyCode.Items.Add(code);
                cbToCurrencyCode.Items.Add(code);
            }
        }

        private void frmCurrencyExchange_Load(object sender, EventArgs e)
        {
            _dtCurrency.Columns.Add("Country", typeof(string));
            _dtCurrency.Columns.Add("Code", typeof(string));
            _dtCurrency.Columns.Add("Name", typeof(string));
            _dtCurrency.Columns.Add("Rate", typeof(double));

            FillDgvCurrencyList();
            lblNumberOfCurrencies.Text = (dgvAllCurrencies.RowCount - 1).ToString();

            _FillCurrencyCodeComboBox();

        }

        private void txtSearchCurrency_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = _dtCurrency;

            // تجنب الأخطاء في حال المستخدم كتب ' داخل النص
            string searchValue = txtSearchCurrency.Text.Replace("'", "''");

            DataRow[] resultRows = dt.Select($"Country LIKE '{searchValue}%' or Code LIKE '{searchValue}%'");

            DataTable filteredTable = dt.Clone();

            foreach (DataRow row in resultRows)
            {
                filteredTable.ImportRow(row);
            }

            dgvAllCurrencies.DataSource = filteredTable;
            lblNumberOfCurrencies.Text = (dgvAllCurrencies.RowCount - 1).ToString();
        }

        private void cbCurrencyCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCode = cbCurrencyCode.SelectedItem?.ToString().Replace("'", "''");

            DataRow[] result = _dtCurrency.Select($"Code = '{selectedCode}'");

            if (result.Length > 0)
            {
                DataRow topRow = result[0];
                lblCountry.Text = topRow["Country"].ToString();
                lblCode.Text = topRow["Code"].ToString();
                lblName.Text = topRow["Name"].ToString();
                lblRate.Text = $"(${topRow["Rate"].ToString()})";

                ncNewRate.Value = System.Convert.ToDecimal(topRow["Rate"]);
                _Currency = clsCurrency.Find(cbCurrencyCode.SelectedItem.ToString());
            }

            ncNewRate.Enabled = true;
        }

        private void btnUpdateRate_Click(object sender, EventArgs e)
        {
            _Mode = enMode.Update;
            if (_Currency != null)
            {
                if (MessageBox.Show("Are you sure you want to update rate ? ", "Confirm Updating", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    _Currency.Code = cbCurrencyCode.SelectedItem.ToString();
                    _Currency.Rate = System.Convert.ToDouble(ncNewRate.Value);
                }

            }

            if (_Currency.Save())
            {
                MessageBox.Show($"Rate updated successfully with ${ncNewRate.Value}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblCountry.Text = "???";
                lblCode.Text = "???";
                lblName.Text = "???";
                lblRate.Text = "($1)";
                cbCurrencyCode.SelectedIndex = -1;
                ncNewRate.Value = 1;
                FillDgvCurrencyList();
            }
            else
            {
                MessageBox.Show("Error: Rate not saved.");
            }
        }

        private void ncAmountToExchange_ValueChanged(object sender, EventArgs e)
        {
            btnConvert.Enabled = true;
        }

        private void cbFromAccNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCode = cbFromCurrencyCode.SelectedItem?.ToString().Replace("'", "''");

            DataRow[] result = _dtCurrency.Select($"Code = '{selectedCode}'");

            if (result.Length > 0)
            {
                DataRow topRow = result[0];
                lblFromCountry.Text = topRow["Country"].ToString();
                lblFromCode.Text = topRow["Code"].ToString();
                lblFromName.Text = topRow["Name"].ToString();
                lblFromRate.Text = $"(${topRow["Rate"].ToString()})";

                _CurrencyFrom = clsCurrency.Find(cbFromCurrencyCode.SelectedItem.ToString());
            }
        }

        private void cbToAccNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCode = cbToCurrencyCode.SelectedItem?.ToString().Replace("'", "''");

            DataRow[] result = _dtCurrency.Select($"Code = '{selectedCode}'");

            if (result.Length > 0)
            {
                DataRow topRow = result[0];
                lblToCountry.Text = topRow["Country"].ToString();
                lblToCode.Text = topRow["Code"].ToString();
                lblToName.Text = topRow["Name"].ToString();
                lblToRate.Text = $"(${topRow["Rate"].ToString()})";

                _CurrencyTo = clsCurrency.Find(cbToCurrencyCode.SelectedItem.ToString());
            }
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            double Amount = Convert.ToDouble(ncAmountToExchange.Value);
            double AmountInUSD = Convert.ToDouble(_CurrencyFrom.ConvertToUSD(Amount));

            lblAmountFrom.Text = Amount.ToString() + "  " + _CurrencyFrom.Code;
            lblAmountTo.Text =  "  =   " + AmountInUSD.ToString() + "  USD";

            if(_CurrencyTo.Code == "USD")
            {
                return;
            }

            double AmountInCurrency2 = _CurrencyFrom.ConvertToOtherCurrency(Amount, _CurrencyTo);

            lblAmountFrom.Text = $"{Amount.ToString()}   {_CurrencyFrom.Code}";
            lblAmountTo.Text = $"  =   {AmountInCurrency2.ToString()}   {_CurrencyTo.Code}";
        }
    }
}
