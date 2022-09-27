namespace MyMoney
{
    public class Real : Money
    {

        public Real(int amount)
        {
            this.amount = amount;
        }

        public override string Currency()
        {
            return "BRL";
        }

        public override Money Times(int multiplier)
        {
            return new Real(amount * multiplier);
        }
    }
}