using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDP
{
    class Program
    {
        
        static void Main(string[] args)
        {
            var assamblePC = new AssambleComputer();
            var highEndPC = new HighEndComputerBuilder();

            // Build a high end pc for me and display its information
            assamblePC.Build(highEndPC);

            // Close only if I pressed a button
            Console.ReadLine();
        }
    }
}
