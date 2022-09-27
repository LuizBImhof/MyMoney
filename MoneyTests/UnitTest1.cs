using MyMoney;

namespace MoneyTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestDollarMultiplication()
        {
            Money five = Money.Dollar(5); // factory method
            Assert.IsTrue(Money.Dollar(10).Equals(five.Times(2)));
            Assert.IsTrue(Money.Dollar(15).Equals(five.Times(3)));
        }

        [TestMethod]
        public void TestRealMultiplication()
        {
            Real five = Money.Real(5);
            Assert.IsTrue(Money.Real(10).Equals(five.Times(2)));
            Assert.IsTrue(Money.Real(15).Equals(five.Times(3)));
        }

        [TestMethod]
        public void TestEquality()
        {
            Assert.IsTrue(new Dollar(5).Equals(new Dollar(5)));
            Assert.IsFalse(new Dollar(5).Equals(new Dollar(6)));
            Assert.IsTrue(new Real(5).Equals(new Real(5)));
            Assert.IsFalse(new Real(5).Equals(new Real(6)));
            Assert.IsFalse(new Dollar(5).Equals(new Real(5)));
        }
    }
}