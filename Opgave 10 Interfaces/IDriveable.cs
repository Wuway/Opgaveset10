using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_10_Interfaces
{
    interface IDriveable
    {
        void StartEngine();
        void StopEngine();
        void Drive(double km);
        bool CanDrive(double km);
    }
}
