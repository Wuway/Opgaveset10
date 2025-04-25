using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_10_Interfaces
{
    public abstract class Car : IDriveable
    {
        public string Brand;
        public string Model;
        public string LicensePlate;
        public int Odometer;
        public bool IsEngineRunning;

        public void StartEngine()
        {
        }

        public void StopEngine()
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
