using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using BankDataAccessLayer;

namespace BankBusinessLayer
{
    public class clsLoginRegister
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int LoginRegisterID { get; set; }
        public DateTime Date { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int Permissions { get; set; }

        public clsLoginRegister()
        {
            this.LoginRegisterID = -1;
            this.Date = DateTime.Now;
            this.UserName = "";
            this.Password = "";
            this.Permissions = 0;

            Mode = enMode.AddNew;
        }

        private clsLoginRegister(int LoginRegisterID, DateTime Date, string UserName, string Password, int Permissions)
        {
            this.LoginRegisterID = LoginRegisterID;
            this.Date = Date;
            this.UserName = UserName;
            this.Password = Password;
            this.Permissions = Permissions;

            Mode = enMode.Update;
        }

        private bool _AddNewLoginRegister()
        {
            this.LoginRegisterID = clsLoginRegistersDataAccess.AddNewLoginRegister(this.Date, this.UserName, 
                this.Password,this.Permissions);
            return (this.LoginRegisterID != -1);
        }

        private bool _UpdateLoginRegister()
        {
            return clsLoginRegistersDataAccess.UpdateLoginRegister(this.LoginRegisterID, this.Date, this.UserName,
                this.Password,this.Permissions);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewLoginRegister())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case enMode.Update:
                    return _UpdateLoginRegister();
            }
            return false;
        }

        public static clsLoginRegister Find(string UserName)
        {
            int LoginRegisterID = -1;
            DateTime Date = DateTime.Now;
            string Password = "";
            int Permissions = 0;

            if (clsLoginRegistersDataAccess.GetLoginRegisterInfoByUserName(UserName, ref LoginRegisterID, ref Date,ref Password,
                ref Permissions))
                return new clsLoginRegister(LoginRegisterID, Date,UserName, Password, Permissions);
            else
                return null;
        }

        public static DataTable GetAllLoginRegisters()
        {
            return clsLoginRegistersDataAccess.GetAllLoginRegister();
        }
    }
}
