namespace MyMoney
{
    public class Sum : Calculation
    {
        public Money augend;
        public Money addend;

        public Sum(Money augend, Money addend)
        {
            this.augend = augend;
            this.addend = addend;
        }

        public Money Reduce(string to)
        {
            int amount = augend.amount + addend.amount;
            return new Money(amount, to);
        }
    }
}