using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class GamingPC : ComputerBuilder
    {
        public override void SetCPUFrequency()
        {
            computer.CpuFrequency = 3.6m;
        }

        public override void SetCPUCore()
        {
            computer.NumberOfCores = 64;
        }

        public override void SetRam()
        {
            computer.Ram = 64;
        }

        public override void SetVGARam()
        {
            computer.VGARam = 8;
        }

        public override void SetDriveType()
        {
            computer.DriveType = "SDD";
        }
    }
}
