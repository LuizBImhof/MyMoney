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
        protected string? currency;

        protected Money(int amount, string currency)
        {
            this.amount = amount;
            this.currency = currency;
        }

        public abstract Money Times(int multiplier);

        public static Dollar Dollar(int amount)
        {
            return new Dollar(amount, "USD");
        }

        public static Real Real(int amount)
        {
            return new Real(amount, "BRL");
        }
        public string Currency()
        {
            return this.currency;
        }

        public override bool Equals(object? obj)
        {
            Money money = (Money)obj;
            return amount == money.amount && currency.Equals(money.currency);
        }

    }
}
