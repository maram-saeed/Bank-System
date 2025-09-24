using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankDataAccessLayer;

namespace BankBusinessLayer
{
    public class clsTransferLog
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int TransferID { get; set; }
        public DateTime Date { get; set; }
        public string SourceAccountNumber { get; set; }
        public string DestinationAccountNumber { get; set; }
        public double SourceBalance { get; set; }
        public double DestinationBalance { get; set; }
        public double Amount { get; set; }
        public string UserName { get; set; }

        public clsTransferLog ()
        {
            this.TransferID = -1;
            this.Date = DateTime.Now;
            this.SourceAccountNumber = "";
            this.DestinationAccountNumber = "";
            this.SourceBalance = 0;
            this.DestinationBalance = 0;
            this.Amount = 0;
            this.UserName = "";
            Mode = enMode.AddNew;
        }

        private clsTransferLog (int TransferID, DateTime Date, string SourceAccountNumber, string DestinationAccountNumber, double SourceBalance,
            double DestinationBalance, double Amount, string UserName)
        {
            this.TransferID = TransferID;
            this.Date = Date;
            this.SourceAccountNumber = SourceAccountNumber;
            this.DestinationAccountNumber = DestinationAccountNumber;
            this.SourceBalance = SourceBalance;
            this.DestinationBalance = DestinationBalance;
            this.Amount = Amount;
            this.UserName = UserName;
            Mode = enMode.Update;
        }


        public static DataTable GetAllTransferLog()
        {
            return clsTransferLogDataAccess.GetAllTransferLog();
        }

        public bool RegisterTransferLog()
        {
            this.TransferID = clsTransferLogDataAccess.AddTransferLog(this.Date, this.SourceAccountNumber, this.DestinationAccountNumber, this.SourceBalance,
                this.DestinationBalance, this.Amount, this.UserName);
            return (this.TransferID == -1);
        }

    }
}
