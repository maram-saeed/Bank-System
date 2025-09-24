using System;
using System.Data;
using BankDataAccessLayer;

namespace BankBusinessLayer
{
    public class clsClient
    {
        public enum enMode { AddNew = 0, Update = 1};
        public enMode Mode = enMode.AddNew;

        public int ClientID { get; set; }
        public string AccountNumber { get; set; }
        public short PinCode { get; set; }
        public double Balance { get; set; }
        public int UserID { get; set; }
        public int PersonID { get; set; }

        public clsClient()
        {
            this.ClientID = -1;
            this.AccountNumber = "";
            this.PinCode = 0;
            this.Balance = 0;
            this.UserID = -1;
            this.PersonID = -1;
            Mode = enMode.AddNew;
        }

        private clsClient(int ClientID, string AccountNumber, short PinCode, double Balance, int UserID, int PersonID)
        {
            this.ClientID = ClientID;
            this.AccountNumber = AccountNumber;
            this.PinCode = PinCode;
            this.Balance = Balance;
            this.UserID = UserID;
            this.PersonID = PersonID;
            Mode = enMode.Update;
        }

        private bool _AddNewClient()
        {
            this.ClientID = clsClientDataAccess.AddNewClient(this.AccountNumber, this.PinCode, this.Balance,
                this.UserID, this.PersonID);
            return (this.ClientID != -1);
        }

        private bool _UpdateClient()
        {
            return clsClientDataAccess.UpdateClient(this.ClientID, this.AccountNumber, this.PinCode, this.Balance,
                this.UserID, this.PersonID);
        }

        public bool Save()
        {
            switch(Mode)
            {
                case enMode.AddNew:
                    if(_AddNewClient())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case enMode.Update:
                    return _UpdateClient();
            }
            return false;
        }

        public static clsClient Find(string AccountNumber)
        {
            int ClientID = -1;
            short PinCode = 0;
            double Balance = 0;
            int UserID = -1;
            int PersonID = -1;

            if (clsClientDataAccess.GetClientInfoByAccountNumber(AccountNumber, ref ClientID, ref PinCode, ref Balance,
                ref UserID, ref PersonID))
                return new clsClient(ClientID, AccountNumber, PinCode, Balance, UserID, PersonID);
            else
                return null;
        }

        public static clsClient Find(int ClientID)
        {
            string AccountNumber = "";
            short PinCode = 0;
            double Balance = 0;
            int UserID = -1;
            int PersonID = -1;

            if (clsClientDataAccess.GetClientInfoByID(ClientID, ref AccountNumber, ref PinCode, ref Balance,
                ref UserID, ref PersonID))
                return new clsClient(ClientID, AccountNumber, PinCode, Balance, UserID, PersonID);
            else
                return null;
        }
        public static bool DeleteClient(int ClientID)
        {
            return clsClientDataAccess.DeleteClient(ClientID);
        }

        public static bool IsClientExists(int ClientID)
        {
            return clsClientDataAccess.IsClientExists(ClientID);
        }

        public static DataTable GetAllClients()
        {
            return clsClientDataAccess.GetAllClients();
        }

        public void Deposit(double Amount)
        {
            Balance += Amount;
            Save();
        }

        public bool Withdraw(double Amount)
        {
            if(Amount > Balance)
            {
                return false;
            }
            else
            {
                Balance -= Amount;
                Save();
                return true;
            }
        }

        public static double GetTotalBalances()
        {
            DataTable dtClients = GetAllClients();
            double TotalBalances = 0;

            foreach (DataRow row in dtClients.Rows)
            {
                TotalBalances += Convert.ToDouble(row["Balance"]);
            }
            return TotalBalances;
        }

        public bool Transfer(double Amount, clsClient DestinationClient, string UserName)
        {
            if (Amount > Balance)
            {
                return false;
            }
            Withdraw(Amount);
            DestinationClient.Deposit(Amount);

            clsTransferLog transfer = new clsTransferLog();

            transfer.Date = DateTime.Now;
            transfer.SourceAccountNumber = AccountNumber;
            transfer.DestinationAccountNumber = DestinationClient.AccountNumber;
            transfer.SourceBalance = Balance;
            transfer.DestinationBalance = DestinationClient.Balance;
            transfer.UserName = UserName;

            clsTransferLogDataAccess.AddTransferLog(transfer.Date, transfer.SourceAccountNumber, transfer.DestinationAccountNumber, transfer.SourceBalance, transfer.DestinationBalance, Amount, transfer.UserName);

            return true;
        }
    }
}
