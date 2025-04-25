using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_10_Interfaces
{
    public class Taxi : Car, IEnergy
    {
        private Car Ienergy;
        private bool meterStarted;
        public double StartPrice;
        public double PricePerKm;
        public double PricePerMinute;
        public double EnergyLevel { get; set; }
        public double MaxEnergy { get; set; }


        public void StartMeter() { }
        public void StopMeter() { }
        public double CalculateFare(double km, double miutes) 
        {
            return 0;
        }

        public void Refill(double amount)
        {
        }

        public void UseEnergy(double km)
        {
        }

        public void Drive(double km) 
        {
        }

        public bool CanDrive(double km)
        {
            return false;
        }

    }

}
