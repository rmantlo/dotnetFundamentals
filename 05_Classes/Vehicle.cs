using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Classes
{
    public enum VehicleType { Car = 1, Truck, Van, Motorcycle, SUV, Minivan, Boat, Plane, SpaceShip }
    public class Vehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int MakeYear { get; set; }
        public string VehicleIDNumber { get; set; }
        public string LicencePlateNumber { get; set; }
        public double Mileage { get; set; }
        public int CoolnessFactor { get; set; }
        public VehicleType TypeOfVehicle { get; set; }
        public bool IsRunning { get; set; }

        public void StartVehicle()
        {
            IsRunning = true;
            CoolnessFactor++;
        }
        public void StopVehicle()
        {
            IsRunning = false;
            CoolnessFactor--;
        }
        public void DriveVehicle(double distanceTraveled)
        {
            if (IsRunning)
            {
                Mileage = Mileage + distanceTraveled;
                CoolnessFactor++;
            }
        }
    }
}
