using System;
using System.Data;
using BankDataAccessLayer;

namespace BankBusinessLayer
{
    public class clsPerson
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int PersonID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public clsPerson()
        {
            this.PersonID = -1;
            this.FirstName = "";
            this.LastName = "";
            this.Email = "";
            this.Phone = "";
            Mode = enMode.AddNew;
        }

        private clsPerson(int PersonID, string FirstName, string LastName, string Email, string Phone)
        {
            this.PersonID = PersonID;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Email = Email;
            this.Phone = Phone;
            Mode = enMode.Update;
        }

        private bool _AddNewPerson()
        {
            this.PersonID = clsPersonDataAccess.AddNewPerson(this.FirstName, this.LastName,
                this.Email, this.Phone);
            return (this.PersonID != -1);
        }

        private bool _UpdatePerson()
        {
            return clsPersonDataAccess.UpdatePerson(this.PersonID, this.FirstName, this.LastName,
                this.Email, this.Phone);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewPerson())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case enMode.Update:
                    return _UpdatePerson();
            }
            return false;
        }

        public static clsPerson Find(int PersonID)
        {
            string FirstName = "";
            string LastName = "";
            string Email = "";
            string Phone = "";

            if (clsPersonDataAccess.GetPersonInfoByID(PersonID, ref FirstName, ref LastName,
                ref Email, ref Phone))
                return new clsPerson(PersonID, FirstName, LastName, Email, Phone);
            else
                return null;
        }

        public static bool DeletePerson(int PersonID)
        {
            return clsPersonDataAccess.DeletePerson(PersonID);
        }

        public static bool IsPersonExists(int PersonID)
        {
            return clsPersonDataAccess.IsPersonExists(PersonID);
        }

        public static DataTable GetAllPersons()
        {
            return clsPersonDataAccess.GetAllPersons();
        }
    }
}
