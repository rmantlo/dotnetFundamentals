using System;
using _05_Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _05_ClassesTests
{
    [TestClass]
    public class ClassExamples
    {
        [TestMethod]
        public void CookieExamples()
        {
            Cookie snickerdoodle = new Cookie();
            snickerdoodle.SugarAmount = 150;

            Cookie chocolateChip = new Cookie(700, true);
        }
        [TestMethod]
        public void VehicleExamples()
        {
            Vehicle vehicle = new Vehicle();
            vehicle.TypeOfVehicle = VehicleType.Car;
            vehicle.Make = "Toyota";
            vehicle.Model = "Corolla";
            vehicle.Mileage = 190000;
            vehicle.StartVehicle();
            Assert.IsTrue(vehicle.IsRunning); //check app
            vehicle.StopVehicle();
            Assert.IsFalse(vehicle.IsRunning);
            vehicle.DriveVehicle(500);
        }
        [TestMethod]
        public void EmployeeExample()
        {

        }
    }
}
