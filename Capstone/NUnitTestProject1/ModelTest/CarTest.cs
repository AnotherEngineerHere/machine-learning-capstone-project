using CapstoneProject.model;
using NUnit.Framework;

namespace NUnitTestProject1
{
    public class Tests
    {
        [SetUp]
        public void ListCarsTest()
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
            Car c1 = new Car("vhigh", "vhigh", "4", "3", "med", "med", "bad");

            Assert.AreEqual("vhigh", c1.Maintenace_Price);
        }
        public void numberDoorsTest()
        {
            Car c1 = new Car("vhigh", "vhigh", "2", "2", "med", "med", "bad");

            Assert.AreEqual("2", c1.Number_Doors);
        }
        public void numberOccupantsTest()
        {
            Car c1 = new Car("vhigh", "vhigh", "2", "2", "med", "med", "bad");

            Assert.AreEqual("2", c1.Number_Occupants);
        }
        public void lugBootSizeTest()
        {
            Car c1 = new Car("vhigh", "vhigh", "5", "2", "med", "med", "bad");

            Assert.AreEqual("med", c1.Lug_Boot_Size);
        }
        public void safetyLevelTest()
        {
            Car c1 = new Car("vhigh", "vhigh", "3", "4", "med", "med", "bad");

            Assert.AreEqual("med", c1.Safety_Level);
        }
        public void carFTest()
        {
            Car c1 = new Car("vhigh", "vhigh", "3", "4", "med", "med", "bad");

            Assert.AreEqual("bad", c1.CarF);
        }
    }
}