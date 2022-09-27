namespace MyMoney
{
    public class Real : Money
    {
        public Real(int amount, string currency) : base(amount, currency)
        {

        }

        public override Money Times(int multiplier)
        {
            return Money.Real(amount * multiplier);
        }
    }
}