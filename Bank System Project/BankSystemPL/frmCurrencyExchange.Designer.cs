namespace Bank_System
{
    partial class frmCurrencyExchange
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tcCurrencies = new System.Windows.Forms.TabControl();
            this.tpShowCurrencies = new System.Windows.Forms.TabPage();
            this.dgvAllCurrencies = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNumberOfCurrencies = new System.Windows.Forms.Label();
            this.txtSearchCurrency = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tpUpdateRate = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblRate = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnUpdateRate = new Guna.UI2.WinForms.Guna2Button();
            this.ncNewRate = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbCurrencyCode = new Guna.UI2.WinForms.Guna2ComboBox();
            this.tpCurrencyCalculator = new System.Windows.Forms.TabPage();
            this.lblAmountTo = new System.Windows.Forms.Label();
            this.lblAmountFrom = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.btnConvert = new Guna.UI2.WinForms.Guna2Button();
            this.ncAmountToExchange = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblToRate = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.lblToName = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.lblToCode = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.lblToCountry = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblFromRate = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblFromName = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblFromCode = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lblFromCountry = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.cbToCurrencyCode = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cbFromCurrencyCode = new Guna.UI2.WinForms.Guna2ComboBox();
            this.tcCurrencies.SuspendLayout();
            this.tpShowCurrencies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllCurrencies)).BeginInit();
            this.tpUpdateRate.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ncNewRate)).BeginInit();
            this.tpCurrencyCalculator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ncAmountToExchange)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcCurrencies
            // 
            this.tcCurrencies.Controls.Add(this.tpShowCurrencies);
            this.tcCurrencies.Controls.Add(this.tpUpdateRate);
            this.tcCurrencies.Controls.Add(this.tpCurrencyCalculator);
            this.tcCurrencies.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tcCurrencies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcCurrencies.Font = new System.Drawing.Font("Tahoma", 10F);
            this.tcCurrencies.Location = new System.Drawing.Point(0, 0);
            this.tcCurrencies.Name = "tcCurrencies";
            this.tcCurrencies.Padding = new System.Drawing.Point(8, 7);
            this.tcCurrencies.SelectedIndex = 0;
            this.tcCurrencies.Size = new System.Drawing.Size(990, 682);
            this.tcCurrencies.TabIndex = 1;
            // 
            // tpShowCurrencies
            // 
            this.tpShowCurrencies.BackgroundImage = global::Bank_System.Properties.Resources.bg_login;
            this.tpShowCurrencies.Controls.Add(this.dgvAllCurrencies);
            this.tpShowCurrencies.Controls.Add(this.label3);
            this.tpShowCurrencies.Controls.Add(this.lblNumberOfCurrencies);
            this.tpShowCurrencies.Controls.Add(this.txtSearchCurrency);
            this.tpShowCurrencies.Controls.Add(this.label1);
            this.tpShowCurrencies.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tpShowCurrencies.Font = new System.Drawing.Font("Tahoma", 10F);
            this.tpShowCurrencies.Location = new System.Drawing.Point(4, 38);
            this.tpShowCurrencies.Name = "tpShowCurrencies";
            this.tpShowCurrencies.Padding = new System.Windows.Forms.Padding(3);
            this.tpShowCurrencies.Size = new System.Drawing.Size(982, 640);
            this.tpShowCurrencies.TabIndex = 0;
            this.tpShowCurrencies.Text = "Show Currencies";
            this.tpShowCurrencies.UseVisualStyleBackColor = true;
            // 
            // dgvAllCurrencies
            // 
            this.dgvAllCurrencies.BackgroundColor = System.Drawing.Color.White;
            this.dgvAllCurrencies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllCurrencies.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvAllCurrencies.Location = new System.Drawing.Point(8, 272);
            this.dgvAllCurrencies.Name = "dgvAllCurrencies";
            this.dgvAllCurrencies.RowHeadersWidth = 51;
            this.dgvAllCurrencies.RowTemplate.Height = 26;
            this.dgvAllCurrencies.Size = new System.Drawing.Size(968, 360);
            this.dgvAllCurrencies.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(63, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Currency (ies) Found";
            // 
            // lblNumberOfCurrencies
            // 
            this.lblNumberOfCurrencies.AutoSize = true;
            this.lblNumberOfCurrencies.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblNumberOfCurrencies.ForeColor = System.Drawing.Color.Gold;
            this.lblNumberOfCurrencies.Location = new System.Drawing.Point(29, 220);
            this.lblNumberOfCurrencies.Name = "lblNumberOfCurrencies";
            this.lblNumberOfCurrencies.Size = new System.Drawing.Size(19, 21);
            this.lblNumberOfCurrencies.TabIndex = 2;
            this.lblNumberOfCurrencies.Text = "0";
            // 
            // txtSearchCurrency
            // 
            this.txtSearchCurrency.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchCurrency.DefaultText = "";
            this.txtSearchCurrency.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearchCurrency.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearchCurrency.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchCurrency.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchCurrency.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(118)))));
            this.txtSearchCurrency.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchCurrency.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtSearchCurrency.ForeColor = System.Drawing.Color.Gold;
            this.txtSearchCurrency.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchCurrency.IconLeft = global::Bank_System.Properties.Resources.search;
            this.txtSearchCurrency.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.txtSearchCurrency.Location = new System.Drawing.Point(33, 145);
            this.txtSearchCurrency.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearchCurrency.Name = "txtSearchCurrency";
            this.txtSearchCurrency.PlaceholderText = "";
            this.txtSearchCurrency.SelectedText = "";
            this.txtSearchCurrency.Size = new System.Drawing.Size(261, 46);
            this.txtSearchCurrency.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtSearchCurrency.TabIndex = 1;
            this.txtSearchCurrency.TextChanged += new System.EventHandler(this.txtSearchCurrency_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(39, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search Currency By Country/Code ";
            // 
            // tpUpdateRate
            // 
            this.tpUpdateRate.BackgroundImage = global::Bank_System.Properties.Resources.bg_login;
            this.tpUpdateRate.Controls.Add(this.panel1);
            this.tpUpdateRate.Controls.Add(this.btnUpdateRate);
            this.tpUpdateRate.Controls.Add(this.ncNewRate);
            this.tpUpdateRate.Controls.Add(this.label2);
            this.tpUpdateRate.Controls.Add(this.label7);
            this.tpUpdateRate.Controls.Add(this.cbCurrencyCode);
            this.tpUpdateRate.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tpUpdateRate.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.tpUpdateRate.Location = new System.Drawing.Point(4, 38);
            this.tpUpdateRate.Name = "tpUpdateRate";
            this.tpUpdateRate.Padding = new System.Windows.Forms.Padding(3);
            this.tpUpdateRate.Size = new System.Drawing.Size(982, 640);
            this.tpUpdateRate.TabIndex = 1;
            this.tpUpdateRate.Text = "Update Rate";
            this.tpUpdateRate.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblRate);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.lblCode);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lblCountry);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(528, 151);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(325, 258);
            this.panel1.TabIndex = 33;
            // 
            // lblRate
            // 
            this.lblRate.AutoSize = true;
            this.lblRate.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblRate.ForeColor = System.Drawing.Color.Gold;
            this.lblRate.Location = new System.Drawing.Point(127, 188);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(48, 21);
            this.lblRate.TabIndex = 40;
            this.lblRate.Text = "($1)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(72, 188);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 21);
            this.label11.TabIndex = 39;
            this.label11.Text = "Rate";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblName.ForeColor = System.Drawing.Color.Gold;
            this.lblName.Location = new System.Drawing.Point(148, 142);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(40, 21);
            this.lblName.TabIndex = 38;
            this.lblName.Text = "???";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(72, 142);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 21);
            this.label9.TabIndex = 37;
            this.label9.Text = "Name :";
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblCode.ForeColor = System.Drawing.Color.Gold;
            this.lblCode.Location = new System.Drawing.Point(142, 94);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(40, 21);
            this.lblCode.TabIndex = 36;
            this.lblCode.Text = "???";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(72, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 21);
            this.label5.TabIndex = 35;
            this.label5.Text = "Code :";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblCountry.ForeColor = System.Drawing.Color.Gold;
            this.lblCountry.Location = new System.Drawing.Point(167, 49);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(40, 21);
            this.lblCountry.TabIndex = 34;
            this.lblCountry.Text = "???";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(72, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 21);
            this.label6.TabIndex = 33;
            this.label6.Text = "Country :";
            // 
            // btnUpdateRate
            // 
            this.btnUpdateRate.Animated = true;
            this.btnUpdateRate.BorderColor = System.Drawing.Color.White;
            this.btnUpdateRate.BorderRadius = 5;
            this.btnUpdateRate.BorderThickness = 1;
            this.btnUpdateRate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateRate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateRate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateRate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdateRate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdateRate.FillColor = System.Drawing.Color.Transparent;
            this.btnUpdateRate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnUpdateRate.ForeColor = System.Drawing.Color.White;
            this.btnUpdateRate.Location = new System.Drawing.Point(207, 436);
            this.btnUpdateRate.Name = "btnUpdateRate";
            this.btnUpdateRate.PressedColor = System.Drawing.Color.White;
            this.btnUpdateRate.Size = new System.Drawing.Size(220, 49);
            this.btnUpdateRate.TabIndex = 26;
            this.btnUpdateRate.Text = "Update Rate";
            this.btnUpdateRate.Click += new System.EventHandler(this.btnUpdateRate_Click);
            // 
            // ncNewRate
            // 
            this.ncNewRate.BackColor = System.Drawing.Color.Transparent;
            this.ncNewRate.BorderRadius = 5;
            this.ncNewRate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ncNewRate.DecimalPlaces = 6;
            this.ncNewRate.Enabled = false;
            this.ncNewRate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ncNewRate.Location = new System.Drawing.Point(207, 338);
            this.ncNewRate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ncNewRate.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.ncNewRate.Name = "ncNewRate";
            this.ncNewRate.Size = new System.Drawing.Size(220, 40);
            this.ncNewRate.TabIndex = 25;
            this.ncNewRate.UpDownButtonFillColor = System.Drawing.Color.Gold;
            this.ncNewRate.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(203, 281);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 21);
            this.label2.TabIndex = 24;
            this.label2.Text = "New Rate ($)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(203, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 21);
            this.label7.TabIndex = 21;
            this.label7.Text = "Currency Code";
            // 
            // cbCurrencyCode
            // 
            this.cbCurrencyCode.BackColor = System.Drawing.Color.Transparent;
            this.cbCurrencyCode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbCurrencyCode.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbCurrencyCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCurrencyCode.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbCurrencyCode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbCurrencyCode.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbCurrencyCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbCurrencyCode.IntegralHeight = false;
            this.cbCurrencyCode.ItemHeight = 30;
            this.cbCurrencyCode.Location = new System.Drawing.Point(207, 166);
            this.cbCurrencyCode.MaxDropDownItems = 5;
            this.cbCurrencyCode.Name = "cbCurrencyCode";
            this.cbCurrencyCode.Size = new System.Drawing.Size(220, 36);
            this.cbCurrencyCode.Sorted = true;
            this.cbCurrencyCode.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cbCurrencyCode.TabIndex = 20;
            this.cbCurrencyCode.SelectedIndexChanged += new System.EventHandler(this.cbCurrencyCode_SelectedIndexChanged);
            // 
            // tpCurrencyCalculator
            // 
            this.tpCurrencyCalculator.BackgroundImage = global::Bank_System.Properties.Resources.bg_login;
            this.tpCurrencyCalculator.Controls.Add(this.lblAmountTo);
            this.tpCurrencyCalculator.Controls.Add(this.lblAmountFrom);
            this.tpCurrencyCalculator.Controls.Add(this.label27);
            this.tpCurrencyCalculator.Controls.Add(this.btnConvert);
            this.tpCurrencyCalculator.Controls.Add(this.ncAmountToExchange);
            this.tpCurrencyCalculator.Controls.Add(this.panel3);
            this.tpCurrencyCalculator.Controls.Add(this.panel2);
            this.tpCurrencyCalculator.Controls.Add(this.label15);
            this.tpCurrencyCalculator.Controls.Add(this.cbToCurrencyCode);
            this.tpCurrencyCalculator.Controls.Add(this.label12);
            this.tpCurrencyCalculator.Controls.Add(this.cbFromCurrencyCode);
            this.tpCurrencyCalculator.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tpCurrencyCalculator.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.tpCurrencyCalculator.Location = new System.Drawing.Point(4, 38);
            this.tpCurrencyCalculator.Name = "tpCurrencyCalculator";
            this.tpCurrencyCalculator.Padding = new System.Windows.Forms.Padding(3);
            this.tpCurrencyCalculator.Size = new System.Drawing.Size(982, 640);
            this.tpCurrencyCalculator.TabIndex = 2;
            this.tpCurrencyCalculator.Text = "Currency Calculator";
            this.tpCurrencyCalculator.UseVisualStyleBackColor = true;
            // 
            // lblAmountTo
            // 
            this.lblAmountTo.AutoSize = true;
            this.lblAmountTo.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.lblAmountTo.ForeColor = System.Drawing.Color.Gold;
            this.lblAmountTo.Location = new System.Drawing.Point(455, 561);
            this.lblAmountTo.Name = "lblAmountTo";
            this.lblAmountTo.Size = new System.Drawing.Size(74, 23);
            this.lblAmountTo.TabIndex = 46;
            this.lblAmountTo.Text = "1 USD ";
            // 
            // lblAmountFrom
            // 
            this.lblAmountFrom.AutoSize = true;
            this.lblAmountFrom.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.lblAmountFrom.ForeColor = System.Drawing.Color.Gold;
            this.lblAmountFrom.Location = new System.Drawing.Point(356, 561);
            this.lblAmountFrom.Name = "lblAmountFrom";
            this.lblAmountFrom.Size = new System.Drawing.Size(96, 23);
            this.lblAmountFrom.TabIndex = 45;
            this.lblAmountFrom.Text = "1 USD  =";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label27.ForeColor = System.Drawing.Color.White;
            this.label27.Location = new System.Drawing.Point(356, 345);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(191, 21);
            this.label27.TabIndex = 42;
            this.label27.Text = "Amount To Exchange";
            // 
            // btnConvert
            // 
            this.btnConvert.Animated = true;
            this.btnConvert.BorderColor = System.Drawing.Color.White;
            this.btnConvert.BorderRadius = 5;
            this.btnConvert.BorderThickness = 1;
            this.btnConvert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConvert.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnConvert.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnConvert.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnConvert.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnConvert.FillColor = System.Drawing.Color.Transparent;
            this.btnConvert.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnConvert.ForeColor = System.Drawing.Color.White;
            this.btnConvert.Location = new System.Drawing.Point(360, 478);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.PressedColor = System.Drawing.Color.White;
            this.btnConvert.Size = new System.Drawing.Size(220, 49);
            this.btnConvert.TabIndex = 44;
            this.btnConvert.Text = "Convert";
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // ncAmountToExchange
            // 
            this.ncAmountToExchange.BackColor = System.Drawing.Color.Transparent;
            this.ncAmountToExchange.BorderRadius = 5;
            this.ncAmountToExchange.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ncAmountToExchange.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ncAmountToExchange.Location = new System.Drawing.Point(360, 402);
            this.ncAmountToExchange.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ncAmountToExchange.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.ncAmountToExchange.Name = "ncAmountToExchange";
            this.ncAmountToExchange.Size = new System.Drawing.Size(220, 40);
            this.ncAmountToExchange.TabIndex = 43;
            this.ncAmountToExchange.UpDownButtonFillColor = System.Drawing.Color.Gold;
            this.ncAmountToExchange.ValueChanged += new System.EventHandler(this.ncAmountToExchange_ValueChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblToRate);
            this.panel3.Controls.Add(this.label20);
            this.panel3.Controls.Add(this.lblToName);
            this.panel3.Controls.Add(this.label22);
            this.panel3.Controls.Add(this.lblToCode);
            this.panel3.Controls.Add(this.label24);
            this.panel3.Controls.Add(this.lblToCountry);
            this.panel3.Controls.Add(this.label26);
            this.panel3.Location = new System.Drawing.Point(550, 127);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(325, 258);
            this.panel3.TabIndex = 41;
            // 
            // lblToRate
            // 
            this.lblToRate.AutoSize = true;
            this.lblToRate.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblToRate.ForeColor = System.Drawing.Color.Gold;
            this.lblToRate.Location = new System.Drawing.Point(87, 161);
            this.lblToRate.Name = "lblToRate";
            this.lblToRate.Size = new System.Drawing.Size(48, 21);
            this.lblToRate.TabIndex = 40;
            this.lblToRate.Text = "($1)";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(32, 161);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(49, 21);
            this.label20.TabIndex = 39;
            this.label20.Text = "Rate";
            // 
            // lblToName
            // 
            this.lblToName.AutoSize = true;
            this.lblToName.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblToName.ForeColor = System.Drawing.Color.Gold;
            this.lblToName.Location = new System.Drawing.Point(108, 115);
            this.lblToName.Name = "lblToName";
            this.lblToName.Size = new System.Drawing.Size(40, 21);
            this.lblToName.TabIndex = 38;
            this.lblToName.Text = "???";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label22.ForeColor = System.Drawing.Color.White;
            this.label22.Location = new System.Drawing.Point(32, 115);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(70, 21);
            this.label22.TabIndex = 37;
            this.label22.Text = "Name :";
            // 
            // lblToCode
            // 
            this.lblToCode.AutoSize = true;
            this.lblToCode.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblToCode.ForeColor = System.Drawing.Color.Gold;
            this.lblToCode.Location = new System.Drawing.Point(102, 67);
            this.lblToCode.Name = "lblToCode";
            this.lblToCode.Size = new System.Drawing.Size(40, 21);
            this.lblToCode.TabIndex = 36;
            this.lblToCode.Text = "???";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label24.ForeColor = System.Drawing.Color.White;
            this.label24.Location = new System.Drawing.Point(32, 67);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(64, 21);
            this.label24.TabIndex = 35;
            this.label24.Text = "Code :";
            // 
            // lblToCountry
            // 
            this.lblToCountry.AutoSize = true;
            this.lblToCountry.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblToCountry.ForeColor = System.Drawing.Color.Gold;
            this.lblToCountry.Location = new System.Drawing.Point(127, 22);
            this.lblToCountry.Name = "lblToCountry";
            this.lblToCountry.Size = new System.Drawing.Size(40, 21);
            this.lblToCountry.TabIndex = 34;
            this.lblToCountry.Text = "???";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label26.ForeColor = System.Drawing.Color.White;
            this.label26.Location = new System.Drawing.Point(32, 22);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(89, 21);
            this.label26.TabIndex = 33;
            this.label26.Text = "Country :";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblFromRate);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.lblFromName);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.lblFromCode);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.lblFromCountry);
            this.panel2.Controls.Add(this.label18);
            this.panel2.Location = new System.Drawing.Point(88, 127);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(325, 258);
            this.panel2.TabIndex = 34;
            // 
            // lblFromRate
            // 
            this.lblFromRate.AutoSize = true;
            this.lblFromRate.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblFromRate.ForeColor = System.Drawing.Color.Gold;
            this.lblFromRate.Location = new System.Drawing.Point(87, 161);
            this.lblFromRate.Name = "lblFromRate";
            this.lblFromRate.Size = new System.Drawing.Size(48, 21);
            this.lblFromRate.TabIndex = 40;
            this.lblFromRate.Text = "($1)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(32, 161);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 21);
            this.label8.TabIndex = 39;
            this.label8.Text = "Rate";
            // 
            // lblFromName
            // 
            this.lblFromName.AutoSize = true;
            this.lblFromName.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblFromName.ForeColor = System.Drawing.Color.Gold;
            this.lblFromName.Location = new System.Drawing.Point(108, 115);
            this.lblFromName.Name = "lblFromName";
            this.lblFromName.Size = new System.Drawing.Size(40, 21);
            this.lblFromName.TabIndex = 38;
            this.lblFromName.Text = "???";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(32, 115);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 21);
            this.label13.TabIndex = 37;
            this.label13.Text = "Name :";
            // 
            // lblFromCode
            // 
            this.lblFromCode.AutoSize = true;
            this.lblFromCode.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblFromCode.ForeColor = System.Drawing.Color.Gold;
            this.lblFromCode.Location = new System.Drawing.Point(102, 67);
            this.lblFromCode.Name = "lblFromCode";
            this.lblFromCode.Size = new System.Drawing.Size(40, 21);
            this.lblFromCode.TabIndex = 36;
            this.lblFromCode.Text = "???";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(32, 67);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(64, 21);
            this.label16.TabIndex = 35;
            this.label16.Text = "Code :";
            // 
            // lblFromCountry
            // 
            this.lblFromCountry.AutoSize = true;
            this.lblFromCountry.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblFromCountry.ForeColor = System.Drawing.Color.Gold;
            this.lblFromCountry.Location = new System.Drawing.Point(127, 22);
            this.lblFromCountry.Name = "lblFromCountry";
            this.lblFromCountry.Size = new System.Drawing.Size(40, 21);
            this.lblFromCountry.TabIndex = 34;
            this.lblFromCountry.Text = "???";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(32, 22);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(89, 21);
            this.label18.TabIndex = 33;
            this.label18.Text = "Country :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(579, 42);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(103, 21);
            this.label15.TabIndex = 30;
            this.label15.Text = "Convert To";
            // 
            // cbToCurrencyCode
            // 
            this.cbToCurrencyCode.BackColor = System.Drawing.Color.Transparent;
            this.cbToCurrencyCode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbToCurrencyCode.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbToCurrencyCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbToCurrencyCode.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbToCurrencyCode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbToCurrencyCode.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbToCurrencyCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbToCurrencyCode.IntegralHeight = false;
            this.cbToCurrencyCode.ItemHeight = 30;
            this.cbToCurrencyCode.Location = new System.Drawing.Point(583, 85);
            this.cbToCurrencyCode.MaxDropDownItems = 5;
            this.cbToCurrencyCode.Name = "cbToCurrencyCode";
            this.cbToCurrencyCode.Size = new System.Drawing.Size(220, 36);
            this.cbToCurrencyCode.Sorted = true;
            this.cbToCurrencyCode.TabIndex = 29;
            this.cbToCurrencyCode.SelectedIndexChanged += new System.EventHandler(this.cbToAccNumber_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(120, 42);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(126, 21);
            this.label12.TabIndex = 26;
            this.label12.Text = "Convert From";
            // 
            // cbFromCurrencyCode
            // 
            this.cbFromCurrencyCode.BackColor = System.Drawing.Color.Transparent;
            this.cbFromCurrencyCode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbFromCurrencyCode.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbFromCurrencyCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFromCurrencyCode.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbFromCurrencyCode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbFromCurrencyCode.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbFromCurrencyCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbFromCurrencyCode.IntegralHeight = false;
            this.cbFromCurrencyCode.ItemHeight = 30;
            this.cbFromCurrencyCode.Location = new System.Drawing.Point(124, 85);
            this.cbFromCurrencyCode.MaxDropDownItems = 5;
            this.cbFromCurrencyCode.Name = "cbFromCurrencyCode";
            this.cbFromCurrencyCode.Size = new System.Drawing.Size(220, 36);
            this.cbFromCurrencyCode.Sorted = true;
            this.cbFromCurrencyCode.TabIndex = 25;
            this.cbFromCurrencyCode.SelectedIndexChanged += new System.EventHandler(this.cbFromAccNumber_SelectedIndexChanged);
            // 
            // frmCurrencyExchange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 682);
            this.Controls.Add(this.tcCurrencies);
            this.Name = "frmCurrencyExchange";
            this.Text = "frmCurrencyExchange";
            this.Load += new System.EventHandler(this.frmCurrencyExchange_Load);
            this.tcCurrencies.ResumeLayout(false);
            this.tpShowCurrencies.ResumeLayout(false);
            this.tpShowCurrencies.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllCurrencies)).EndInit();
            this.tpUpdateRate.ResumeLayout(false);
            this.tpUpdateRate.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ncNewRate)).EndInit();
            this.tpCurrencyCalculator.ResumeLayout(false);
            this.tpCurrencyCalculator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ncAmountToExchange)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcCurrencies;
        private System.Windows.Forms.TabPage tpShowCurrencies;
        private System.Windows.Forms.DataGridView dgvAllCurrencies;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNumberOfCurrencies;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchCurrency;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tpUpdateRate;
        private System.Windows.Forms.TabPage tpCurrencyCalculator;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnUpdateRate;
        private Guna.UI2.WinForms.Guna2NumericUpDown ncNewRate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2ComboBox cbCurrencyCode;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblFromRate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblFromName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblFromCode;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblFromCountry;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label15;
        private Guna.UI2.WinForms.Guna2ComboBox cbToCurrencyCode;
        private System.Windows.Forms.Label label12;
        private Guna.UI2.WinForms.Guna2ComboBox cbFromCurrencyCode;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblToRate;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label lblToName;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label lblToCode;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label lblToCountry;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private Guna.UI2.WinForms.Guna2Button btnConvert;
        private Guna.UI2.WinForms.Guna2NumericUpDown ncAmountToExchange;
        private System.Windows.Forms.Label lblAmountTo;
        private System.Windows.Forms.Label lblAmountFrom;
    }
}