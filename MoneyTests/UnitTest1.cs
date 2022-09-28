using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyMoney;

namespace MoneyTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestDollarMultiplication()
        {
            Money five = Money.Dollar(5);
            Assert.IsTrue(Money.Dollar(10).Equals(five.Times(2)));
            Assert.IsTrue(Money.Dollar(15).Equals(five.Times(3)));
        }

        [TestMethod]
        public void TestRealMultiplication()
        {
            Money five = Money.Real(5);
            Assert.IsTrue(Money.Real(10).Equals(five.Times(2)));
            Assert.IsTrue(Money.Real(15).Equals(five.Times(3)));
        }

        [TestMethod]
        public void TestEquality()
        {
            Assert.IsTrue(Money.Dollar(5).Equals(Money.Dollar(5)));
            Assert.IsFalse(Money.Real(5).Equals(Money.Real(6)));
            Assert.IsFalse(Money.Dollar(5).Equals(Money.Real(5)));
        }

        [TestMethod]
        public void TestCurrency()
        {
            Assert.AreEqual("USD", Money.Dollar(1).Currency());
            Assert.AreEqual("BRL", Money.Real(1).Currency());
        }

        [TestMethod]
        public void TestSimpleAddition()
        {
            Money five = Money.Dollar(5);
            Calculation sum = five.plus(five);
            Bank bank = new Bank();
            Money reduced = bank.Reduce(sum, "USD");
            Assert.AreEqual(Money.Dollar(10), reduced);
        }

        [TestMethod]
        public void TestPlusReturnSum()
        {
            Money five = Money.Dollar(5);
            Calculation result = five.plus(five);
            Sum sum = (Sum)result;
            Assert.AreEqual(five, sum.augend);
            Assert.AreEqual(five, sum.addend);
        }

        [TestMethod]
        public void TestReduceSum()
        {
            Calculation sum = new Sum(Money.Real(3),Money.Real(4));
            Bank bank = new Bank();
            Money result = bank.Reduce(sum, "BRL");
            Assert.AreEqual(Money.Real(7),result);
        }

        [TestMethod]
        public void TestReduceMoney()
        {
            Bank bank = new Bank();
            Money result = bank.Reduce(Money.Dollar(1), "USD");
            Assert.AreEqual(Money.Dollar(1), result);
        }
    }
}