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
            ListCars lc = new ListCars();
            lc.Add_Car("vhigh", "vhigh", "2", "2", "med", "med", "bad");
            Assert.AreEqual(c1.CarF, lc.Cars[0].CarF);
            
        }

        public void rangeTest()
        {
            ListCars lc = new ListCars();
            lc.Add_Car("vhigh", "vhigh", "2", "2", "med", "med", "bad");
            lc.Add_Car("vhigh", "vhigh", "3", "2", "med", "med", "bad");
            lc.Add_Car("vhigh", "vhigh", "4", "2", "med", "med", "bad");
            lc.Add_Car("vhigh", "vhigh", "3", "2", "med", "med", "bad");
            Assert.AreEqual(3, lc.Get_Range_From_Values(2,3,1).Count);

        }


    }
}