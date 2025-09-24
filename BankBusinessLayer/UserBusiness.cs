using System;
using System.Collections.Generic;
using BankDataAccessLayer;
using System.Data;


namespace BankBusinessLayer
{
    public class clsUser
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public enum enPermissions
        {
            eAll = -1, pManageClients = 1, pManageUsers = 2, pTranactions = 4,
            pCurrency = 8
        };

        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int Permissions { get; set; }
        public int PersonID { get; set; }
        public bool HasAllAccess { get; set; }
        public clsUser()
        {
            this.UserID = -1;
            this.UserName = "";
            this.Password = "";
            this.Permissions = 0;
            this.PersonID = -1;
            this.HasAllAccess = false;
            Mode = enMode.AddNew;
        }

        private clsUser(int UserID, string UserName, string Password, int Permissions, int PersonID, bool HasAllAccess)
        {
            this.UserID = UserID;
            this.UserName = UserName;
            this.Password = Password;
            this.Permissions = Permissions;
            this.PersonID = PersonID;
            this.HasAllAccess = HasAllAccess;
            Mode = enMode.Update;
        }

        private bool _AddNewUser()
        {
            this.UserID = clsUserDataAccess.AddNewUser(this.UserName, this.Password,
                this.Permissions,this.PersonID, this.HasAllAccess);
            return (this.UserID != -1);
        }

        private bool _UpdateUser()
        {
            return clsUserDataAccess.UpdateUser(this.UserID, this.UserName, this.Password,
                this.Permissions,this.PersonID, this.HasAllAccess);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewUser())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case enMode.Update:
                    return _UpdateUser();
            }
            return false;
        }

        public static clsUser Find(string UserName)
        {
            int UserID = -1;
            string Password = "";
            int Permissions = 0;
            int PersonID = -1;
            bool HasAllAccess = false;
            if (clsUserDataAccess.GetUsersInfoByUserName(UserName, ref UserID, ref Password, 
                ref Permissions, ref PersonID, ref HasAllAccess))
                return new clsUser(UserID, UserName, Password, Permissions, PersonID, HasAllAccess);
            else
                return null;
        }

        public static clsUser Find(int UserID)
        {
            string UserName = "";
            string Password = "";
            int Permissions = 0;
            int PersonID = -1;
            bool HasAllAccess = false;
            if (clsUserDataAccess.GetUsersInfoByID(UserID, ref UserName, ref Password,
                ref Permissions, ref PersonID, ref HasAllAccess))
                return new clsUser(UserID, UserName, Password, Permissions, PersonID, HasAllAccess);
            else
                return null;
        }
        public static clsUser Find(string UserName, string Password)
        {
            int UserID = -1;
            int Permissions = 0;
            int PersonID = -1;
            bool HasAllAccess = false;
            if (clsUserDataAccess.GetUsersInfoByUserNameAndPassword(UserName, Password, ref UserID,
                ref Permissions, ref PersonID, ref HasAllAccess))
                return new clsUser(UserID, UserName, Password, Permissions, PersonID, HasAllAccess);
            else
                return null;
        }

        public static bool DeleteUser(int UserID)
        {
            return clsUserDataAccess.DeleteUser(UserID);
        }

        public static bool IsUserExists(int UserID)
        {
            return clsUserDataAccess.IsUserExists(UserID);
        }

        public static DataTable GetAllCUsers()
        {
            return clsUserDataAccess.GetAllUsers();
        }

        public bool CheckAccessPermission(enPermissions Permission)
        {
            if (this.Permissions == (int)enPermissions.eAll)
                return true;
            if (((int)Permission & this.Permissions) == (int)Permission)
                return true;
            else
                return false;
        }
    }
}
