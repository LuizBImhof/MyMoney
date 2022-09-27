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
            Assert.IsTrue(Money.Dollar(5).Equals(Money.Dollar(5)));
            Assert.IsFalse(Money.Dollar(5).Equals(Money.Dollar(6)));
            Assert.IsTrue(Money.Real(5).Equals(Money.Real(5)));
            Assert.IsFalse(Money.Real(5).Equals(Money.Real(6)));
            Assert.IsFalse(Money.Dollar(5).Equals(Money.Real(5)));
        }

        [TestMethod]
        public void TestCurrency()
        {
            Assert.AreEqual("USD", Money.Dollar(1).Currency());
            Assert.AreEqual("BRL", Money.Real(1).Currency());
        }
    }
}