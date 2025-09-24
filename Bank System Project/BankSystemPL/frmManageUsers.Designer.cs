namespace Bank_System
{
    partial class frmManageUsers
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
            this.tcShowUsers = new System.Windows.Forms.TabControl();
            this.tpShowUsers = new System.Windows.Forms.TabPage();
            this.dgvAllUsers = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNumberOfUsers = new System.Windows.Forms.Label();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tpAddNewUser = new System.Windows.Forms.TabPage();
            this.gbAddPermissions = new System.Windows.Forms.GroupBox();
            this.chkCurrencyExchange = new System.Windows.Forms.CheckBox();
            this.chkClientsTransactions = new System.Windows.Forms.CheckBox();
            this.chkManageUsers = new System.Windows.Forms.CheckBox();
            this.chkManageClients = new System.Windows.Forms.CheckBox();
            this.rbNo = new System.Windows.Forms.RadioButton();
            this.rbYes = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAddPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.btnAddNewUser = new Guna.UI2.WinForms.Guna2Button();
            this.txtAddPhone = new Guna.UI2.WinForms.Guna2TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAddLastName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAddEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAddFirstName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAddUserName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tpUpdateUser = new System.Windows.Forms.TabPage();
            this.gbUpdatePermissions = new System.Windows.Forms.GroupBox();
            this.chkCurrencyExchangeUpdate = new System.Windows.Forms.CheckBox();
            this.chkClientsTransactionsUpdate = new System.Windows.Forms.CheckBox();
            this.chkManageUsersUpdate = new System.Windows.Forms.CheckBox();
            this.chkManageClientsUpdate = new System.Windows.Forms.CheckBox();
            this.rbNoUpdate = new System.Windows.Forms.RadioButton();
            this.rbYesUpdate = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUpdatePassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnUpdateUser = new Guna.UI2.WinForms.Guna2Button();
            this.txtUpdatePhone = new Guna.UI2.WinForms.Guna2TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtUpdateLastName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtUpdateEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtUpdateFirstName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtUpdateUserName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tpLoginRegister = new System.Windows.Forms.TabPage();
            this.dgvAllLoginRegisters = new System.Windows.Forms.DataGridView();
            this.label16 = new System.Windows.Forms.Label();
            this.lblNumberOfLoginUsers = new System.Windows.Forms.Label();
            this.txtSearchInLoginRegister = new Guna.UI2.WinForms.Guna2TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tcShowUsers.SuspendLayout();
            this.tpShowUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllUsers)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.tpAddNewUser.SuspendLayout();
            this.gbAddPermissions.SuspendLayout();
            this.tpUpdateUser.SuspendLayout();
            this.gbUpdatePermissions.SuspendLayout();
            this.tpLoginRegister.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllLoginRegisters)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tcShowUsers
            // 
            this.tcShowUsers.Controls.Add(this.tpShowUsers);
            this.tcShowUsers.Controls.Add(this.tpAddNewUser);
            this.tcShowUsers.Controls.Add(this.tpUpdateUser);
            this.tcShowUsers.Controls.Add(this.tpLoginRegister);
            this.tcShowUsers.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tcShowUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcShowUsers.Font = new System.Drawing.Font("Tahoma", 10F);
            this.tcShowUsers.Location = new System.Drawing.Point(0, 0);
            this.tcShowUsers.Name = "tcShowUsers";
            this.tcShowUsers.Padding = new System.Drawing.Point(8, 7);
            this.tcShowUsers.SelectedIndex = 0;
            this.tcShowUsers.Size = new System.Drawing.Size(990, 682);
            this.tcShowUsers.TabIndex = 1;
            // 
            // tpShowUsers
            // 
            this.tpShowUsers.BackgroundImage = global::Bank_System.Properties.Resources.bg_login;
            this.tpShowUsers.Controls.Add(this.dgvAllUsers);
            this.tpShowUsers.Controls.Add(this.label3);
            this.tpShowUsers.Controls.Add(this.lblNumberOfUsers);
            this.tpShowUsers.Controls.Add(this.txtSearch);
            this.tpShowUsers.Controls.Add(this.label1);
            this.tpShowUsers.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tpShowUsers.Font = new System.Drawing.Font("Tahoma", 10F);
            this.tpShowUsers.Location = new System.Drawing.Point(4, 38);
            this.tpShowUsers.Name = "tpShowUsers";
            this.tpShowUsers.Padding = new System.Windows.Forms.Padding(3);
            this.tpShowUsers.Size = new System.Drawing.Size(982, 640);
            this.tpShowUsers.TabIndex = 0;
            this.tpShowUsers.Text = "Show Users";
            this.tpShowUsers.UseVisualStyleBackColor = true;
            // 
            // dgvAllUsers
            // 
            this.dgvAllUsers.BackgroundColor = System.Drawing.Color.White;
            this.dgvAllUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllUsers.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvAllUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvAllUsers.Location = new System.Drawing.Point(8, 272);
            this.dgvAllUsers.Name = "dgvAllUsers";
            this.dgvAllUsers.RowHeadersWidth = 51;
            this.dgvAllUsers.RowTemplate.Height = 26;
            this.dgvAllUsers.Size = new System.Drawing.Size(968, 360);
            this.dgvAllUsers.TabIndex = 5;
            this.dgvAllUsers.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAllUsers_CellDoubleClick);
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
            this.label3.Size = new System.Drawing.Size(116, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "User(s) Found";
            // 
            // lblNumberOfUsers
            // 
            this.lblNumberOfUsers.AutoSize = true;
            this.lblNumberOfUsers.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblNumberOfUsers.ForeColor = System.Drawing.Color.Gold;
            this.lblNumberOfUsers.Location = new System.Drawing.Point(29, 220);
            this.lblNumberOfUsers.Name = "lblNumberOfUsers";
            this.lblNumberOfUsers.Size = new System.Drawing.Size(19, 21);
            this.lblNumberOfUsers.TabIndex = 2;
            this.lblNumberOfUsers.Text = "0";
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
            this.label1.Size = new System.Drawing.Size(170, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search By User Name";
            // 
            // tpAddNewUser
            // 
            this.tpAddNewUser.BackgroundImage = global::Bank_System.Properties.Resources.bg_login;
            this.tpAddNewUser.Controls.Add(this.gbAddPermissions);
            this.tpAddNewUser.Controls.Add(this.txtAddPassword);
            this.tpAddNewUser.Controls.Add(this.label18);
            this.tpAddNewUser.Controls.Add(this.btnAddNewUser);
            this.tpAddNewUser.Controls.Add(this.txtAddPhone);
            this.tpAddNewUser.Controls.Add(this.label9);
            this.tpAddNewUser.Controls.Add(this.txtAddLastName);
            this.tpAddNewUser.Controls.Add(this.label8);
            this.tpAddNewUser.Controls.Add(this.txtAddEmail);
            this.tpAddNewUser.Controls.Add(this.label6);
            this.tpAddNewUser.Controls.Add(this.txtAddFirstName);
            this.tpAddNewUser.Controls.Add(this.label5);
            this.tpAddNewUser.Controls.Add(this.txtAddUserName);
            this.tpAddNewUser.Controls.Add(this.label4);
            this.tpAddNewUser.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.tpAddNewUser.Location = new System.Drawing.Point(4, 38);
            this.tpAddNewUser.Name = "tpAddNewUser";
            this.tpAddNewUser.Padding = new System.Windows.Forms.Padding(3);
            this.tpAddNewUser.Size = new System.Drawing.Size(982, 640);
            this.tpAddNewUser.TabIndex = 1;
            this.tpAddNewUser.Text = "Add New User";
            this.tpAddNewUser.UseVisualStyleBackColor = true;
            // 
            // gbAddPermissions
            // 
            this.gbAddPermissions.Controls.Add(this.chkCurrencyExchange);
            this.gbAddPermissions.Controls.Add(this.chkClientsTransactions);
            this.gbAddPermissions.Controls.Add(this.chkManageUsers);
            this.gbAddPermissions.Controls.Add(this.chkManageClients);
            this.gbAddPermissions.Controls.Add(this.rbNo);
            this.gbAddPermissions.Controls.Add(this.rbYes);
            this.gbAddPermissions.Controls.Add(this.label7);
            this.gbAddPermissions.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.gbAddPermissions.ForeColor = System.Drawing.Color.Gold;
            this.gbAddPermissions.Location = new System.Drawing.Point(406, 309);
            this.gbAddPermissions.Name = "gbAddPermissions";
            this.gbAddPermissions.Size = new System.Drawing.Size(501, 182);
            this.gbAddPermissions.TabIndex = 7;
            this.gbAddPermissions.TabStop = false;
            this.gbAddPermissions.Text = "Permissions";
            // 
            // chkCurrencyExchange
            // 
            this.chkCurrencyExchange.AutoSize = true;
            this.chkCurrencyExchange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkCurrencyExchange.Location = new System.Drawing.Point(313, 139);
            this.chkCurrencyExchange.Name = "chkCurrencyExchange";
            this.chkCurrencyExchange.Size = new System.Drawing.Size(173, 22);
            this.chkCurrencyExchange.TabIndex = 6;
            this.chkCurrencyExchange.Text = "Currency Exchange";
            this.chkCurrencyExchange.UseVisualStyleBackColor = true;
            // 
            // chkClientsTransactions
            // 
            this.chkClientsTransactions.AutoSize = true;
            this.chkClientsTransactions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkClientsTransactions.Location = new System.Drawing.Point(313, 102);
            this.chkClientsTransactions.Name = "chkClientsTransactions";
            this.chkClientsTransactions.Size = new System.Drawing.Size(182, 22);
            this.chkClientsTransactions.TabIndex = 5;
            this.chkClientsTransactions.Text = "Clients Transactions";
            this.chkClientsTransactions.UseVisualStyleBackColor = true;
            // 
            // chkManageUsers
            // 
            this.chkManageUsers.AutoSize = true;
            this.chkManageUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkManageUsers.Location = new System.Drawing.Point(17, 139);
            this.chkManageUsers.Name = "chkManageUsers";
            this.chkManageUsers.Size = new System.Drawing.Size(135, 22);
            this.chkManageUsers.TabIndex = 4;
            this.chkManageUsers.Text = "Manage Users";
            this.chkManageUsers.UseVisualStyleBackColor = true;
            // 
            // chkManageClients
            // 
            this.chkManageClients.AutoSize = true;
            this.chkManageClients.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkManageClients.Location = new System.Drawing.Point(17, 102);
            this.chkManageClients.Name = "chkManageClients";
            this.chkManageClients.Size = new System.Drawing.Size(144, 22);
            this.chkManageClients.TabIndex = 3;
            this.chkManageClients.Text = "Manage Clients";
            this.chkManageClients.UseVisualStyleBackColor = true;
            // 
            // rbNo
            // 
            this.rbNo.AutoSize = true;
            this.rbNo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbNo.ForeColor = System.Drawing.Color.White;
            this.rbNo.Location = new System.Drawing.Point(264, 59);
            this.rbNo.Name = "rbNo";
            this.rbNo.Size = new System.Drawing.Size(50, 22);
            this.rbNo.TabIndex = 2;
            this.rbNo.TabStop = true;
            this.rbNo.Text = "No";
            this.rbNo.UseVisualStyleBackColor = true;
            this.rbNo.CheckedChanged += new System.EventHandler(this.rbNo_CheckedChanged);
            // 
            // rbYes
            // 
            this.rbYes.AutoSize = true;
            this.rbYes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbYes.ForeColor = System.Drawing.Color.White;
            this.rbYes.Location = new System.Drawing.Point(174, 59);
            this.rbYes.Name = "rbYes";
            this.rbYes.Size = new System.Drawing.Size(57, 22);
            this.rbYes.TabIndex = 1;
            this.rbYes.TabStop = true;
            this.rbYes.Text = "Yes";
            this.rbYes.UseVisualStyleBackColor = true;
            this.rbYes.CheckedChanged += new System.EventHandler(this.rbYes_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Snow;
            this.label7.Location = new System.Drawing.Point(171, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 18);
            this.label7.TabIndex = 0;
            this.label7.Text = "Give full access?";
            // 
            // txtAddPassword
            // 
            this.txtAddPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddPassword.DefaultText = "";
            this.txtAddPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAddPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAddPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddPassword.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(118)))));
            this.txtAddPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAddPassword.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtAddPassword.ForeColor = System.Drawing.Color.Gold;
            this.txtAddPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAddPassword.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.txtAddPassword.Location = new System.Drawing.Point(51, 371);
            this.txtAddPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAddPassword.Name = "txtAddPassword";
            this.txtAddPassword.PlaceholderText = "";
            this.txtAddPassword.SelectedText = "";
            this.txtAddPassword.Size = new System.Drawing.Size(220, 45);
            this.txtAddPassword.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtAddPassword.TabIndex = 6;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(47, 326);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(93, 21);
            this.label18.TabIndex = 15;
            this.label18.Text = "Password";
            // 
            // btnAddNewUser
            // 
            this.btnAddNewUser.Animated = true;
            this.btnAddNewUser.BorderColor = System.Drawing.Color.White;
            this.btnAddNewUser.BorderRadius = 5;
            this.btnAddNewUser.BorderThickness = 1;
            this.btnAddNewUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddNewUser.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNewUser.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNewUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddNewUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddNewUser.FillColor = System.Drawing.Color.Transparent;
            this.btnAddNewUser.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddNewUser.ForeColor = System.Drawing.Color.White;
            this.btnAddNewUser.Location = new System.Drawing.Point(322, 551);
            this.btnAddNewUser.Name = "btnAddNewUser";
            this.btnAddNewUser.PressedColor = System.Drawing.Color.White;
            this.btnAddNewUser.Size = new System.Drawing.Size(220, 49);
            this.btnAddNewUser.TabIndex = 10;
            this.btnAddNewUser.Text = "Add New User";
            this.btnAddNewUser.Click += new System.EventHandler(this.btnAddNewUser_Click);
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
            this.txtAddPhone.Location = new System.Drawing.Point(331, 217);
            this.txtAddPhone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAddPhone.Name = "txtAddPhone";
            this.txtAddPhone.PlaceholderText = "";
            this.txtAddPhone.SelectedText = "";
            this.txtAddPhone.Size = new System.Drawing.Size(220, 45);
            this.txtAddPhone.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtAddPhone.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(327, 172);
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
            this.txtAddLastName.Location = new System.Drawing.Point(619, 90);
            this.txtAddLastName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAddLastName.Name = "txtAddLastName";
            this.txtAddLastName.PlaceholderText = "";
            this.txtAddLastName.SelectedText = "";
            this.txtAddLastName.Size = new System.Drawing.Size(220, 45);
            this.txtAddLastName.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtAddLastName.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(615, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 21);
            this.label8.TabIndex = 9;
            this.label8.Text = "Last Name";
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
            this.txtAddEmail.Location = new System.Drawing.Point(51, 217);
            this.txtAddEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAddEmail.Name = "txtAddEmail";
            this.txtAddEmail.PlaceholderText = "";
            this.txtAddEmail.SelectedText = "";
            this.txtAddEmail.Size = new System.Drawing.Size(220, 45);
            this.txtAddEmail.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtAddEmail.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(47, 172);
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
            this.txtAddFirstName.Location = new System.Drawing.Point(339, 90);
            this.txtAddFirstName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAddFirstName.Name = "txtAddFirstName";
            this.txtAddFirstName.PlaceholderText = "";
            this.txtAddFirstName.SelectedText = "";
            this.txtAddFirstName.Size = new System.Drawing.Size(220, 45);
            this.txtAddFirstName.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtAddFirstName.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(335, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 21);
            this.label5.TabIndex = 3;
            this.label5.Text = "First Name";
            // 
            // txtAddUserName
            // 
            this.txtAddUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddUserName.DefaultText = "";
            this.txtAddUserName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAddUserName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAddUserName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddUserName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddUserName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(118)))));
            this.txtAddUserName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAddUserName.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtAddUserName.ForeColor = System.Drawing.Color.Gold;
            this.txtAddUserName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAddUserName.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.txtAddUserName.Location = new System.Drawing.Point(51, 90);
            this.txtAddUserName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAddUserName.Name = "txtAddUserName";
            this.txtAddUserName.PlaceholderText = "";
            this.txtAddUserName.SelectedText = "";
            this.txtAddUserName.Size = new System.Drawing.Size(220, 45);
            this.txtAddUserName.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtAddUserName.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(47, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "User Name";
            // 
            // tpUpdateUser
            // 
            this.tpUpdateUser.BackgroundImage = global::Bank_System.Properties.Resources.bg_login;
            this.tpUpdateUser.Controls.Add(this.gbUpdatePermissions);
            this.tpUpdateUser.Controls.Add(this.txtUpdatePassword);
            this.tpUpdateUser.Controls.Add(this.label10);
            this.tpUpdateUser.Controls.Add(this.btnUpdateUser);
            this.tpUpdateUser.Controls.Add(this.txtUpdatePhone);
            this.tpUpdateUser.Controls.Add(this.label11);
            this.tpUpdateUser.Controls.Add(this.txtUpdateLastName);
            this.tpUpdateUser.Controls.Add(this.label12);
            this.tpUpdateUser.Controls.Add(this.txtUpdateEmail);
            this.tpUpdateUser.Controls.Add(this.label13);
            this.tpUpdateUser.Controls.Add(this.txtUpdateFirstName);
            this.tpUpdateUser.Controls.Add(this.label14);
            this.tpUpdateUser.Controls.Add(this.txtUpdateUserName);
            this.tpUpdateUser.Controls.Add(this.label15);
            this.tpUpdateUser.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.tpUpdateUser.Location = new System.Drawing.Point(4, 38);
            this.tpUpdateUser.Name = "tpUpdateUser";
            this.tpUpdateUser.Padding = new System.Windows.Forms.Padding(3);
            this.tpUpdateUser.Size = new System.Drawing.Size(982, 640);
            this.tpUpdateUser.TabIndex = 2;
            this.tpUpdateUser.Text = "Update User";
            this.tpUpdateUser.UseVisualStyleBackColor = true;
            // 
            // gbUpdatePermissions
            // 
            this.gbUpdatePermissions.Controls.Add(this.chkCurrencyExchangeUpdate);
            this.gbUpdatePermissions.Controls.Add(this.chkClientsTransactionsUpdate);
            this.gbUpdatePermissions.Controls.Add(this.chkManageUsersUpdate);
            this.gbUpdatePermissions.Controls.Add(this.chkManageClientsUpdate);
            this.gbUpdatePermissions.Controls.Add(this.rbNoUpdate);
            this.gbUpdatePermissions.Controls.Add(this.rbYesUpdate);
            this.gbUpdatePermissions.Controls.Add(this.label2);
            this.gbUpdatePermissions.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.gbUpdatePermissions.ForeColor = System.Drawing.Color.Gold;
            this.gbUpdatePermissions.Location = new System.Drawing.Point(420, 307);
            this.gbUpdatePermissions.Name = "gbUpdatePermissions";
            this.gbUpdatePermissions.Size = new System.Drawing.Size(501, 182);
            this.gbUpdatePermissions.TabIndex = 25;
            this.gbUpdatePermissions.TabStop = false;
            this.gbUpdatePermissions.Text = "Permissions";
            // 
            // chkCurrencyExchangeUpdate
            // 
            this.chkCurrencyExchangeUpdate.AutoSize = true;
            this.chkCurrencyExchangeUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkCurrencyExchangeUpdate.Location = new System.Drawing.Point(313, 139);
            this.chkCurrencyExchangeUpdate.Name = "chkCurrencyExchangeUpdate";
            this.chkCurrencyExchangeUpdate.Size = new System.Drawing.Size(173, 22);
            this.chkCurrencyExchangeUpdate.TabIndex = 6;
            this.chkCurrencyExchangeUpdate.Text = "Currency Exchange";
            this.chkCurrencyExchangeUpdate.UseVisualStyleBackColor = true;
            // 
            // chkClientsTransactionsUpdate
            // 
            this.chkClientsTransactionsUpdate.AutoSize = true;
            this.chkClientsTransactionsUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkClientsTransactionsUpdate.Location = new System.Drawing.Point(313, 102);
            this.chkClientsTransactionsUpdate.Name = "chkClientsTransactionsUpdate";
            this.chkClientsTransactionsUpdate.Size = new System.Drawing.Size(182, 22);
            this.chkClientsTransactionsUpdate.TabIndex = 5;
            this.chkClientsTransactionsUpdate.Text = "Clients Transactions";
            this.chkClientsTransactionsUpdate.UseVisualStyleBackColor = true;
            // 
            // chkManageUsersUpdate
            // 
            this.chkManageUsersUpdate.AutoSize = true;
            this.chkManageUsersUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkManageUsersUpdate.Location = new System.Drawing.Point(17, 139);
            this.chkManageUsersUpdate.Name = "chkManageUsersUpdate";
            this.chkManageUsersUpdate.Size = new System.Drawing.Size(135, 22);
            this.chkManageUsersUpdate.TabIndex = 4;
            this.chkManageUsersUpdate.Text = "Manage Users";
            this.chkManageUsersUpdate.UseVisualStyleBackColor = true;
            // 
            // chkManageClientsUpdate
            // 
            this.chkManageClientsUpdate.AutoSize = true;
            this.chkManageClientsUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkManageClientsUpdate.Location = new System.Drawing.Point(17, 102);
            this.chkManageClientsUpdate.Name = "chkManageClientsUpdate";
            this.chkManageClientsUpdate.Size = new System.Drawing.Size(144, 22);
            this.chkManageClientsUpdate.TabIndex = 3;
            this.chkManageClientsUpdate.Text = "Manage Clients";
            this.chkManageClientsUpdate.UseVisualStyleBackColor = true;
            // 
            // rbNoUpdate
            // 
            this.rbNoUpdate.AutoSize = true;
            this.rbNoUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbNoUpdate.ForeColor = System.Drawing.Color.White;
            this.rbNoUpdate.Location = new System.Drawing.Point(264, 59);
            this.rbNoUpdate.Name = "rbNoUpdate";
            this.rbNoUpdate.Size = new System.Drawing.Size(50, 22);
            this.rbNoUpdate.TabIndex = 2;
            this.rbNoUpdate.TabStop = true;
            this.rbNoUpdate.Text = "No";
            this.rbNoUpdate.UseVisualStyleBackColor = true;
            // 
            // rbYesUpdate
            // 
            this.rbYesUpdate.AutoSize = true;
            this.rbYesUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbYesUpdate.ForeColor = System.Drawing.Color.White;
            this.rbYesUpdate.Location = new System.Drawing.Point(174, 59);
            this.rbYesUpdate.Name = "rbYesUpdate";
            this.rbYesUpdate.Size = new System.Drawing.Size(57, 22);
            this.rbYesUpdate.TabIndex = 1;
            this.rbYesUpdate.TabStop = true;
            this.rbYesUpdate.Text = "Yes";
            this.rbYesUpdate.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(171, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Give full access?";
            // 
            // txtUpdatePassword
            // 
            this.txtUpdatePassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUpdatePassword.DefaultText = "";
            this.txtUpdatePassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUpdatePassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUpdatePassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUpdatePassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUpdatePassword.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(118)))));
            this.txtUpdatePassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUpdatePassword.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtUpdatePassword.ForeColor = System.Drawing.Color.Gold;
            this.txtUpdatePassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUpdatePassword.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.txtUpdatePassword.Location = new System.Drawing.Point(65, 369);
            this.txtUpdatePassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUpdatePassword.Name = "txtUpdatePassword";
            this.txtUpdatePassword.PlaceholderText = "";
            this.txtUpdatePassword.SelectedText = "";
            this.txtUpdatePassword.Size = new System.Drawing.Size(220, 45);
            this.txtUpdatePassword.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtUpdatePassword.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(61, 324);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 21);
            this.label10.TabIndex = 29;
            this.label10.Text = "Password";
            // 
            // btnUpdateUser
            // 
            this.btnUpdateUser.Animated = true;
            this.btnUpdateUser.BorderColor = System.Drawing.Color.White;
            this.btnUpdateUser.BorderRadius = 5;
            this.btnUpdateUser.BorderThickness = 1;
            this.btnUpdateUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateUser.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateUser.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdateUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdateUser.FillColor = System.Drawing.Color.Transparent;
            this.btnUpdateUser.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnUpdateUser.ForeColor = System.Drawing.Color.White;
            this.btnUpdateUser.Location = new System.Drawing.Point(336, 549);
            this.btnUpdateUser.Name = "btnUpdateUser";
            this.btnUpdateUser.PressedColor = System.Drawing.Color.White;
            this.btnUpdateUser.Size = new System.Drawing.Size(220, 49);
            this.btnUpdateUser.TabIndex = 27;
            this.btnUpdateUser.Text = "Update User";
            this.btnUpdateUser.Click += new System.EventHandler(this.btnUpdateUser_Click);
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
            this.txtUpdatePhone.Location = new System.Drawing.Point(345, 215);
            this.txtUpdatePhone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUpdatePhone.Name = "txtUpdatePhone";
            this.txtUpdatePhone.PlaceholderText = "";
            this.txtUpdatePhone.SelectedText = "";
            this.txtUpdatePhone.Size = new System.Drawing.Size(220, 45);
            this.txtUpdatePhone.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtUpdatePhone.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(341, 170);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 21);
            this.label11.TabIndex = 28;
            this.label11.Text = "Phone";
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
            this.txtUpdateLastName.Location = new System.Drawing.Point(633, 88);
            this.txtUpdateLastName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUpdateLastName.Name = "txtUpdateLastName";
            this.txtUpdateLastName.PlaceholderText = "";
            this.txtUpdateLastName.SelectedText = "";
            this.txtUpdateLastName.Size = new System.Drawing.Size(220, 45);
            this.txtUpdateLastName.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtUpdateLastName.TabIndex = 19;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(629, 43);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 21);
            this.label12.TabIndex = 26;
            this.label12.Text = "Last Name";
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
            this.txtUpdateEmail.Location = new System.Drawing.Point(65, 215);
            this.txtUpdateEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUpdateEmail.Name = "txtUpdateEmail";
            this.txtUpdateEmail.PlaceholderText = "";
            this.txtUpdateEmail.SelectedText = "";
            this.txtUpdateEmail.Size = new System.Drawing.Size(220, 45);
            this.txtUpdateEmail.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtUpdateEmail.TabIndex = 21;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(61, 170);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 21);
            this.label13.TabIndex = 23;
            this.label13.Text = "Email";
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
            this.txtUpdateFirstName.Location = new System.Drawing.Point(353, 88);
            this.txtUpdateFirstName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUpdateFirstName.Name = "txtUpdateFirstName";
            this.txtUpdateFirstName.PlaceholderText = "";
            this.txtUpdateFirstName.SelectedText = "";
            this.txtUpdateFirstName.Size = new System.Drawing.Size(220, 45);
            this.txtUpdateFirstName.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtUpdateFirstName.TabIndex = 18;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(349, 43);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(102, 21);
            this.label14.TabIndex = 20;
            this.label14.Text = "First Name";
            // 
            // txtUpdateUserName
            // 
            this.txtUpdateUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUpdateUserName.DefaultText = "";
            this.txtUpdateUserName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUpdateUserName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUpdateUserName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUpdateUserName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUpdateUserName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(118)))));
            this.txtUpdateUserName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUpdateUserName.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtUpdateUserName.ForeColor = System.Drawing.Color.Gold;
            this.txtUpdateUserName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUpdateUserName.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.txtUpdateUserName.Location = new System.Drawing.Point(65, 88);
            this.txtUpdateUserName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUpdateUserName.Name = "txtUpdateUserName";
            this.txtUpdateUserName.PlaceholderText = "";
            this.txtUpdateUserName.SelectedText = "";
            this.txtUpdateUserName.Size = new System.Drawing.Size(220, 45);
            this.txtUpdateUserName.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtUpdateUserName.TabIndex = 17;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(61, 43);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(103, 21);
            this.label15.TabIndex = 16;
            this.label15.Text = "User Name";
            // 
            // tpLoginRegister
            // 
            this.tpLoginRegister.BackgroundImage = global::Bank_System.Properties.Resources.bg_login;
            this.tpLoginRegister.Controls.Add(this.dgvAllLoginRegisters);
            this.tpLoginRegister.Controls.Add(this.label16);
            this.tpLoginRegister.Controls.Add(this.lblNumberOfLoginUsers);
            this.tpLoginRegister.Controls.Add(this.txtSearchInLoginRegister);
            this.tpLoginRegister.Controls.Add(this.label19);
            this.tpLoginRegister.Location = new System.Drawing.Point(4, 38);
            this.tpLoginRegister.Name = "tpLoginRegister";
            this.tpLoginRegister.Size = new System.Drawing.Size(982, 640);
            this.tpLoginRegister.TabIndex = 3;
            this.tpLoginRegister.Text = "Login Register";
            this.tpLoginRegister.UseVisualStyleBackColor = true;
            // 
            // dgvAllLoginRegisters
            // 
            this.dgvAllLoginRegisters.BackgroundColor = System.Drawing.Color.White;
            this.dgvAllLoginRegisters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllLoginRegisters.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvAllLoginRegisters.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvAllLoginRegisters.Location = new System.Drawing.Point(8, 272);
            this.dgvAllLoginRegisters.Name = "dgvAllLoginRegisters";
            this.dgvAllLoginRegisters.RowHeadersWidth = 51;
            this.dgvAllLoginRegisters.RowTemplate.Height = 26;
            this.dgvAllLoginRegisters.Size = new System.Drawing.Size(968, 360);
            this.dgvAllLoginRegisters.TabIndex = 10;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(53, 216);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(116, 21);
            this.label16.TabIndex = 9;
            this.label16.Text = "User(s) Found";
            // 
            // lblNumberOfLoginUsers
            // 
            this.lblNumberOfLoginUsers.AutoSize = true;
            this.lblNumberOfLoginUsers.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblNumberOfLoginUsers.ForeColor = System.Drawing.Color.Gold;
            this.lblNumberOfLoginUsers.Location = new System.Drawing.Point(28, 216);
            this.lblNumberOfLoginUsers.Name = "lblNumberOfLoginUsers";
            this.lblNumberOfLoginUsers.Size = new System.Drawing.Size(19, 21);
            this.lblNumberOfLoginUsers.TabIndex = 8;
            this.lblNumberOfLoginUsers.Text = "0";
            // 
            // txtSearchInLoginRegister
            // 
            this.txtSearchInLoginRegister.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchInLoginRegister.DefaultText = "";
            this.txtSearchInLoginRegister.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearchInLoginRegister.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearchInLoginRegister.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchInLoginRegister.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchInLoginRegister.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(118)))));
            this.txtSearchInLoginRegister.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchInLoginRegister.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtSearchInLoginRegister.ForeColor = System.Drawing.Color.Gold;
            this.txtSearchInLoginRegister.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchInLoginRegister.IconLeft = global::Bank_System.Properties.Resources.search;
            this.txtSearchInLoginRegister.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.txtSearchInLoginRegister.Location = new System.Drawing.Point(32, 141);
            this.txtSearchInLoginRegister.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearchInLoginRegister.Name = "txtSearchInLoginRegister";
            this.txtSearchInLoginRegister.PlaceholderText = "";
            this.txtSearchInLoginRegister.SelectedText = "";
            this.txtSearchInLoginRegister.Size = new System.Drawing.Size(261, 46);
            this.txtSearchInLoginRegister.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtSearchInLoginRegister.TabIndex = 7;
            this.txtSearchInLoginRegister.TextChanged += new System.EventHandler(this.txtSearchInLoginRegister_TextChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(38, 90);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(128, 21);
            this.label19.TabIndex = 6;
            this.label19.Text = "Search For User";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmManageUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 682);
            this.Controls.Add(this.tcShowUsers);
            this.Name = "frmManageUsers";
            this.Text = "frmManageUsers";
            this.Load += new System.EventHandler(this.frmManageUsers_Load);
            this.tcShowUsers.ResumeLayout(false);
            this.tpShowUsers.ResumeLayout(false);
            this.tpShowUsers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllUsers)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.tpAddNewUser.ResumeLayout(false);
            this.tpAddNewUser.PerformLayout();
            this.gbAddPermissions.ResumeLayout(false);
            this.gbAddPermissions.PerformLayout();
            this.tpUpdateUser.ResumeLayout(false);
            this.tpUpdateUser.PerformLayout();
            this.gbUpdatePermissions.ResumeLayout(false);
            this.gbUpdatePermissions.PerformLayout();
            this.tpLoginRegister.ResumeLayout(false);
            this.tpLoginRegister.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllLoginRegisters)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcShowUsers;
        private System.Windows.Forms.TabPage tpShowUsers;
        private System.Windows.Forms.DataGridView dgvAllUsers;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNumberOfUsers;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tpAddNewUser;
        private Guna.UI2.WinForms.Guna2TextBox txtAddPassword;
        private System.Windows.Forms.Label label18;
        private Guna.UI2.WinForms.Guna2Button btnAddNewUser;
        private Guna.UI2.WinForms.Guna2TextBox txtAddPhone;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2TextBox txtAddLastName;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2TextBox txtAddEmail;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox txtAddFirstName;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txtAddUserName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tpUpdateUser;
        private System.Windows.Forms.TabPage tpLoginRegister;
        private System.Windows.Forms.GroupBox gbAddPermissions;
        private System.Windows.Forms.RadioButton rbNo;
        private System.Windows.Forms.RadioButton rbYes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chkManageClients;
        private System.Windows.Forms.CheckBox chkClientsTransactions;
        private System.Windows.Forms.CheckBox chkManageUsers;
        private System.Windows.Forms.CheckBox chkCurrencyExchange;
        private System.Windows.Forms.GroupBox gbUpdatePermissions;
        private System.Windows.Forms.CheckBox chkCurrencyExchangeUpdate;
        private System.Windows.Forms.CheckBox chkClientsTransactionsUpdate;
        private System.Windows.Forms.CheckBox chkManageUsersUpdate;
        private System.Windows.Forms.CheckBox chkManageClientsUpdate;
        private System.Windows.Forms.RadioButton rbNoUpdate;
        private System.Windows.Forms.RadioButton rbYesUpdate;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtUpdatePassword;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2Button btnUpdateUser;
        private Guna.UI2.WinForms.Guna2TextBox txtUpdatePhone;
        private System.Windows.Forms.Label label11;
        private Guna.UI2.WinForms.Guna2TextBox txtUpdateLastName;
        private System.Windows.Forms.Label label12;
        private Guna.UI2.WinForms.Guna2TextBox txtUpdateEmail;
        private System.Windows.Forms.Label label13;
        private Guna.UI2.WinForms.Guna2TextBox txtUpdateFirstName;
        private System.Windows.Forms.Label label14;
        private Guna.UI2.WinForms.Guna2TextBox txtUpdateUserName;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridView dgvAllLoginRegisters;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblNumberOfLoginUsers;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchInLoginRegister;
        private System.Windows.Forms.Label label19;
    }
}