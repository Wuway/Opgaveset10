using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_10_Interfaces
{
    public class ElectricCar : Car, IEnergy
    {
        /*public double BatteryLevel;
        public double BatteryCapacity;*/ //FINDES IKKE I OPDATERET DCD DIA
        public double KmPerKWh;
        public double EnergyLevel { get; set; }
        public double MaxEnergy { get; set; }



        public void Refill(double amount)
        {
        }

        public void UseEnergy(double km)
        {
        }

        public void Drive(double km)
        {
        }

        public void CanDrive(double km)
        {
        }


    }
}
