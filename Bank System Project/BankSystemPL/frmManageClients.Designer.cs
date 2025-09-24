namespace Bank_System
{
    partial class frmManageClients
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
            this.components = new System.ComponentModel.Container();
            this.tcShowClients = new System.Windows.Forms.TabControl();
            this.tpShowClients = new System.Windows.Forms.TabPage();
            this.dgvAllClients = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNumberOfClients = new System.Windows.Forms.Label();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tpAddNewClient = new System.Windows.Forms.TabPage();
            this.txtAddUserID = new Guna.UI2.WinForms.Guna2TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.btnAddNewClient = new Guna.UI2.WinForms.Guna2Button();
            this.ncAddBalance = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.txtAddPhone = new Guna.UI2.WinForms.Guna2TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAddLastName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAddPinCode = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAddEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAddFirstName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAddAccNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tpUpdateClient = new System.Windows.Forms.TabPage();
            this.txtUpdateUserID = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnUpdateClient = new Guna.UI2.WinForms.Guna2Button();
            this.ncUpdateBalance = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.txtUpdatePhone = new Guna.UI2.WinForms.Guna2TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtUpdateLastName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtUpdatePinCode = new Guna.UI2.WinForms.Guna2TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtUpdateEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtUpdateFirstName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtUpdateAccNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tcShowClients.SuspendLayout();
            this.tpShowClients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllClients)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.tpAddNewClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ncAddBalance)).BeginInit();
            this.tpUpdateClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ncUpdateBalance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tcShowClients
            // 
            this.tcShowClients.Controls.Add(this.tpShowClients);
            this.tcShowClients.Controls.Add(this.tpAddNewClient);
            this.tcShowClients.Controls.Add(this.tpUpdateClient);
            this.tcShowClients.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tcShowClients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcShowClients.Font = new System.Drawing.Font("Tahoma", 10F);
            this.tcShowClients.Location = new System.Drawing.Point(0, 0);
            this.tcShowClients.Name = "tcShowClients";
            this.tcShowClients.Padding = new System.Drawing.Point(8, 7);
            this.tcShowClients.SelectedIndex = 0;
            this.tcShowClients.Size = new System.Drawing.Size(990, 682);
            this.tcShowClients.TabIndex = 0;
            this.tcShowClients.SelectedIndexChanged += new System.EventHandler(this.tcShowClients_SelectedIndexChanged);
            // 
            // tpShowClients
            // 
            this.tpShowClients.BackgroundImage = global::Bank_System.Properties.Resources.bg_login;
            this.tpShowClients.Controls.Add(this.dgvAllClients);
            this.tpShowClients.Controls.Add(this.label3);
            this.tpShowClients.Controls.Add(this.lblNumberOfClients);
            this.tpShowClients.Controls.Add(this.txtSearch);
            this.tpShowClients.Controls.Add(this.label1);
            this.tpShowClients.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tpShowClients.Font = new System.Drawing.Font("Tahoma", 10F);
            this.tpShowClients.Location = new System.Drawing.Point(4, 38);
            this.tpShowClients.Name = "tpShowClients";
            this.tpShowClients.Padding = new System.Windows.Forms.Padding(3);
            this.tpShowClients.Size = new System.Drawing.Size(982, 640);
            this.tpShowClients.TabIndex = 0;
            this.tpShowClients.Text = "Show Clients";
            this.tpShowClients.UseVisualStyleBackColor = true;
            // 
            // dgvAllClients
            // 
            this.dgvAllClients.BackgroundColor = System.Drawing.Color.White;
            this.dgvAllClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllClients.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvAllClients.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvAllClients.Location = new System.Drawing.Point(8, 272);
            this.dgvAllClients.Name = "dgvAllClients";
            this.dgvAllClients.RowHeadersWidth = 51;
            this.dgvAllClients.RowTemplate.Height = 26;
            this.dgvAllClients.Size = new System.Drawing.Size(968, 360);
            this.dgvAllClients.TabIndex = 5;
            this.dgvAllClients.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAllClients_CellDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(123, 28);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(122, 24);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(54, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Client(s) Found";
            // 
            // lblNumberOfClients
            // 
            this.lblNumberOfClients.AutoSize = true;
            this.lblNumberOfClients.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblNumberOfClients.ForeColor = System.Drawing.Color.Gold;
            this.lblNumberOfClients.Location = new System.Drawing.Point(29, 220);
            this.lblNumberOfClients.Name = "lblNumberOfClients";
            this.lblNumberOfClients.Size = new System.Drawing.Size(19, 21);
            this.lblNumberOfClients.TabIndex = 2;
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
            this.txtSearch.Location = new System.Drawing.Point(33, 145);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderText = "";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(261, 46);
            this.txtSearch.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(39, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search By Account Number";
            // 
            // tpAddNewClient
            // 
            this.tpAddNewClient.BackgroundImage = global::Bank_System.Properties.Resources.bg_login;
            this.tpAddNewClient.Controls.Add(this.txtAddUserID);
            this.tpAddNewClient.Controls.Add(this.label18);
            this.tpAddNewClient.Controls.Add(this.btnAddNewClient);
            this.tpAddNewClient.Controls.Add(this.ncAddBalance);
            this.tpAddNewClient.Controls.Add(this.label10);
            this.tpAddNewClient.Controls.Add(this.txtAddPhone);
            this.tpAddNewClient.Controls.Add(this.label9);
            this.tpAddNewClient.Controls.Add(this.txtAddLastName);
            this.tpAddNewClient.Controls.Add(this.label8);
            this.tpAddNewClient.Controls.Add(this.txtAddPinCode);
            this.tpAddNewClient.Controls.Add(this.label7);
            this.tpAddNewClient.Controls.Add(this.txtAddEmail);
            this.tpAddNewClient.Controls.Add(this.label6);
            this.tpAddNewClient.Controls.Add(this.txtAddFirstName);
            this.tpAddNewClient.Controls.Add(this.label5);
            this.tpAddNewClient.Controls.Add(this.txtAddAccNumber);
            this.tpAddNewClient.Controls.Add(this.label4);
            this.tpAddNewClient.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tpAddNewClient.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.tpAddNewClient.Location = new System.Drawing.Point(4, 38);
            this.tpAddNewClient.Name = "tpAddNewClient";
            this.tpAddNewClient.Padding = new System.Windows.Forms.Padding(3);
            this.tpAddNewClient.Size = new System.Drawing.Size(982, 640);
            this.tpAddNewClient.TabIndex = 1;
            this.tpAddNewClient.Text = "Add New Client";
            this.tpAddNewClient.UseVisualStyleBackColor = true;
            // 
            // txtAddUserID
            // 
            this.txtAddUserID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddUserID.DefaultText = "";
            this.txtAddUserID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAddUserID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAddUserID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddUserID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddUserID.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(118)))));
            this.txtAddUserID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAddUserID.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtAddUserID.ForeColor = System.Drawing.Color.Gold;
            this.txtAddUserID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAddUserID.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.txtAddUserID.Location = new System.Drawing.Point(51, 371);
            this.txtAddUserID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAddUserID.Name = "txtAddUserID";
            this.txtAddUserID.PlaceholderText = "";
            this.txtAddUserID.SelectedText = "";
            this.txtAddUserID.Size = new System.Drawing.Size(220, 45);
            this.txtAddUserID.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtAddUserID.TabIndex = 7;
            this.txtAddUserID.Validating += new System.ComponentModel.CancelEventHandler(this.txtAddUserID_Validating);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(47, 326);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(75, 21);
            this.label18.TabIndex = 15;
            this.label18.Text = "User ID";
            // 
            // btnAddNewClient
            // 
            this.btnAddNewClient.Animated = true;
            this.btnAddNewClient.BorderColor = System.Drawing.Color.White;
            this.btnAddNewClient.BorderRadius = 5;
            this.btnAddNewClient.BorderThickness = 1;
            this.btnAddNewClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddNewClient.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNewClient.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNewClient.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddNewClient.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddNewClient.FillColor = System.Drawing.Color.Transparent;
            this.btnAddNewClient.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddNewClient.ForeColor = System.Drawing.Color.White;
            this.btnAddNewClient.Location = new System.Drawing.Point(339, 509);
            this.btnAddNewClient.Name = "btnAddNewClient";
            this.btnAddNewClient.PressedColor = System.Drawing.Color.White;
            this.btnAddNewClient.Size = new System.Drawing.Size(220, 49);
            this.btnAddNewClient.TabIndex = 10;
            this.btnAddNewClient.Text = "Add New Client";
            this.btnAddNewClient.Click += new System.EventHandler(this.btnAddNewClient_Click);
            // 
            // ncAddBalance
            // 
            this.ncAddBalance.BackColor = System.Drawing.Color.Transparent;
            this.ncAddBalance.BorderRadius = 5;
            this.ncAddBalance.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ncAddBalance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ncAddBalance.Location = new System.Drawing.Point(339, 376);
            this.ncAddBalance.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ncAddBalance.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.ncAddBalance.Name = "ncAddBalance";
            this.ncAddBalance.Size = new System.Drawing.Size(220, 40);
            this.ncAddBalance.TabIndex = 8;
            this.ncAddBalance.UpDownButtonFillColor = System.Drawing.Color.Gold;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(335, 337);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 21);
            this.label10.TabIndex = 12;
            this.label10.Text = "Balance";
            // 
            // txtAddPhone
            // 
            this.txtAddPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddPhone.DefaultText = "";
            this.txtAddPhone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAddPhone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAddPhone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddPhone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddPhone.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(118)))));
            this.txtAddPhone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAddPhone.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtAddPhone.ForeColor = System.Drawing.Color.Gold;
            this.txtAddPhone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAddPhone.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.txtAddPhone.Location = new System.Drawing.Point(619, 225);
            this.txtAddPhone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAddPhone.Name = "txtAddPhone";
            this.txtAddPhone.PlaceholderText = "";
            this.txtAddPhone.SelectedText = "";
            this.txtAddPhone.Size = new System.Drawing.Size(220, 45);
            this.txtAddPhone.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtAddPhone.TabIndex = 6;
            this.txtAddPhone.Validating += new System.ComponentModel.CancelEventHandler(this.txtAddPhone_Validating);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(615, 180);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 21);
            this.label9.TabIndex = 11;
            this.label9.Text = "Phone";
            // 
            // txtAddLastName
            // 
            this.txtAddLastName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddLastName.DefaultText = "";
            this.txtAddLastName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAddLastName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAddLastName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddLastName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddLastName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(118)))));
            this.txtAddLastName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAddLastName.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtAddLastName.ForeColor = System.Drawing.Color.Gold;
            this.txtAddLastName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAddLastName.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.txtAddLastName.Location = new System.Drawing.Point(51, 225);
            this.txtAddLastName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAddLastName.Name = "txtAddLastName";
            this.txtAddLastName.PlaceholderText = "";
            this.txtAddLastName.SelectedText = "";
            this.txtAddLastName.Size = new System.Drawing.Size(220, 45);
            this.txtAddLastName.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtAddLastName.TabIndex = 4;
            this.txtAddLastName.Validating += new System.ComponentModel.CancelEventHandler(this.txtAddLastName_Validating);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(47, 180);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 21);
            this.label8.TabIndex = 9;
            this.label8.Text = "Last Name";
            // 
            // txtAddPinCode
            // 
            this.txtAddPinCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddPinCode.DefaultText = "";
            this.txtAddPinCode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAddPinCode.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAddPinCode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddPinCode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddPinCode.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(118)))));
            this.txtAddPinCode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAddPinCode.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtAddPinCode.ForeColor = System.Drawing.Color.Gold;
            this.txtAddPinCode.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAddPinCode.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.txtAddPinCode.Location = new System.Drawing.Point(339, 90);
            this.txtAddPinCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAddPinCode.Name = "txtAddPinCode";
            this.txtAddPinCode.PlaceholderText = "";
            this.txtAddPinCode.SelectedText = "";
            this.txtAddPinCode.Size = new System.Drawing.Size(220, 45);
            this.txtAddPinCode.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtAddPinCode.TabIndex = 2;
            this.txtAddPinCode.Validating += new System.ComponentModel.CancelEventHandler(this.txtAddPinCode_Validating);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(335, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 21);
            this.label7.TabIndex = 7;
            this.label7.Text = "Pin Code";
            // 
            // txtAddEmail
            // 
            this.txtAddEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddEmail.DefaultText = "";
            this.txtAddEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAddEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAddEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddEmail.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(118)))));
            this.txtAddEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAddEmail.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtAddEmail.ForeColor = System.Drawing.Color.Gold;
            this.txtAddEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAddEmail.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.txtAddEmail.Location = new System.Drawing.Point(339, 225);
            this.txtAddEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAddEmail.Name = "txtAddEmail";
            this.txtAddEmail.PlaceholderText = "";
            this.txtAddEmail.SelectedText = "";
            this.txtAddEmail.Size = new System.Drawing.Size(220, 45);
            this.txtAddEmail.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtAddEmail.TabIndex = 5;
            this.txtAddEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txtAddEmail_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(335, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "Email";
            // 
            // txtAddFirstName
            // 
            this.txtAddFirstName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddFirstName.DefaultText = "";
            this.txtAddFirstName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAddFirstName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAddFirstName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddFirstName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddFirstName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(118)))));
            this.txtAddFirstName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAddFirstName.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtAddFirstName.ForeColor = System.Drawing.Color.Gold;
            this.txtAddFirstName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAddFirstName.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.txtAddFirstName.Location = new System.Drawing.Point(619, 90);
            this.txtAddFirstName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAddFirstName.Name = "txtAddFirstName";
            this.txtAddFirstName.PlaceholderText = "";
            this.txtAddFirstName.SelectedText = "";
            this.txtAddFirstName.Size = new System.Drawing.Size(220, 45);
            this.txtAddFirstName.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtAddFirstName.TabIndex = 3;
            this.txtAddFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.txtAddFirstName_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(615, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 21);
            this.label5.TabIndex = 3;
            this.label5.Text = "First Name";
            // 
            // txtAddAccNumber
            // 
            this.txtAddAccNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddAccNumber.DefaultText = "";
            this.txtAddAccNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAddAccNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAddAccNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddAccNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddAccNumber.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(118)))));
            this.txtAddAccNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAddAccNumber.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtAddAccNumber.ForeColor = System.Drawing.Color.Gold;
            this.txtAddAccNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAddAccNumber.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.txtAddAccNumber.Location = new System.Drawing.Point(51, 90);
            this.txtAddAccNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAddAccNumber.Name = "txtAddAccNumber";
            this.txtAddAccNumber.PlaceholderText = "";
            this.txtAddAccNumber.SelectedText = "";
            this.txtAddAccNumber.Size = new System.Drawing.Size(220, 45);
            this.txtAddAccNumber.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtAddAccNumber.TabIndex = 1;
            this.txtAddAccNumber.Validating += new System.ComponentModel.CancelEventHandler(this.txtAddAccNumber_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(47, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Account Nunber";
            // 
            // tpUpdateClient
            // 
            this.tpUpdateClient.BackgroundImage = global::Bank_System.Properties.Resources.bg_login;
            this.tpUpdateClient.Controls.Add(this.txtUpdateUserID);
            this.tpUpdateClient.Controls.Add(this.label2);
            this.tpUpdateClient.Controls.Add(this.btnUpdateClient);
            this.tpUpdateClient.Controls.Add(this.ncUpdateBalance);
            this.tpUpdateClient.Controls.Add(this.label11);
            this.tpUpdateClient.Controls.Add(this.txtUpdatePhone);
            this.tpUpdateClient.Controls.Add(this.label12);
            this.tpUpdateClient.Controls.Add(this.txtUpdateLastName);
            this.tpUpdateClient.Controls.Add(this.label13);
            this.tpUpdateClient.Controls.Add(this.txtUpdatePinCode);
            this.tpUpdateClient.Controls.Add(this.label14);
            this.tpUpdateClient.Controls.Add(this.txtUpdateEmail);
            this.tpUpdateClient.Controls.Add(this.label15);
            this.tpUpdateClient.Controls.Add(this.txtUpdateFirstName);
            this.tpUpdateClient.Controls.Add(this.label16);
            this.tpUpdateClient.Controls.Add(this.txtUpdateAccNumber);
            this.tpUpdateClient.Controls.Add(this.label17);
            this.tpUpdateClient.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tpUpdateClient.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.tpUpdateClient.Location = new System.Drawing.Point(4, 38);
            this.tpUpdateClient.Name = "tpUpdateClient";
            this.tpUpdateClient.Padding = new System.Windows.Forms.Padding(3);
            this.tpUpdateClient.Size = new System.Drawing.Size(982, 640);
            this.tpUpdateClient.TabIndex = 2;
            this.tpUpdateClient.Text = "Update Client";
            this.tpUpdateClient.UseVisualStyleBackColor = true;
            // 
            // txtUpdateUserID
            // 
            this.txtUpdateUserID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUpdateUserID.DefaultText = "";
            this.txtUpdateUserID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUpdateUserID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUpdateUserID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUpdateUserID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUpdateUserID.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(118)))));
            this.txtUpdateUserID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUpdateUserID.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtUpdateUserID.ForeColor = System.Drawing.Color.Gold;
            this.txtUpdateUserID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUpdateUserID.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.txtUpdateUserID.Location = new System.Drawing.Point(43, 389);
            this.txtUpdateUserID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUpdateUserID.Name = "txtUpdateUserID";
            this.txtUpdateUserID.PlaceholderText = "";
            this.txtUpdateUserID.SelectedText = "";
            this.txtUpdateUserID.Size = new System.Drawing.Size(220, 45);
            this.txtUpdateUserID.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtUpdateUserID.TabIndex = 7;
            this.txtUpdateUserID.Validating += new System.ComponentModel.CancelEventHandler(this.txtUpdateUserID_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(39, 344);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 21);
            this.label2.TabIndex = 32;
            this.label2.Text = "User ID";
            // 
            // btnUpdateClient
            // 
            this.btnUpdateClient.Animated = true;
            this.btnUpdateClient.BorderColor = System.Drawing.Color.White;
            this.btnUpdateClient.BorderRadius = 5;
            this.btnUpdateClient.BorderThickness = 1;
            this.btnUpdateClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateClient.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateClient.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateClient.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdateClient.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdateClient.FillColor = System.Drawing.Color.Transparent;
            this.btnUpdateClient.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnUpdateClient.ForeColor = System.Drawing.Color.White;
            this.btnUpdateClient.Location = new System.Drawing.Point(331, 511);
            this.btnUpdateClient.Name = "btnUpdateClient";
            this.btnUpdateClient.PressedColor = System.Drawing.Color.White;
            this.btnUpdateClient.Size = new System.Drawing.Size(220, 49);
            this.btnUpdateClient.TabIndex = 29;
            this.btnUpdateClient.Text = "Update Client";
            this.btnUpdateClient.Click += new System.EventHandler(this.btnUpdateClient_Click);
            // 
            // ncUpdateBalance
            // 
            this.ncUpdateBalance.BackColor = System.Drawing.Color.Transparent;
            this.ncUpdateBalance.BorderRadius = 5;
            this.ncUpdateBalance.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ncUpdateBalance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ncUpdateBalance.Location = new System.Drawing.Point(331, 394);
            this.ncUpdateBalance.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ncUpdateBalance.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.ncUpdateBalance.Name = "ncUpdateBalance";
            this.ncUpdateBalance.Size = new System.Drawing.Size(220, 40);
            this.ncUpdateBalance.TabIndex = 8;
            this.ncUpdateBalance.UpDownButtonFillColor = System.Drawing.Color.Gold;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(327, 355);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 21);
            this.label11.TabIndex = 31;
            this.label11.Text = "Balance";
            // 
            // txtUpdatePhone
            // 
            this.txtUpdatePhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUpdatePhone.DefaultText = "";
            this.txtUpdatePhone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUpdatePhone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUpdatePhone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUpdatePhone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUpdatePhone.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(118)))));
            this.txtUpdatePhone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUpdatePhone.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtUpdatePhone.ForeColor = System.Drawing.Color.Gold;
            this.txtUpdatePhone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUpdatePhone.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.txtUpdatePhone.Location = new System.Drawing.Point(611, 243);
            this.txtUpdatePhone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUpdatePhone.Name = "txtUpdatePhone";
            this.txtUpdatePhone.PlaceholderText = "";
            this.txtUpdatePhone.SelectedText = "";
            this.txtUpdatePhone.Size = new System.Drawing.Size(220, 45);
            this.txtUpdatePhone.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtUpdatePhone.TabIndex = 6;
            this.txtUpdatePhone.Validating += new System.ComponentModel.CancelEventHandler(this.txtUpdatePhone_Validating);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(607, 198);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 21);
            this.label12.TabIndex = 30;
            this.label12.Text = "Phone";
            // 
            // txtUpdateLastName
            // 
            this.txtUpdateLastName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUpdateLastName.DefaultText = "";
            this.txtUpdateLastName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUpdateLastName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUpdateLastName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUpdateLastName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUpdateLastName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(118)))));
            this.txtUpdateLastName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUpdateLastName.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtUpdateLastName.ForeColor = System.Drawing.Color.Gold;
            this.txtUpdateLastName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUpdateLastName.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.txtUpdateLastName.Location = new System.Drawing.Point(43, 243);
            this.txtUpdateLastName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUpdateLastName.Name = "txtUpdateLastName";
            this.txtUpdateLastName.PlaceholderText = "";
            this.txtUpdateLastName.SelectedText = "";
            this.txtUpdateLastName.Size = new System.Drawing.Size(220, 45);
            this.txtUpdateLastName.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtUpdateLastName.TabIndex = 4;
            this.txtUpdateLastName.Validating += new System.ComponentModel.CancelEventHandler(this.txtUpdateLastName_Validating);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(39, 198);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 21);
            this.label13.TabIndex = 28;
            this.label13.Text = "Last Name";
            // 
            // txtUpdatePinCode
            // 
            this.txtUpdatePinCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUpdatePinCode.DefaultText = "";
            this.txtUpdatePinCode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUpdatePinCode.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUpdatePinCode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUpdatePinCode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUpdatePinCode.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(118)))));
            this.txtUpdatePinCode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUpdatePinCode.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtUpdatePinCode.ForeColor = System.Drawing.Color.Gold;
            this.txtUpdatePinCode.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUpdatePinCode.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.txtUpdatePinCode.Location = new System.Drawing.Point(331, 108);
            this.txtUpdatePinCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUpdatePinCode.Name = "txtUpdatePinCode";
            this.txtUpdatePinCode.PlaceholderText = "";
            this.txtUpdatePinCode.SelectedText = "";
            this.txtUpdatePinCode.Size = new System.Drawing.Size(220, 45);
            this.txtUpdatePinCode.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtUpdatePinCode.TabIndex = 2;
            this.txtUpdatePinCode.Validating += new System.ComponentModel.CancelEventHandler(this.txtUpdatePinCode_Validating);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(327, 63);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(85, 21);
            this.label14.TabIndex = 25;
            this.label14.Text = "Pin Code";
            // 
            // txtUpdateEmail
            // 
            this.txtUpdateEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUpdateEmail.DefaultText = "";
            this.txtUpdateEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUpdateEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUpdateEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUpdateEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUpdateEmail.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(118)))));
            this.txtUpdateEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUpdateEmail.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtUpdateEmail.ForeColor = System.Drawing.Color.Gold;
            this.txtUpdateEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUpdateEmail.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.txtUpdateEmail.Location = new System.Drawing.Point(331, 243);
            this.txtUpdateEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUpdateEmail.Name = "txtUpdateEmail";
            this.txtUpdateEmail.PlaceholderText = "";
            this.txtUpdateEmail.SelectedText = "";
            this.txtUpdateEmail.Size = new System.Drawing.Size(220, 45);
            this.txtUpdateEmail.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtUpdateEmail.TabIndex = 5;
            this.txtUpdateEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txtUpdateEmail_Validating);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(327, 198);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(56, 21);
            this.label15.TabIndex = 22;
            this.label15.Text = "Email";
            // 
            // txtUpdateFirstName
            // 
            this.txtUpdateFirstName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUpdateFirstName.DefaultText = "";
            this.txtUpdateFirstName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUpdateFirstName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUpdateFirstName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUpdateFirstName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUpdateFirstName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(118)))));
            this.txtUpdateFirstName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUpdateFirstName.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtUpdateFirstName.ForeColor = System.Drawing.Color.Gold;
            this.txtUpdateFirstName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUpdateFirstName.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.txtUpdateFirstName.Location = new System.Drawing.Point(611, 108);
            this.txtUpdateFirstName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUpdateFirstName.Name = "txtUpdateFirstName";
            this.txtUpdateFirstName.PlaceholderText = "";
            this.txtUpdateFirstName.SelectedText = "";
            this.txtUpdateFirstName.Size = new System.Drawing.Size(220, 45);
            this.txtUpdateFirstName.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtUpdateFirstName.TabIndex = 3;
            this.txtUpdateFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.txtUpdateFirstName_Validating);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(607, 63);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(102, 21);
            this.label16.TabIndex = 19;
            this.label16.Text = "First Name";
            // 
            // txtUpdateAccNumber
            // 
            this.txtUpdateAccNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUpdateAccNumber.DefaultText = "";
            this.txtUpdateAccNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUpdateAccNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUpdateAccNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUpdateAccNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUpdateAccNumber.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(118)))));
            this.txtUpdateAccNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUpdateAccNumber.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtUpdateAccNumber.ForeColor = System.Drawing.Color.Gold;
            this.txtUpdateAccNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUpdateAccNumber.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.txtUpdateAccNumber.Location = new System.Drawing.Point(43, 108);
            this.txtUpdateAccNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUpdateAccNumber.Name = "txtUpdateAccNumber";
            this.txtUpdateAccNumber.PlaceholderText = "";
            this.txtUpdateAccNumber.SelectedText = "";
            this.txtUpdateAccNumber.Size = new System.Drawing.Size(220, 45);
            this.txtUpdateAccNumber.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtUpdateAccNumber.TabIndex = 1;
            this.txtUpdateAccNumber.Validating += new System.ComponentModel.CancelEventHandler(this.txtUpdateAccNumber_Validating);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(39, 63);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(148, 21);
            this.label17.TabIndex = 16;
            this.label17.Text = "Account Nunber";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmManageClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 682);
            this.Controls.Add(this.tcShowClients);
            this.Name = "frmManageClients";
            this.Text = "frmManageClients";
            this.Load += new System.EventHandler(this.frmManageClients_Load);
            this.tcShowClients.ResumeLayout(false);
            this.tpShowClients.ResumeLayout(false);
            this.tpShowClients.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllClients)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.tpAddNewClient.ResumeLayout(false);
            this.tpAddNewClient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ncAddBalance)).EndInit();
            this.tpUpdateClient.ResumeLayout(false);
            this.tpUpdateClient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ncUpdateBalance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcShowClients;
        private System.Windows.Forms.TabPage tpShowClients;
        private System.Windows.Forms.TabPage tpAddNewClient;
        private System.Windows.Forms.TabPage tpUpdateClient;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNumberOfClients;
        private System.Windows.Forms.DataGridView dgvAllClients;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtAddAccNumber;
        private Guna.UI2.WinForms.Guna2TextBox txtAddPhone;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2TextBox txtAddLastName;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2TextBox txtAddPinCode;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox txtAddEmail;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox txtAddFirstName;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2NumericUpDown ncAddBalance;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2Button btnAddNewClient;
        private Guna.UI2.WinForms.Guna2TextBox txtAddUserID;
        private System.Windows.Forms.Label label18;
        private Guna.UI2.WinForms.Guna2TextBox txtUpdateUserID;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btnUpdateClient;
        private Guna.UI2.WinForms.Guna2NumericUpDown ncUpdateBalance;
        private System.Windows.Forms.Label label11;
        private Guna.UI2.WinForms.Guna2TextBox txtUpdatePhone;
        private System.Windows.Forms.Label label12;
        private Guna.UI2.WinForms.Guna2TextBox txtUpdateLastName;
        private System.Windows.Forms.Label label13;
        private Guna.UI2.WinForms.Guna2TextBox txtUpdatePinCode;
        private System.Windows.Forms.Label label14;
        private Guna.UI2.WinForms.Guna2TextBox txtUpdateEmail;
        private System.Windows.Forms.Label label15;
        private Guna.UI2.WinForms.Guna2TextBox txtUpdateFirstName;
        private System.Windows.Forms.Label label16;
        private Guna.UI2.WinForms.Guna2TextBox txtUpdateAccNumber;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}