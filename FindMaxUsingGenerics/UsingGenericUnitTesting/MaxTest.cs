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
        //Float
        [Test]


        public void FindingMaxFloatNumberAtPosition1()
        {
            double maxNumber = MaxNumberCheck.MaximumFloatNumber(30.0, 20.0, 10.0);
            Assert.AreEqual(30.0, maxNumber);
        }
        [Test]
        public void FindingMaxFloatNumberAtPosition2()
        {
            double maxNumber = MaxNumberCheck.MaximumFloatNumber(20.0, 30.0, 10.0);
            Assert.AreEqual(30.0, maxNumber);
        }
        [Test]
        public void FindingMaxFloatNumberAtPosition3()
        {
            double maxNumber = MaxNumberCheck.MaximumFloatNumber(10.0, 20.0, 30.0);
            Assert.AreEqual(30.0, maxNumber);
        }
        //string

        [Test]
        public void FindingMaxStringAtPosition1()
        {
            string maxString = MaxNumberCheck.MaximumString("Banana", "Apple", "Peach");
            Assert.AreEqual("Peach", maxString);
        }
        [Test]
        public void FindingMaxStringAtPosition2()
        {
            string maxString = MaxNumberCheck.MaximumString("Apple", "Banana", "Peach");
            Assert.AreEqual("Peach", maxString);
        }
        [Test]
        public void FindingMaxStringAtPosition3()
        {
            string maxString = MaxNumberCheck.MaximumString("Apple", "Peach", "Banana");
            Assert.AreEqual("Peach", maxString);
        }
    }
}
