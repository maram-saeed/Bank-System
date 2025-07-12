using System;
using System.Windows.Forms;
using BankBusinessLayer;

namespace Bank_System
{
    public partial class frmLogin : Form
    {
        bool LoginFaild = false;
        short FaildLoginCount = 0;
        string Username, Password;
        public enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode = enMode.AddNew;

        static public clsUser CurrentUser;
        clsLoginRegister _LoginRegister;
        public frmLogin()
        {
            InitializeComponent();
        }

        private clsLoginRegister _PrepareLogInData()
        {
            clsLoginRegister _LoginRegister = new clsLoginRegister();

            _LoginRegister.Date = DateTime.Now;
            _LoginRegister.UserName = CurrentUser.UserName;
            _LoginRegister.Password = CurrentUser.Password;
            _LoginRegister.Permissions = CurrentUser.Permissions;

            return _LoginRegister;
        }

        private void _AddLoginRegister()
        {
            //DateTime date = DateTime.Now;
            //string userName = "", password = "";
            //int permissions = 0;

            if(_Mode == enMode.AddNew)
            {
                _LoginRegister = _PrepareLogInData();
            }

            if (_LoginRegister.Save())
            {
               // MessageBox.Show("Login register added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error: Login register not saved.");
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (_LogIn())
            {
                _AddLoginRegister();
                frmHome home = new frmHome(CurrentUser.UserName, CurrentUser);
                home.ShowDialog();
                this.Close();
            }

        }

        private void DateTimer_Tick(object sender, EventArgs e)
        {
            lblDate.Text = clsDate.DateToString(clsDate.GetSystemDate());
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            DateTimer.Interval = 1000; // كل ثانية
            DateTimer.Tick += DateTimer_Tick;
            DateTimer.Start();

        }

        private void FailedLoginTimer_Tick(object sender, EventArgs e)
        {
            FailedLoginTimer.Stop();
            this.Close();
        }

        private bool _LogIn()
        {
            int counter = 1;
            Username = txtUserName.Text;
            Password = txtPassword.Text;

            CurrentUser = clsUser.Find(Username, Password);

            if (CurrentUser == null)
            {
                LoginFaild = true;
                FaildLoginCount++;
                pnlErrorLoginMessage.Visible = true;
                lblFailedLoginCount.Text = (3 - FaildLoginCount).ToString();
                counter++;

                if (FaildLoginCount == 3)
                {
                    label6.Visible = false;
                    label7.Visible = false;
                    lblFailedLoginCount.Visible = false;
                    pnlErrorLoginMessage.Visible = true;
                    label5.Text = "You are Locked after 3 faild trails\nContact admin to unlock your account";

                    btnLogin.Enabled = false;

                    FailedLoginTimer.Start();
                }

                return false;
            }


            LoginFaild = false;
            return true;

        }

    }
}
