using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDP
{
    public class AssambleComputer
    {
        // Build requested computer
        public Computer Build(ComputerBuilder builder) {

            builder.SetCPUCore();
            builder.SetCPUFrequency();
            builder.SetRam();
            builder.SetVGARam();
            builder.SetDriveType();

            // Display data on console
            builder.DisplayPCInf();

           return  builder.GetComputer();
        }
    }
}
