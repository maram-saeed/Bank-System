namespace Bank_System
{
    partial class frmClientsTransactions
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
            this.tcTransactions = new System.Windows.Forms.TabControl();
            this.tpDeposit = new System.Windows.Forms.TabPage();
            this.btnDepositClearData = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnDeposit = new Guna.UI2.WinForms.Guna2Button();
            this.ncDepositBalance = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCurrentBalance = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbAccountNumbers = new Guna.UI2.WinForms.Guna2ComboBox();
            this.tpWithdraw = new System.Windows.Forms.TabPage();
            this.btnWithDrawClearData = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnWithdraw = new Guna.UI2.WinForms.Guna2Button();
            this.ncWithdrawBalance = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.lblWithdrawCurrentBalance = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbWithDrawAccountNumbers = new Guna.UI2.WinForms.Guna2ComboBox();
            this.tpTotalBalances = new System.Windows.Forms.TabPage();
            this.dgvAllClients = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.lblNumberOfClients = new System.Windows.Forms.Label();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTotalBalancesInLetters = new System.Windows.Forms.Label();
            this.lblTotalBalances = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tpTransferBalances = new System.Windows.Forms.TabPage();
            this.btnTransfer = new Guna.UI2.WinForms.Guna2Button();
            this.ncTransferAmount = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.lblToCurrentBalance = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.cbToAccNumber = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblFromCurrentBalance = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cbFromAccNumber = new Guna.UI2.WinForms.Guna2ComboBox();
            this.tpTransferLog = new System.Windows.Forms.TabPage();
            this.dgvAllTransfersLog = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.lblNumberOfClientsFromLog = new System.Windows.Forms.Label();
            this.txtSearchTransferLog = new Guna.UI2.WinForms.Guna2TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.tcTransactions.SuspendLayout();
            this.tpDeposit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ncDepositBalance)).BeginInit();
            this.tpWithdraw.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ncWithdrawBalance)).BeginInit();
            this.tpTotalBalances.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllClients)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.tpTransferBalances.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ncTransferAmount)).BeginInit();
            this.tpTransferLog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllTransfersLog)).BeginInit();
            this.SuspendLayout();
            // 
            // tcTransactions
            // 
            this.tcTransactions.Controls.Add(this.tpDeposit);
            this.tcTransactions.Controls.Add(this.tpWithdraw);
            this.tcTransactions.Controls.Add(this.tpTotalBalances);
            this.tcTransactions.Controls.Add(this.tpTransferBalances);
            this.tcTransactions.Controls.Add(this.tpTransferLog);
            this.tcTransactions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcTransactions.Font = new System.Drawing.Font("Tahoma", 10F);
            this.tcTransactions.Location = new System.Drawing.Point(0, 0);
            this.tcTransactions.Name = "tcTransactions";
            this.tcTransactions.SelectedIndex = 0;
            this.tcTransactions.Size = new System.Drawing.Size(990, 682);
            this.tcTransactions.TabIndex = 0;
            this.tcTransactions.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tpDeposit
            // 
            this.tpDeposit.BackgroundImage = global::Bank_System.Properties.Resources.bg_login;
            this.tpDeposit.Controls.Add(this.btnDepositClearData);
            this.tpDeposit.Controls.Add(this.pictureBox1);
            this.tpDeposit.Controls.Add(this.btnDeposit);
            this.tpDeposit.Controls.Add(this.ncDepositBalance);
            this.tpDeposit.Controls.Add(this.label3);
            this.tpDeposit.Controls.Add(this.lblCurrentBalance);
            this.tpDeposit.Controls.Add(this.label1);
            this.tpDeposit.Controls.Add(this.label4);
            this.tpDeposit.Controls.Add(this.cbAccountNumbers);
            this.tpDeposit.Location = new System.Drawing.Point(4, 30);
            this.tpDeposit.Name = "tpDeposit";
            this.tpDeposit.Padding = new System.Windows.Forms.Padding(3);
            this.tpDeposit.Size = new System.Drawing.Size(982, 648);
            this.tpDeposit.TabIndex = 0;
            this.tpDeposit.Text = "Deposit";
            this.tpDeposit.UseVisualStyleBackColor = true;
            // 
            // btnDepositClearData
            // 
            this.btnDepositClearData.Animated = true;
            this.btnDepositClearData.BorderColor = System.Drawing.Color.White;
            this.btnDepositClearData.BorderRadius = 5;
            this.btnDepositClearData.BorderThickness = 1;
            this.btnDepositClearData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDepositClearData.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDepositClearData.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDepositClearData.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDepositClearData.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDepositClearData.FillColor = System.Drawing.Color.Transparent;
            this.btnDepositClearData.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDepositClearData.ForeColor = System.Drawing.Color.White;
            this.btnDepositClearData.Location = new System.Drawing.Point(205, 532);
            this.btnDepositClearData.Name = "btnDepositClearData";
            this.btnDepositClearData.PressedColor = System.Drawing.Color.White;
            this.btnDepositClearData.Size = new System.Drawing.Size(220, 49);
            this.btnDepositClearData.TabIndex = 13;
            this.btnDepositClearData.Text = "Clear Data";
            this.btnDepositClearData.Click += new System.EventHandler(this.btnDepositClearData_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Bank_System.Properties.Resources.coin_dollar;
            this.pictureBox1.Location = new System.Drawing.Point(561, 150);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(343, 583);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // btnDeposit
            // 
            this.btnDeposit.Animated = true;
            this.btnDeposit.BorderColor = System.Drawing.Color.White;
            this.btnDeposit.BorderRadius = 5;
            this.btnDeposit.BorderThickness = 1;
            this.btnDeposit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeposit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDeposit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDeposit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDeposit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDeposit.FillColor = System.Drawing.Color.Transparent;
            this.btnDeposit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDeposit.ForeColor = System.Drawing.Color.White;
            this.btnDeposit.Location = new System.Drawing.Point(205, 459);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.PressedColor = System.Drawing.Color.White;
            this.btnDeposit.Size = new System.Drawing.Size(220, 49);
            this.btnDeposit.TabIndex = 11;
            this.btnDeposit.Text = "Deposit";
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // ncDepositBalance
            // 
            this.ncDepositBalance.BackColor = System.Drawing.Color.Transparent;
            this.ncDepositBalance.BorderRadius = 5;
            this.ncDepositBalance.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ncDepositBalance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ncDepositBalance.Location = new System.Drawing.Point(205, 373);
            this.ncDepositBalance.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ncDepositBalance.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.ncDepositBalance.Name = "ncDepositBalance";
            this.ncDepositBalance.Size = new System.Drawing.Size(220, 40);
            this.ncDepositBalance.TabIndex = 9;
            this.ncDepositBalance.UpDownButtonFillColor = System.Drawing.Color.Gold;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(201, 316);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Deposit Amount";
            // 
            // lblCurrentBalance
            // 
            this.lblCurrentBalance.AutoSize = true;
            this.lblCurrentBalance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblCurrentBalance.ForeColor = System.Drawing.Color.Gold;
            this.lblCurrentBalance.Location = new System.Drawing.Point(373, 224);
            this.lblCurrentBalance.Name = "lblCurrentBalance";
            this.lblCurrentBalance.Size = new System.Drawing.Size(32, 21);
            this.lblCurrentBalance.TabIndex = 3;
            this.lblCurrentBalance.Text = "$0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(201, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Current Balance is :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(201, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 21);
            this.label4.TabIndex = 1;
            this.label4.Text = "Account Number";
            // 
            // cbAccountNumbers
            // 
            this.cbAccountNumbers.BackColor = System.Drawing.Color.Transparent;
            this.cbAccountNumbers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbAccountNumbers.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbAccountNumbers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAccountNumbers.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbAccountNumbers.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbAccountNumbers.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbAccountNumbers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbAccountNumbers.IntegralHeight = false;
            this.cbAccountNumbers.ItemHeight = 30;
            this.cbAccountNumbers.Location = new System.Drawing.Point(205, 150);
            this.cbAccountNumbers.MaxDropDownItems = 5;
            this.cbAccountNumbers.Name = "cbAccountNumbers";
            this.cbAccountNumbers.Size = new System.Drawing.Size(220, 36);
            this.cbAccountNumbers.Sorted = true;
            this.cbAccountNumbers.TabIndex = 0;
            this.cbAccountNumbers.SelectedIndexChanged += new System.EventHandler(this.cbAccountNumbers_SelectedIndexChanged);
            // 
            // tpWithdraw
            // 
            this.tpWithdraw.BackgroundImage = global::Bank_System.Properties.Resources.bg_login;
            this.tpWithdraw.Controls.Add(this.btnWithDrawClearData);
            this.tpWithdraw.Controls.Add(this.pictureBox2);
            this.tpWithdraw.Controls.Add(this.btnWithdraw);
            this.tpWithdraw.Controls.Add(this.ncWithdrawBalance);
            this.tpWithdraw.Controls.Add(this.label2);
            this.tpWithdraw.Controls.Add(this.lblWithdrawCurrentBalance);
            this.tpWithdraw.Controls.Add(this.label6);
            this.tpWithdraw.Controls.Add(this.label7);
            this.tpWithdraw.Controls.Add(this.cbWithDrawAccountNumbers);
            this.tpWithdraw.Location = new System.Drawing.Point(4, 30);
            this.tpWithdraw.Name = "tpWithdraw";
            this.tpWithdraw.Padding = new System.Windows.Forms.Padding(3);
            this.tpWithdraw.Size = new System.Drawing.Size(982, 648);
            this.tpWithdraw.TabIndex = 1;
            this.tpWithdraw.Text = "Withdraw";
            this.tpWithdraw.UseVisualStyleBackColor = true;
            // 
            // btnWithDrawClearData
            // 
            this.btnWithDrawClearData.Animated = true;
            this.btnWithDrawClearData.BorderColor = System.Drawing.Color.White;
            this.btnWithDrawClearData.BorderRadius = 5;
            this.btnWithDrawClearData.BorderThickness = 1;
            this.btnWithDrawClearData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWithDrawClearData.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnWithDrawClearData.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnWithDrawClearData.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnWithDrawClearData.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnWithDrawClearData.FillColor = System.Drawing.Color.Transparent;
            this.btnWithDrawClearData.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnWithDrawClearData.ForeColor = System.Drawing.Color.White;
            this.btnWithDrawClearData.Location = new System.Drawing.Point(205, 529);
            this.btnWithDrawClearData.Name = "btnWithDrawClearData";
            this.btnWithDrawClearData.PressedColor = System.Drawing.Color.White;
            this.btnWithDrawClearData.Size = new System.Drawing.Size(220, 49);
            this.btnWithDrawClearData.TabIndex = 21;
            this.btnWithDrawClearData.Text = "Clear Data";
            this.btnWithDrawClearData.Click += new System.EventHandler(this.btnWithDrawClearData_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Bank_System.Properties.Resources.coin_dollar;
            this.pictureBox2.Location = new System.Drawing.Point(561, 150);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(343, 583);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.Animated = true;
            this.btnWithdraw.BorderColor = System.Drawing.Color.White;
            this.btnWithdraw.BorderRadius = 5;
            this.btnWithdraw.BorderThickness = 1;
            this.btnWithdraw.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWithdraw.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnWithdraw.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnWithdraw.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnWithdraw.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnWithdraw.FillColor = System.Drawing.Color.Transparent;
            this.btnWithdraw.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnWithdraw.ForeColor = System.Drawing.Color.White;
            this.btnWithdraw.Location = new System.Drawing.Point(205, 453);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.PressedColor = System.Drawing.Color.White;
            this.btnWithdraw.Size = new System.Drawing.Size(220, 49);
            this.btnWithdraw.TabIndex = 19;
            this.btnWithdraw.Text = "Withdraw";
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // ncWithdrawBalance
            // 
            this.ncWithdrawBalance.BackColor = System.Drawing.Color.Transparent;
            this.ncWithdrawBalance.BorderRadius = 5;
            this.ncWithdrawBalance.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ncWithdrawBalance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ncWithdrawBalance.Location = new System.Drawing.Point(205, 377);
            this.ncWithdrawBalance.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ncWithdrawBalance.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.ncWithdrawBalance.Name = "ncWithdrawBalance";
            this.ncWithdrawBalance.Size = new System.Drawing.Size(220, 40);
            this.ncWithdrawBalance.TabIndex = 18;
            this.ncWithdrawBalance.UpDownButtonFillColor = System.Drawing.Color.Gold;
            this.ncWithdrawBalance.ValueChanged += new System.EventHandler(this.ncWithdrawBalance_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(201, 320);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 21);
            this.label2.TabIndex = 17;
            this.label2.Text = "Withdraw Amount";
            // 
            // lblWithdrawCurrentBalance
            // 
            this.lblWithdrawCurrentBalance.AutoSize = true;
            this.lblWithdrawCurrentBalance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblWithdrawCurrentBalance.ForeColor = System.Drawing.Color.Gold;
            this.lblWithdrawCurrentBalance.Location = new System.Drawing.Point(373, 228);
            this.lblWithdrawCurrentBalance.Name = "lblWithdrawCurrentBalance";
            this.lblWithdrawCurrentBalance.Size = new System.Drawing.Size(32, 21);
            this.lblWithdrawCurrentBalance.TabIndex = 16;
            this.lblWithdrawCurrentBalance.Text = "$0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(201, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(176, 21);
            this.label6.TabIndex = 15;
            this.label6.Text = "Current Balance is :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(201, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 21);
            this.label7.TabIndex = 14;
            this.label7.Text = "Account Number";
            // 
            // cbWithDrawAccountNumbers
            // 
            this.cbWithDrawAccountNumbers.BackColor = System.Drawing.Color.Transparent;
            this.cbWithDrawAccountNumbers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbWithDrawAccountNumbers.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbWithDrawAccountNumbers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbWithDrawAccountNumbers.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbWithDrawAccountNumbers.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbWithDrawAccountNumbers.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbWithDrawAccountNumbers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbWithDrawAccountNumbers.IntegralHeight = false;
            this.cbWithDrawAccountNumbers.ItemHeight = 30;
            this.cbWithDrawAccountNumbers.Location = new System.Drawing.Point(205, 154);
            this.cbWithDrawAccountNumbers.MaxDropDownItems = 5;
            this.cbWithDrawAccountNumbers.Name = "cbWithDrawAccountNumbers";
            this.cbWithDrawAccountNumbers.Size = new System.Drawing.Size(220, 36);
            this.cbWithDrawAccountNumbers.Sorted = true;
            this.cbWithDrawAccountNumbers.TabIndex = 13;
            this.cbWithDrawAccountNumbers.SelectedIndexChanged += new System.EventHandler(this.cbWithDrawAccountNumbers_SelectedIndexChanged);
            // 
            // tpTotalBalances
            // 
            this.tpTotalBalances.BackgroundImage = global::Bank_System.Properties.Resources.bg_login;
            this.tpTotalBalances.Controls.Add(this.dgvAllClients);
            this.tpTotalBalances.Controls.Add(this.label8);
            this.tpTotalBalances.Controls.Add(this.lblNumberOfClients);
            this.tpTotalBalances.Controls.Add(this.txtSearch);
            this.tpTotalBalances.Controls.Add(this.label9);
            this.tpTotalBalances.Controls.Add(this.guna2Panel1);
            this.tpTotalBalances.Location = new System.Drawing.Point(4, 30);
            this.tpTotalBalances.Name = "tpTotalBalances";
            this.tpTotalBalances.Padding = new System.Windows.Forms.Padding(3);
            this.tpTotalBalances.Size = new System.Drawing.Size(982, 648);
            this.tpTotalBalances.TabIndex = 2;
            this.tpTotalBalances.Text = "TotalBalances";
            this.tpTotalBalances.UseVisualStyleBackColor = true;
            // 
            // dgvAllClients
            // 
            this.dgvAllClients.BackgroundColor = System.Drawing.Color.White;
            this.dgvAllClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllClients.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvAllClients.Location = new System.Drawing.Point(6, 337);
            this.dgvAllClients.Name = "dgvAllClients";
            this.dgvAllClients.RowHeadersWidth = 51;
            this.dgvAllClients.RowTemplate.Height = 26;
            this.dgvAllClients.Size = new System.Drawing.Size(968, 308);
            this.dgvAllClients.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(49, 294);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 21);
            this.label8.TabIndex = 9;
            this.label8.Text = "Client(s) Found";
            // 
            // lblNumberOfClients
            // 
            this.lblNumberOfClients.AutoSize = true;
            this.lblNumberOfClients.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblNumberOfClients.ForeColor = System.Drawing.Color.Gold;
            this.lblNumberOfClients.Location = new System.Drawing.Point(24, 294);
            this.lblNumberOfClients.Name = "lblNumberOfClients";
            this.lblNumberOfClients.Size = new System.Drawing.Size(19, 21);
            this.lblNumberOfClients.TabIndex = 8;
            this.lblNumberOfClients.Text = "0";
            // 
            // txtSearch
            // 
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(118)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtSearch.ForeColor = System.Drawing.Color.Gold;
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.IconLeft = global::Bank_System.Properties.Resources.search;
            this.txtSearch.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.txtSearch.Location = new System.Drawing.Point(28, 219);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderText = "";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(261, 46);
            this.txtSearch.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtSearch.TabIndex = 7;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(34, 168);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(211, 21);
            this.label9.TabIndex = 6;
            this.label9.Text = "Search By Account Number";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.Controls.Add(this.lblTotalBalancesInLetters);
            this.guna2Panel1.Controls.Add(this.lblTotalBalances);
            this.guna2Panel1.Controls.Add(this.label5);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(3, 3);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(976, 128);
            this.guna2Panel1.TabIndex = 0;
            // 
            // lblTotalBalancesInLetters
            // 
            this.lblTotalBalancesInLetters.AutoSize = true;
            this.lblTotalBalancesInLetters.Font = new System.Drawing.Font("Tahoma", 15F);
            this.lblTotalBalancesInLetters.ForeColor = System.Drawing.Color.White;
            this.lblTotalBalancesInLetters.Location = new System.Drawing.Point(25, 74);
            this.lblTotalBalancesInLetters.Name = "lblTotalBalancesInLetters";
            this.lblTotalBalancesInLetters.Size = new System.Drawing.Size(216, 30);
            this.lblTotalBalancesInLetters.TabIndex = 2;
            this.lblTotalBalancesInLetters.Text = "( Letter ) Dollar(s)";
            // 
            // lblTotalBalances
            // 
            this.lblTotalBalances.AutoSize = true;
            this.lblTotalBalances.Font = new System.Drawing.Font("Tahoma", 15F);
            this.lblTotalBalances.ForeColor = System.Drawing.Color.Gold;
            this.lblTotalBalances.Location = new System.Drawing.Point(230, 23);
            this.lblTotalBalances.Name = "lblTotalBalances";
            this.lblTotalBalances.Size = new System.Drawing.Size(41, 30);
            this.lblTotalBalances.TabIndex = 1;
            this.lblTotalBalances.Text = "$0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(25, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(216, 30);
            this.label5.TabIndex = 0;
            this.label5.Text = "Total Balances is :";
            // 
            // tpTransferBalances
            // 
            this.tpTransferBalances.BackgroundImage = global::Bank_System.Properties.Resources.bg_login;
            this.tpTransferBalances.Controls.Add(this.btnTransfer);
            this.tpTransferBalances.Controls.Add(this.ncTransferAmount);
            this.tpTransferBalances.Controls.Add(this.label16);
            this.tpTransferBalances.Controls.Add(this.lblToCurrentBalance);
            this.tpTransferBalances.Controls.Add(this.label14);
            this.tpTransferBalances.Controls.Add(this.label15);
            this.tpTransferBalances.Controls.Add(this.cbToAccNumber);
            this.tpTransferBalances.Controls.Add(this.lblFromCurrentBalance);
            this.tpTransferBalances.Controls.Add(this.label11);
            this.tpTransferBalances.Controls.Add(this.label12);
            this.tpTransferBalances.Controls.Add(this.cbFromAccNumber);
            this.tpTransferBalances.Location = new System.Drawing.Point(4, 30);
            this.tpTransferBalances.Name = "tpTransferBalances";
            this.tpTransferBalances.Size = new System.Drawing.Size(982, 648);
            this.tpTransferBalances.TabIndex = 3;
            this.tpTransferBalances.Text = "TransferBalances";
            this.tpTransferBalances.UseVisualStyleBackColor = true;
            // 
            // btnTransfer
            // 
            this.btnTransfer.Animated = true;
            this.btnTransfer.BorderColor = System.Drawing.Color.White;
            this.btnTransfer.BorderRadius = 5;
            this.btnTransfer.BorderThickness = 1;
            this.btnTransfer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTransfer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTransfer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTransfer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTransfer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTransfer.Enabled = false;
            this.btnTransfer.FillColor = System.Drawing.Color.Transparent;
            this.btnTransfer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTransfer.ForeColor = System.Drawing.Color.White;
            this.btnTransfer.Location = new System.Drawing.Point(351, 462);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.PressedColor = System.Drawing.Color.White;
            this.btnTransfer.Size = new System.Drawing.Size(220, 49);
            this.btnTransfer.TabIndex = 27;
            this.btnTransfer.Text = "Transfer";
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // ncTransferAmount
            // 
            this.ncTransferAmount.BackColor = System.Drawing.Color.Transparent;
            this.ncTransferAmount.BorderRadius = 5;
            this.ncTransferAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ncTransferAmount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ncTransferAmount.Location = new System.Drawing.Point(351, 386);
            this.ncTransferAmount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ncTransferAmount.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.ncTransferAmount.Name = "ncTransferAmount";
            this.ncTransferAmount.Size = new System.Drawing.Size(220, 40);
            this.ncTransferAmount.TabIndex = 26;
            this.ncTransferAmount.UpDownButtonFillColor = System.Drawing.Color.Gold;
            this.ncTransferAmount.ValueChanged += new System.EventHandler(this.ncTransferAmount_ValueChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(347, 329);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(154, 21);
            this.label16.TabIndex = 25;
            this.label16.Text = "Transfer Amount";
            // 
            // lblToCurrentBalance
            // 
            this.lblToCurrentBalance.AutoSize = true;
            this.lblToCurrentBalance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblToCurrentBalance.ForeColor = System.Drawing.Color.Gold;
            this.lblToCurrentBalance.Location = new System.Drawing.Point(747, 181);
            this.lblToCurrentBalance.Name = "lblToCurrentBalance";
            this.lblToCurrentBalance.Size = new System.Drawing.Size(32, 21);
            this.lblToCurrentBalance.TabIndex = 24;
            this.lblToCurrentBalance.Text = "$0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(575, 181);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(176, 21);
            this.label14.TabIndex = 23;
            this.label14.Text = "Current Balance is :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(575, 64);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(144, 21);
            this.label15.TabIndex = 22;
            this.label15.Text = "To Acc. Number";
            // 
            // cbToAccNumber
            // 
            this.cbToAccNumber.BackColor = System.Drawing.Color.Transparent;
            this.cbToAccNumber.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbToAccNumber.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbToAccNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbToAccNumber.Enabled = false;
            this.cbToAccNumber.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbToAccNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbToAccNumber.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbToAccNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbToAccNumber.IntegralHeight = false;
            this.cbToAccNumber.ItemHeight = 30;
            this.cbToAccNumber.Location = new System.Drawing.Point(579, 107);
            this.cbToAccNumber.MaxDropDownItems = 5;
            this.cbToAccNumber.Name = "cbToAccNumber";
            this.cbToAccNumber.Size = new System.Drawing.Size(220, 36);
            this.cbToAccNumber.Sorted = true;
            this.cbToAccNumber.TabIndex = 21;
            this.cbToAccNumber.SelectedIndexChanged += new System.EventHandler(this.cbToAccNumber_SelectedIndexChanged);
            // 
            // lblFromCurrentBalance
            // 
            this.lblFromCurrentBalance.AutoSize = true;
            this.lblFromCurrentBalance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblFromCurrentBalance.ForeColor = System.Drawing.Color.Gold;
            this.lblFromCurrentBalance.Location = new System.Drawing.Point(288, 181);
            this.lblFromCurrentBalance.Name = "lblFromCurrentBalance";
            this.lblFromCurrentBalance.Size = new System.Drawing.Size(32, 21);
            this.lblFromCurrentBalance.TabIndex = 20;
            this.lblFromCurrentBalance.Text = "$0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(116, 181);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(176, 21);
            this.label11.TabIndex = 19;
            this.label11.Text = "Current Balance is :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(116, 64);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(167, 21);
            this.label12.TabIndex = 18;
            this.label12.Text = "From Acc. Number";
            // 
            // cbFromAccNumber
            // 
            this.cbFromAccNumber.BackColor = System.Drawing.Color.Transparent;
            this.cbFromAccNumber.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbFromAccNumber.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbFromAccNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFromAccNumber.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbFromAccNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbFromAccNumber.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbFromAccNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbFromAccNumber.IntegralHeight = false;
            this.cbFromAccNumber.ItemHeight = 30;
            this.cbFromAccNumber.Location = new System.Drawing.Point(120, 107);
            this.cbFromAccNumber.MaxDropDownItems = 5;
            this.cbFromAccNumber.Name = "cbFromAccNumber";
            this.cbFromAccNumber.Size = new System.Drawing.Size(220, 36);
            this.cbFromAccNumber.Sorted = true;
            this.cbFromAccNumber.TabIndex = 17;
            this.cbFromAccNumber.SelectedIndexChanged += new System.EventHandler(this.cbFromAccNumber_SelectedIndexChanged);
            // 
            // tpTransferLog
            // 
            this.tpTransferLog.BackgroundImage = global::Bank_System.Properties.Resources.bg_login;
            this.tpTransferLog.Controls.Add(this.dgvAllTransfersLog);
            this.tpTransferLog.Controls.Add(this.label10);
            this.tpTransferLog.Controls.Add(this.lblNumberOfClientsFromLog);
            this.tpTransferLog.Controls.Add(this.txtSearchTransferLog);
            this.tpTransferLog.Controls.Add(this.label17);
            this.tpTransferLog.Location = new System.Drawing.Point(4, 30);
            this.tpTransferLog.Name = "tpTransferLog";
            this.tpTransferLog.Size = new System.Drawing.Size(982, 648);
            this.tpTransferLog.TabIndex = 4;
            this.tpTransferLog.Text = "TransferLog";
            this.tpTransferLog.UseVisualStyleBackColor = true;
            // 
            // dgvAllTransfersLog
            // 
            this.dgvAllTransfersLog.BackgroundColor = System.Drawing.Color.White;
            this.dgvAllTransfersLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllTransfersLog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvAllTransfersLog.Location = new System.Drawing.Point(6, 337);
            this.dgvAllTransfersLog.Name = "dgvAllTransfersLog";
            this.dgvAllTransfersLog.RowHeadersWidth = 51;
            this.dgvAllTransfersLog.RowTemplate.Height = 26;
            this.dgvAllTransfersLog.Size = new System.Drawing.Size(968, 308);
            this.dgvAllTransfersLog.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(52, 247);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 21);
            this.label10.TabIndex = 14;
            this.label10.Text = "Client(s) Found";
            // 
            // lblNumberOfClientsFromLog
            // 
            this.lblNumberOfClientsFromLog.AutoSize = true;
            this.lblNumberOfClientsFromLog.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblNumberOfClientsFromLog.ForeColor = System.Drawing.Color.Gold;
            this.lblNumberOfClientsFromLog.Location = new System.Drawing.Point(27, 247);
            this.lblNumberOfClientsFromLog.Name = "lblNumberOfClientsFromLog";
            this.lblNumberOfClientsFromLog.Size = new System.Drawing.Size(19, 21);
            this.lblNumberOfClientsFromLog.TabIndex = 13;
            this.lblNumberOfClientsFromLog.Text = "0";
            // 
            // txtSearchTransferLog
            // 
            this.txtSearchTransferLog.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchTransferLog.DefaultText = "";
            this.txtSearchTransferLog.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearchTransferLog.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearchTransferLog.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchTransferLog.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchTransferLog.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(118)))));
            this.txtSearchTransferLog.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchTransferLog.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtSearchTransferLog.ForeColor = System.Drawing.Color.Gold;
            this.txtSearchTransferLog.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchTransferLog.IconLeft = global::Bank_System.Properties.Resources.search;
            this.txtSearchTransferLog.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.txtSearchTransferLog.Location = new System.Drawing.Point(31, 172);
            this.txtSearchTransferLog.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearchTransferLog.Name = "txtSearchTransferLog";
            this.txtSearchTransferLog.PlaceholderText = "";
            this.txtSearchTransferLog.SelectedText = "";
            this.txtSearchTransferLog.Size = new System.Drawing.Size(261, 46);
            this.txtSearchTransferLog.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtSearchTransferLog.TabIndex = 12;
            this.txtSearchTransferLog.TextChanged += new System.EventHandler(this.txtSearchTransferLog_TextChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(37, 121);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(170, 21);
            this.label17.TabIndex = 11;
            this.label17.Text = "Search By User Name";
            // 
            // frmClientsTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 682);
            this.Controls.Add(this.tcTransactions);
            this.Name = "frmClientsTransactions";
            this.Text = "frmClientsTransactions";
            this.Load += new System.EventHandler(this.frmClientsTransactions_Load);
            this.tcTransactions.ResumeLayout(false);
            this.tpDeposit.ResumeLayout(false);
            this.tpDeposit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ncDepositBalance)).EndInit();
            this.tpWithdraw.ResumeLayout(false);
            this.tpWithdraw.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ncWithdrawBalance)).EndInit();
            this.tpTotalBalances.ResumeLayout(false);
            this.tpTotalBalances.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllClients)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.tpTransferBalances.ResumeLayout(false);
            this.tpTransferBalances.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ncTransferAmount)).EndInit();
            this.tpTransferLog.ResumeLayout(false);
            this.tpTransferLog.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllTransfersLog)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcTransactions;
        private System.Windows.Forms.TabPage tpDeposit;
        private System.Windows.Forms.TabPage tpWithdraw;
        private System.Windows.Forms.TabPage tpTotalBalances;
        private System.Windows.Forms.TabPage tpTransferBalances;
        private System.Windows.Forms.TabPage tpTransferLog;
        private Guna.UI2.WinForms.Guna2ComboBox cbAccountNumbers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCurrentBalance;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2NumericUpDown ncDepositBalance;
        private Guna.UI2.WinForms.Guna2Button btnDeposit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Guna.UI2.WinForms.Guna2Button btnWithdraw;
        private Guna.UI2.WinForms.Guna2NumericUpDown ncWithdrawBalance;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblWithdrawCurrentBalance;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2ComboBox cbWithDrawAccountNumbers;
        private Guna.UI2.WinForms.Guna2Button btnDepositClearData;
        private Guna.UI2.WinForms.Guna2Button btnWithDrawClearData;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTotalBalances;
        private System.Windows.Forms.Label lblTotalBalancesInLetters;
        private System.Windows.Forms.DataGridView dgvAllClients;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblNumberOfClients;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2Button btnTransfer;
        private Guna.UI2.WinForms.Guna2NumericUpDown ncTransferAmount;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblToCurrentBalance;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private Guna.UI2.WinForms.Guna2ComboBox cbToAccNumber;
        private System.Windows.Forms.Label lblFromCurrentBalance;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private Guna.UI2.WinForms.Guna2ComboBox cbFromAccNumber;
        private System.Windows.Forms.DataGridView dgvAllTransfersLog;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblNumberOfClientsFromLog;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchTransferLog;
        private System.Windows.Forms.Label label17;
    }
}