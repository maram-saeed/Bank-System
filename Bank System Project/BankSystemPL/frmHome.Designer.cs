namespace Bank_System
{
    partial class frmHome
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pbLogout = new System.Windows.Forms.PictureBox();
            this.lblLoginUserName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblDate = new System.Windows.Forms.Label();
            this.btnCurrencyExchange = new Guna.UI2.WinForms.Guna2Button();
            this.btnManageUsers = new Guna.UI2.WinForms.Guna2Button();
            this.btnClientsTransactions = new Guna.UI2.WinForms.Guna2Button();
            this.btnManageClients = new Guna.UI2.WinForms.Guna2Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogout)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(98)))));
            this.guna2Panel1.Controls.Add(this.linkLabel1);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.Controls.Add(this.label4);
            this.guna2Panel1.Controls.Add(this.pbLogout);
            this.guna2Panel1.Controls.Add(this.lblLoginUserName);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel1);
            this.guna2Panel1.Controls.Add(this.lblDate);
            this.guna2Panel1.Controls.Add(this.btnCurrencyExchange);
            this.guna2Panel1.Controls.Add(this.btnManageUsers);
            this.guna2Panel1.Controls.Add(this.btnClientsTransactions);
            this.guna2Panel1.Controls.Add(this.btnManageClients);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(266, 725);
            this.guna2Panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Lucida Calligraphy", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(24, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 36);
            this.label3.TabIndex = 15;
            this.label3.Text = "Bank";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Lucida Calligraphy", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gold;
            this.label4.Location = new System.Drawing.Point(113, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 36);
            this.label4.TabIndex = 16;
            this.label4.Text = "System";
            // 
            // pbLogout
            // 
            this.pbLogout.BackColor = System.Drawing.Color.Transparent;
            this.pbLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbLogout.Image = global::Bank_System.Properties.Resources.log_out;
            this.pbLogout.Location = new System.Drawing.Point(212, 634);
            this.pbLogout.Name = "pbLogout";
            this.pbLogout.Size = new System.Drawing.Size(38, 26);
            this.pbLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogout.TabIndex = 12;
            this.pbLogout.TabStop = false;
            this.pbLogout.Click += new System.EventHandler(this.pbLogout_Click);
            // 
            // lblLoginUserName
            // 
            this.lblLoginUserName.BackColor = System.Drawing.Color.Transparent;
            this.lblLoginUserName.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginUserName.ForeColor = System.Drawing.Color.Gold;
            this.lblLoginUserName.Location = new System.Drawing.Point(107, 117);
            this.lblLoginUserName.Name = "lblLoginUserName";
            this.lblLoginUserName.Padding = new System.Windows.Forms.Padding(5);
            this.lblLoginUserName.Size = new System.Drawing.Size(52, 33);
            this.lblLoginUserName.TabIndex = 11;
            this.lblLoginUserName.Text = "User";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(30, 117);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(71, 23);
            this.guna2HtmlLabel1.TabIndex = 10;
            this.guna2HtmlLabel1.Text = "Welcome";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblDate.ForeColor = System.Drawing.Color.Gold;
            this.lblDate.Location = new System.Drawing.Point(21, 616);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(0, 21);
            this.lblDate.TabIndex = 8;
            // 
            // btnCurrencyExchange
            // 
            this.btnCurrencyExchange.Animated = true;
            this.btnCurrencyExchange.BackColor = System.Drawing.Color.Transparent;
            this.btnCurrencyExchange.BorderColor = System.Drawing.Color.White;
            this.btnCurrencyExchange.BorderRadius = 5;
            this.btnCurrencyExchange.BorderThickness = 1;
            this.btnCurrencyExchange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCurrencyExchange.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCurrencyExchange.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCurrencyExchange.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCurrencyExchange.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCurrencyExchange.FillColor = System.Drawing.Color.Transparent;
            this.btnCurrencyExchange.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCurrencyExchange.ForeColor = System.Drawing.Color.White;
            this.btnCurrencyExchange.Image = global::Bank_System.Properties.Resources.dollar__1_;
            this.btnCurrencyExchange.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCurrencyExchange.ImageOffset = new System.Drawing.Point(5, 0);
            this.btnCurrencyExchange.ImageSize = new System.Drawing.Size(25, 25);
            this.btnCurrencyExchange.Location = new System.Drawing.Point(24, 447);
            this.btnCurrencyExchange.Name = "btnCurrencyExchange";
            this.btnCurrencyExchange.PressedColor = System.Drawing.Color.White;
            this.btnCurrencyExchange.Size = new System.Drawing.Size(209, 58);
            this.btnCurrencyExchange.TabIndex = 4;
            this.btnCurrencyExchange.Text = "Currency Exchange";
            this.btnCurrencyExchange.TextOffset = new System.Drawing.Point(15, 0);
            this.btnCurrencyExchange.Click += new System.EventHandler(this.btnCurrencyExchange_Click);
            // 
            // btnManageUsers
            // 
            this.btnManageUsers.Animated = true;
            this.btnManageUsers.BackColor = System.Drawing.Color.Transparent;
            this.btnManageUsers.BorderColor = System.Drawing.Color.White;
            this.btnManageUsers.BorderRadius = 5;
            this.btnManageUsers.BorderThickness = 1;
            this.btnManageUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManageUsers.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnManageUsers.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnManageUsers.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnManageUsers.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnManageUsers.FillColor = System.Drawing.Color.Transparent;
            this.btnManageUsers.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnManageUsers.ForeColor = System.Drawing.Color.White;
            this.btnManageUsers.Image = global::Bank_System.Properties.Resources.users;
            this.btnManageUsers.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnManageUsers.ImageOffset = new System.Drawing.Point(5, 0);
            this.btnManageUsers.ImageSize = new System.Drawing.Size(25, 25);
            this.btnManageUsers.Location = new System.Drawing.Point(24, 366);
            this.btnManageUsers.Name = "btnManageUsers";
            this.btnManageUsers.PressedColor = System.Drawing.Color.White;
            this.btnManageUsers.Size = new System.Drawing.Size(209, 58);
            this.btnManageUsers.TabIndex = 3;
            this.btnManageUsers.Text = "Manage Users";
            this.btnManageUsers.TextOffset = new System.Drawing.Point(10, 0);
            this.btnManageUsers.Click += new System.EventHandler(this.btnManageUsers_Click);
            // 
            // btnClientsTransactions
            // 
            this.btnClientsTransactions.Animated = true;
            this.btnClientsTransactions.BackColor = System.Drawing.Color.Transparent;
            this.btnClientsTransactions.BorderColor = System.Drawing.Color.White;
            this.btnClientsTransactions.BorderRadius = 5;
            this.btnClientsTransactions.BorderThickness = 1;
            this.btnClientsTransactions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClientsTransactions.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClientsTransactions.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClientsTransactions.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClientsTransactions.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClientsTransactions.FillColor = System.Drawing.Color.Transparent;
            this.btnClientsTransactions.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClientsTransactions.ForeColor = System.Drawing.Color.White;
            this.btnClientsTransactions.Image = global::Bank_System.Properties.Resources.lending__2_;
            this.btnClientsTransactions.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnClientsTransactions.ImageOffset = new System.Drawing.Point(5, 0);
            this.btnClientsTransactions.ImageSize = new System.Drawing.Size(35, 35);
            this.btnClientsTransactions.Location = new System.Drawing.Point(24, 285);
            this.btnClientsTransactions.Name = "btnClientsTransactions";
            this.btnClientsTransactions.PressedColor = System.Drawing.Color.White;
            this.btnClientsTransactions.Size = new System.Drawing.Size(209, 58);
            this.btnClientsTransactions.TabIndex = 2;
            this.btnClientsTransactions.Text = "Clients Transactions";
            this.btnClientsTransactions.TextOffset = new System.Drawing.Point(23, 0);
            this.btnClientsTransactions.Click += new System.EventHandler(this.btnClientsTransactions_Click);
            // 
            // btnManageClients
            // 
            this.btnManageClients.Animated = true;
            this.btnManageClients.BackColor = System.Drawing.Color.Transparent;
            this.btnManageClients.BorderColor = System.Drawing.Color.White;
            this.btnManageClients.BorderRadius = 5;
            this.btnManageClients.BorderThickness = 1;
            this.btnManageClients.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManageClients.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnManageClients.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnManageClients.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnManageClients.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnManageClients.FillColor = System.Drawing.Color.Transparent;
            this.btnManageClients.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnManageClients.ForeColor = System.Drawing.Color.White;
            this.btnManageClients.Image = global::Bank_System.Properties.Resources.customer1;
            this.btnManageClients.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnManageClients.ImageOffset = new System.Drawing.Point(5, 0);
            this.btnManageClients.ImageSize = new System.Drawing.Size(25, 25);
            this.btnManageClients.Location = new System.Drawing.Point(24, 204);
            this.btnManageClients.Name = "btnManageClients";
            this.btnManageClients.PressedColor = System.Drawing.Color.White;
            this.btnManageClients.Size = new System.Drawing.Size(209, 58);
            this.btnManageClients.TabIndex = 1;
            this.btnManageClients.Text = "Manage Clients";
            this.btnManageClients.TextOffset = new System.Drawing.Point(10, 0);
            this.btnManageClients.Click += new System.EventHandler(this.btnManageClients_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 699);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Powered By:";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.Gold;
            this.linkLabel1.Location = new System.Drawing.Point(93, 699);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(90, 17);
            this.linkLabel1.TabIndex = 19;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Maram Saeed";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Bank_System.Properties.Resources.bank_logo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1289, 725);
            this.Controls.Add(this.guna2Panel1);
            this.IsMdiContainer = true;
            this.Name = "frmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.frmHome_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogout)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnManageClients;
        private Guna.UI2.WinForms.Guna2Button btnClientsTransactions;
        private Guna.UI2.WinForms.Guna2Button btnManageUsers;
        private Guna.UI2.WinForms.Guna2Button btnCurrencyExchange;
        private System.Windows.Forms.Label lblDate;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblLoginUserName;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.PictureBox pbLogout;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label1;
    }
}

