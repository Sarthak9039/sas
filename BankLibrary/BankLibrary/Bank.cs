using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankLibrary
{
    public class Bank

    {
        public static int instances = 0;
        //name-string and balance-double
        #region Fields and Properties
        private string accHolderName;

        public string AccHolderName
        {
            get { return accHolderName; }
            set { accHolderName = value; }
        }
        private double balance;
        public double Balance
        {
            get { return balance; }
            protected set {
                balance = value;
                if (balance < 1000)
                {
                    throw new Exception("min bal in 1000");
                }
               }
        }

        #endregion
        #region methods

        public void Deposit(double amount)
        {
            Balance += amount;
        }
        public virtual void Withdraw(double amount)
        {
            Balance -= amount;
        }

        public override string ToString()
        {
            return string.Format($"Account holder name = {AccHolderName} Balance = {Balance}");
        }

        #endregion

        #region Constructor

        public Bank(){
            Balance = 1500;
            instances++;
        }

        public Bank(string name,double amount):this()
        {
            this.AccHolderName = name;
            this.Balance = amount;
        }

        public static int GetActiveInstances()
        {
            return instances;
        }
        #endregion

    }
}
