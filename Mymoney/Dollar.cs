namespace MyMoney
{
    public class Dollar : Money
    {
        
        public Dollar(int amount)
        {
            this.amount = amount;
        }

        public override string Currency()
        {
            return "USD";
        }

        public override Money Times(int multiplier)
        {
            return new Dollar(amount*multiplier);
        }
    }
}