using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeDP
{
    public class Computer:ICloneable
    {
        public decimal CpuFrequency { get; set; }
        public int NumberOfCores { get; set; }
        public int Ram { get; set; }
        public string DriveType { get; set; }
        public GraphicCard GPU { get; set; }

        public object Clone()
        {
            return MemberwiseClone();
        }

        public void DisplayPCInf()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(" **************** \n");
            sb.Append(CpuFrequency.ToString()   + " is CPU Frequency.\n");
            sb.Append(NumberOfCores.ToString()  + " is CPU Cores.\n");
            sb.Append(Ram.ToString()            + " is RAM.\n");
            sb.Append(DriveType                 + " is Drive Type.\n");
            sb.Append(GPU.GPUFrequency          + " is GPU Frequency.\n");
            sb.Append(GPU.GPURam                + " is GPU Ram.\n");

            Console.Write(sb.ToString());
        }
    }
}
