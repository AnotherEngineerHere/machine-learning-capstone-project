using CapstoneProject.model;
using NUnit.Framework;

namespace NUnitTestProject1
{
    public class Test1
    {
        [SetUp]
        public void ListCarTest()
        {
        }

        [Test]
        public void addCarsTest()
        {
            Car c1 = new Car("vhigh", "vhigh", "2", "2", "med", "med", "bad");
            ListCars lc = new ListCars();
            lc.Add_Car("vhigh", "vhigh", "2", "2", "med", "med", "bad");
            Assert.AreEqual(c1.CarF, lc.Cars[0].CarF);
            
        }

        
    }
}