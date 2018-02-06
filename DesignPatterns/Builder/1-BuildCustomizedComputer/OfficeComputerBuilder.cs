using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDP
{
    public class OfficeComputerBuilder:ComputerBuilder
    {
        public override void SetCPUFrequency()
        {
            computer.CpuFrequency = 2.2m;
        }

        public override void SetCPUCore()
        {
            computer.NumberOfCores = 2;
        }

        public override void SetRam()
        {
            computer.Ram = 8;
        }

        public override void SetVGARam()
        {
            computer.VGARam = 1;
        }

        public override void SetDriveType()
        {
            computer.DriveType = "HDD";
        }
    }
}
