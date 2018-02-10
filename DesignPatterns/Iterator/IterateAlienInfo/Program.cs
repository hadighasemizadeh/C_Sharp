using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorDP
{
    class Program
    {
        static void Main(string[] args)
        {
            var customObj = new CustomClass()
            {
                Name = "Alien",
                Age  = "30000",
                Email= "Alien.30000@Gal.et"
            };

            var itr = customObj.GetEnumerator();
            itr.MoveNext();
            Console.WriteLine(itr.Current);

            itr.MoveNext();
            Console.WriteLine(itr.Current);

            itr.MoveNext();
            Console.WriteLine(itr.Current);

            // Wait for key to Quit
            Console.ReadKey();
        }
    }
}
