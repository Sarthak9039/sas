using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankLibrary
{
   public class Savings : Bank, IInterest
    {

        public Savings()
        {

        }
        public Savings(string accname,double amt):base(accname,amt)
        {

        }
       public double Interest()
        {
            return Balance * .04;
        }
        //can oerrride only virtual and abstract method of parent class
        public override void Withdraw(double amount)
        {
            if ((Balance - amount) >= 1000)
            {
                Balance -= amount;
            }
          
        }

      
    }


}
