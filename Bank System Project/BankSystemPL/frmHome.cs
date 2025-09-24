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
    public partial class frmHome : Form
    {
        string CurrentUserName;
        clsUser _CurrentUser;
        public frmHome(string UserName, clsUser User)
        {
            CurrentUserName = UserName;
            _CurrentUser = User;
            InitializeComponent();
        }
        frmManageClients _frmClients = null;
        frmClientsTransactions _frmTransactions = null;
        frmManageUsers _frmUsers = null;
        frmCurrencyExchange _frmCurrency = null;

        private void btnManageClients_Click(object sender, EventArgs e)
        {
            if (_frmClients == null || _frmClients.IsDisposed)
            {
                _frmClients = new frmManageClients();
                _frmClients.MdiParent = this;
                _frmClients.Dock = DockStyle.Fill;

                // عندما يتم إغلاق الفورم، امسح المرجع من الذاكرة
                _frmClients.FormClosed += (s, args) => _frmClients = null;

                _frmClients.Show();
            }
            else
            {
                _frmClients.BringToFront();
            }

            //lblHomeMessage.Visible = false;
        }

        private void btnClientsTransactions_Click(object sender, EventArgs e)
        {
            if (_frmTransactions == null || _frmTransactions.IsDisposed)
            {
                _frmTransactions = new frmClientsTransactions(_frmClients, CurrentUserName);
                _frmTransactions.MdiParent = this;
                _frmTransactions.Dock = DockStyle.Fill;

                // عندما يتم إغلاق الفورم، امسح المرجع من الذاكرة
                _frmTransactions.FormClosed += (s, args) => _frmTransactions = null;

                _frmTransactions.Show();
            }
            else
            {
                _frmTransactions.BringToFront();
            }

            //lblHomeMessage.Visible = false;
        }

        private void btnManageUsers_Click(object sender, EventArgs e)
        {
            if (_frmUsers == null || _frmUsers.IsDisposed)
            {
                _frmUsers = new frmManageUsers();
                _frmUsers.MdiParent = this;
                _frmUsers.Dock = DockStyle.Fill;

                // عندما يتم إغلاق الفورم، امسح المرجع من الذاكرة
                _frmUsers.FormClosed += (s, args) => _frmUsers = null;

                _frmUsers.Show();
            }
            else
            {
                _frmUsers.BringToFront();
            }

            //lblHomeMessage.Visible = false;
        }

        private void btnCurrencyExchange_Click(object sender, EventArgs e)
        {
            if (_frmCurrency == null || _frmCurrency.IsDisposed)
            {
                _frmCurrency = new frmCurrencyExchange();
                _frmCurrency.MdiParent = this;
                _frmCurrency.Dock = DockStyle.Fill;

                // عندما يتم إغلاق الفورم، امسح المرجع من الذاكرة
                _frmCurrency.FormClosed += (s, args) => _frmCurrency = null;

                _frmCurrency.Show();
            }
            else
            {
                _frmCurrency.BringToFront();
            }

            //lblHomeMessage.Visible = false;
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000; // كل ثانية
            timer1.Tick += timer1_Tick;
            timer1.Start();

            if (!clsCheckPermissions.CheckAccessRights(clsUser.enPermissions.pManageClients, _CurrentUser))
            {
                btnManageClients.Enabled = false;
            }

            if (!clsCheckPermissions.CheckAccessRights(clsUser.enPermissions.pManageUsers, _CurrentUser))
            {
                btnManageUsers.Enabled = false;
            }

            if (!clsCheckPermissions.CheckAccessRights(clsUser.enPermissions.pTranactions, _CurrentUser))
            {
                btnClientsTransactions.Enabled = false;
            }

            if (!clsCheckPermissions.CheckAccessRights(clsUser.enPermissions.pCurrency, _CurrentUser))
            {
                btnCurrencyExchange.Enabled = false;
            }


            lblLoginUserName.Text = CurrentUserName;

            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is MdiClient)
                {
                    ctrl.BackColor = Color.WhiteSmoke;
                }
            }

            //if (_frmClients == null || _frmClients.IsDisposed)
            //{
            //    _frmClients = new frmManageClients();
            //    _frmClients.MdiParent = this;
            //    _frmClients.Dock = DockStyle.Fill;

            //    // عندما يتم إغلاق الفورم، امسح المرجع من الذاكرة
            //    _frmClients.FormClosed += (s, args) => _frmClients = null;

            //    _frmClients.Show();
            //}
            //else
            //{
            //    _frmClients.BringToFront();
            //}
        }

        private void pbLogout_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmLogin loginForm = new frmLogin();
            loginForm.ShowDialog();

            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDate.Text = clsDate.DateToString(clsDate.GetSystemDate());
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("https://www.linkedin.com/in/maram-saeed/");
        }
    }
}
