using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMoney
{
    public abstract class Money
    {
        protected int amount;

        public abstract Money Times(int multiplier);


        public static Dollar Dollar(int amount)
        {
            return new Dollar(amount);
        }

        public static Real Real(int amount)
        {
            return new Real(amount);
        }

        public override bool Equals(object? obj)
        {
            Money money = (Money)obj;
            return amount == money.amount && GetType().Equals(money.GetType()); // Temporary check of class
        }

    }
}
