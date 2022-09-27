namespace MyMoney
{
    public class Real : Money
    {
        public Real(int amount, string currency)
        {
            this.amount = amount;
            this.currency = currency;
        }

        public override Money Times(int multiplier)
        {
            return Money.Real(amount * multiplier);
        }
    }
}