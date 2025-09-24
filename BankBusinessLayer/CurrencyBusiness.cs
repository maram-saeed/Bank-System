using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankDataAccessLayer;

namespace BankBusinessLayer
{
    public class clsCurrency
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int CurrencyID { get; set; }
        public string Country { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public double Rate { get; set; }

        public clsCurrency()
        {
            this.CurrencyID = -1;
            this.Country = "";
            this.Code = "";
            this.Name = "";
            this.Rate = 0;
            Mode = enMode.AddNew;
        }

        private clsCurrency(int CurrencyID, string Country, string Code, string Name, double Rate)
        {
            this.CurrencyID = CurrencyID;
            this.Country = Country;
            this.Code = Code;
            this.Name = Name;
            this.Rate = Rate;
            Mode = enMode.Update;
        }

        private bool _AddNewCurrency()
        {
            this.CurrencyID = clsCurrencyDataAccess.AddNewCurrency(this.Country, this.Code, this.Name,this.Rate);
            return (this.CurrencyID != -1);
        }

        private bool _UpdateCurrency()
        {
            return clsCurrencyDataAccess.UpdateRate(this.Code, this.Rate);
        }

        public static clsCurrency Find(string Code)
        {
            int CurrencyID = -1;
            string Country = "", Name = "";
            double Rate = 0;

            if (clsCurrencyDataAccess.GetCurrencyByCode(Code, ref CurrencyID, ref Country, ref Name, ref Rate))
                return new clsCurrency(CurrencyID, Country, Code, Name, Rate);

            else
                return null;
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewCurrency())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case enMode.Update:
                    return _UpdateCurrency();
            }
            return false;
        }

        public static DataTable GetAllCurrencies()
        {
            return clsCurrencyDataAccess.GetAllCurrencies();
        }

        public double ConvertToUSD(double Amount)
        {
            return (double)(Amount / Rate);
        }

        public double ConvertToOtherCurrency(double Amount, clsCurrency Currency2)
        {
            double AmountInUSD = ConvertToUSD(Amount);

            if (Currency2.Code == "USD")
            {
                return AmountInUSD;
            }
            return (double)(AmountInUSD * Currency2.Rate);
        }
    }
}
