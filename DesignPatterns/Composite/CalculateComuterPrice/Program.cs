using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeDP
{
    class Program
    {
        static void Main(string[] args)
        {
            var computer = new Computer();
                var motherboard = new Motherboard(200);
                    var cpu = new CPU(450);
                    var ram = new RAM(220);
                    var vga = new VGA(450);
                var drive = new SSD(250);

            // Add Composit's components
            computer.Add(motherboard);
            computer.Add(drive);

            // Motherboard's components
            motherboard.Add(cpu);
            motherboard.Add(ram);
            motherboard.Add(vga);

            // Display computer price
            Console.Write("Computer price: " + computer.Price);

            // Wait for confirmation to quit
            Console.ReadLine();
        }
    }
}
