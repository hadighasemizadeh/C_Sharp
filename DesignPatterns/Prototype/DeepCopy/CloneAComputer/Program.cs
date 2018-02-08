using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeDP
{
    class Program
    {
        static void Main(string[] args)
        {
            // Construct new Graphic Card
            var gpu = new GraphicCard
            {
                GPUFrequency = 1.2m,
                GPURam = 6

            };

            // Construct a new computer
            var pc = new Computer()
            {
                CpuFrequency = 3.6m,
                NumberOfCores = 12,
                Ram = 32,
                DriveType = "SSD",
                GPU = gpu
            };

            // Clone new created computer
            var pc2 = (Computer)pc.Clone();

            // Pc 
            pc.DisplayPCInf();
            // Pc2 : Cloned 
            pc2.DisplayPCInf();

            // Change pc gpu ram
            pc.GPU.GPURam = 16;

            // Pc 
            pc.DisplayPCInf();
            // Pc2 : Cloned 
            pc2.DisplayPCInf();

            // Close only if I pressed a button
            Console.ReadLine();
        }
    }
}
