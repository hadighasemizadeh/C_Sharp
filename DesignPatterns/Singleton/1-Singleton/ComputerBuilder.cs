using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public abstract class ComputerBuilder
    {
        protected readonly Computer computer = new Computer();

        public abstract void SetCPUFrequency();
        public abstract void SetCPUCore();
        public abstract void SetRam();
        public abstract void SetVGARam();
        public abstract void SetDriveType();


        // Returns built computer
        public virtual Computer GetComputer()
        {
            return computer;
        }

        public virtual void DisplayPCInf()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(computer.CpuFrequency.ToString() + " is CPU Frequency.\n");
            sb.Append(computer.NumberOfCores.ToString() + " is CPU Cores.\n");
            sb.Append(computer.Ram.ToString() + " is RAM.\n");
            sb.Append(computer.VGARam.ToString() + " is VGA RAM.\n");
            sb.Append(computer.DriveType + " is Drive Type.\n");

            Console.Write(sb.ToString());
        }
    }
}
