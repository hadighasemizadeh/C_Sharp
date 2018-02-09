using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class AssambleComputer
    {
        private static readonly AssambleComputer  _instance = new AssambleComputer();
        public static AssambleComputer Instance {
            get
            {
                return _instance;
            }
        }
        
        private AssambleComputer() { }
        
        public Computer Build(ComputerBuilder builder)
        {
            builder.SetCPUCore();
            builder.SetCPUFrequency();
            builder.SetRam();
            builder.SetVGARam();
            builder.SetDriveType();

            // Display data on console
            builder.DisplayPCInf();

            return builder.GetComputer();
        }
    }
}
