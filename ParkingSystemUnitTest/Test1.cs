namespace ParkingSystemUnitTest
{
    [TestClass]
    public sealed class CarCanBeAdded
    {
        [TestMethod]
        public void TestMethod1()
        {
            ParkingSystem ps = new ParkingSystem(1, 0, 0);
            var result = ps.AddCar(1);
            Assert.IsTrue(result);
        }
    }
    [TestClass]
    public sealed class CarCantBeAdded
    {
        [TestMethod]
        public void TestMethod1()
        {
            ParkingSystem ps = new ParkingSystem(1, 0, 0);
            var result = ps.AddCar(2);
            Assert.IsFalse(result);
        }
    }
}
