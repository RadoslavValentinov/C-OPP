using System;
using NUnit.Framework;

namespace RepairShop.Tests
{
    public class Tests
    {
        public class RepairsShopTests
        {
            [Test]
            public void TestconstructorSetValueCorectly()
            {
                Garage garage = new Garage("RadiGarage", 2);

                Assert.AreEqual(garage.Name,"RadiGarage");
                Assert.AreEqual(garage.MechanicsAvailable,2);
            }

            [TestCase(null,2)]
            [TestCase("",2)]
            public void TestPropertyNNameThrowException(string name ,int mehanic)
            {
                Assert.Throws<ArgumentNullException>(()=>new Garage(name,mehanic), "Invalid garage name.");
            }

            [TestCase("Radi", 0)]
            [TestCase("Radi", -1)]
            [TestCase("Radi", -10)]
            public void TestPropertyMechanicsAvailableThrowException(string name, int mehanic)
            {
                Assert.Throws<ArgumentException>(() => new Garage(name, mehanic), "At least one mechanic must work in the garage.");
            }

            [Test]
            public void TestpropertyCount()
            {
                Garage garage = new Garage("Radi", 2);
                Car car = new Car("BMW",2);

                garage.AddCar(car);

                Assert.AreEqual(1,garage.CarsInGarage);
            }

            [Test]
            public void TestMethodAddCarThrowException()
            {
                Garage garage = new Garage("Radi", 2);
                Car car = new Car("BMW", 2);

                garage.AddCar(car);
                garage.AddCar(car);

                Assert.Throws<InvalidOperationException>(() => garage.AddCar(car), "No mechanic available.");
            }

            [Test]
            public void TestMethodFixCarThrowexception()
            {
                Garage garage = new Garage("Radi", 2);
                Assert.Throws<InvalidOperationException>(() => garage.FixCar("BMW"), $"The car {"BMW"} doesn't exist.");
            }

            [Test]
            public void TestMethodFixCarWorkCorectly()
            {
                Garage garage = new Garage("Radi", 2);
                Car car = new Car("BMW", 2);

                garage.AddCar(car);
                var curent = garage.FixCar("BMW");
                Assert.AreEqual(curent.NumberOfIssues,0);
            }

            [Test]
            public void TestMethodRemoveFixedCarThrowException()
            {
                Garage garage = new Garage("Radi", 2);
                Car car = new Car("BMW", 2);

                garage.AddCar(car);
                garage.AddCar(car);

                Assert.Throws<InvalidOperationException>(() => garage.RemoveFixedCar(), "No fixed cars available.");
            }
            [Test]
            public void TestMethodRemoveFixedCarRemoveCorectly()
            {
                Garage garage = new Garage("Radi", 2);
                Car car = new Car("BMW", 2);
                Car car2 = new Car("AUDI", 2);

                garage.AddCar(car);
                garage.AddCar(car2);
                garage.FixCar("AUDI");
                garage.RemoveFixedCar();
                Assert.AreEqual(garage.CarsInGarage,1);
            }

            [Test]
            public void TestMethodRaportWorkcorectly()
            {
                Garage garage = new Garage("Radi", 2);
                Car car = new Car("BMW", 2);
                Car car2 = new Car("AUDI", 2);

                garage.AddCar(car);
                garage.AddCar(car2);
                garage.FixCar("AUDI");
                garage.RemoveFixedCar();
                var rap = garage.Report();
                Assert.AreEqual(rap, $"There are {garage.CarsInGarage} which are not fixed: {"BMW"}.");
            }
            [Test]
            public void TestMethod()
            {
                Garage garage = new Garage("Radi", 2);
                Car car = new Car("BMW", 2);
                
                garage.AddCar(car);
               
                Assert.AreEqual(garage.FixCar("BMW").IsFixed,car.IsFixed);
            }
        }
    }
}