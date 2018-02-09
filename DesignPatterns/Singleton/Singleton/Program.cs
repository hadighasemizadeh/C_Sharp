using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var gamingPC = new GamingPC();
            var assamblePC = AssambleComputer.Instance.Build(gamingPC);

            // Close only if I pressed a button
            Console.ReadLine();

        }
    }
}
