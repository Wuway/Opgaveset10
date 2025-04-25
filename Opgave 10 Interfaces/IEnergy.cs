﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_10_Interfaces
{
    interface IEnergy
    {
        double EnergyLevel { get; set; }
        double MaxEnergy { get; set; }

        void Refill(double amount);
        void UseEnergy(double amount);
    }
}
