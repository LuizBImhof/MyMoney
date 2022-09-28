using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMoney
{
    public class Money : Calculation 
    {
        public int amount;
        protected string currency;

        public Money(int amount, string currency)
        {
            this.amount = amount;
            this.currency = currency;
        }

        public static Money Dollar(int amount)
        {
            return new Money(amount, Constants.DollarCurrency);
        }

        public static Money Real(int amount)
        {
            return new Money(amount, Constants.RealCurrency);
        }
        public string Currency()
        {
            return this.currency;
        }

        public Money Times(int multiplier)
        {
            return new Money(amount * multiplier, currency);
        }

        public Calculation plus(Money addend)
        {
            return new Sum(this,addend);
        }

        public override bool Equals(object? obj)
        {
            if(obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            Money money = (Money)obj;
            return amount == money.amount && currency.Equals(money.currency);
        }

        public override int GetHashCode()
        {
            return 0;
        }

        Money Calculation.Reduce(string to)
        {
            return this;
        }
    }
}
