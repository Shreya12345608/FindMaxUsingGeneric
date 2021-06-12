using NUnit.Framework;
using FindMaxUsingGenerics;

namespace UsingGenericUnitTesting
{

    public class UnitTest1
    {
        [Test]
        public void FindingMaxNumberAtPosition1()
        {
            int maxNumber = MaxNumberCheck.MaximumIntegerNumber(30, 20, 10);
            Assert.AreEqual(30, maxNumber);
        }
        [Test]
        public void FindingMaxNumberAtPosition2()
        {
            int maxNumber = MaxNumberCheck.MaximumIntegerNumber(20, 30, 10);
            Assert.AreEqual(30, maxNumber);
        }
        [Test]
        public void FindingMaxNumberAtPosition3()
        {
            int maxNumber = MaxNumberCheck.MaximumIntegerNumber(10, 20, 30);
            Assert.AreEqual(30, maxNumber);
        }
    }
}
