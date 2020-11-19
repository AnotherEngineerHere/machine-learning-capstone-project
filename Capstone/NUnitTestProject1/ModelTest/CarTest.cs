using CapstoneProject.model;
using NUnit.Framework;

namespace NUnitTestProject1
{
    public class Tests
    {
        [SetUp]
        public void CarTest()
        {
        }

        [Test]
        public void soldPriceTest()
        {
            Car c1 = new Car("vhigh", "vhigh", "2", "2", "med", "med", "bad");

            Assert.AreEqual("vhigh", c1.Sold_Price);
        }

        [Test]
        public void maintenacePriceTest()
        {
            Car c1 = new Car("vhigh", "vhigh", "2", "2", "med", "med", "bad");

            Assert.AreEqual("vhigh", c1.Maintenace_Price);
        }
    }
}