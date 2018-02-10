using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDP
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create base sandwich
            var sandwich = new BaseSandwich();

            // Add WheatBread
            var wheatBreadSandwich = new WheatBread(sandwich);

            // Add WheatBread
            var chickenHam = new ChickenHam(wheatBreadSandwich);

            // Add double special Bacon
            var specialBacon = new SpecialBacon(new SpecialBacon(chickenHam));

            // Apply discount for special bacon
            var discount = new SpecilBaconDiscount(new SpecilBaconDiscount(specialBacon));

            // Dispay price
            Console.WriteLine(string.Format("{0} ==> costs: {1}$ ",discount.Name , discount.Price.ToString()));

            // Wait for key to quit
            Console.ReadLine();
        }
    }
}
