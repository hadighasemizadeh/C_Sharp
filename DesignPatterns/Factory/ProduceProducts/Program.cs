using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDP
{
    class Program
    {
        static void Main(string[] args)
        {
            // Display question
            Console.Write("Create for client a or b ?");
            // Get client name :: a or b
            var client = Console.ReadLine();

            // create a new factory for producing for client
            IFactory mFactory;

            if (client == "a"){

                mFactory = new ClientAFactory();
            } else if (client == "b") {

                mFactory = new ClientBFactory();
            } else {
                // Don't produce anything
                return;
            }

            var orderProduct = new OrderProduct();
            Console.Write("How many computers?");
            orderProduct.Computers = ConvertToInt(Console.ReadLine());

            Console.Write("How many tablets?");
            orderProduct.Tablets = ConvertToInt(Console.ReadLine());

            Console.Write("How many tvs?");
            orderProduct.Tvs = ConvertToInt(Console.ReadLine());

            var company = new NewTechCompany(mFactory);
            // Produce order
            company.Produce(orderProduct);

            // Display what was produced
            Console.WriteLine(company.Comuters.Count()  + " Computer(s) created.");
            Console.WriteLine(company.Tablets.Count()   + " Tablet(s) created.");
            Console.WriteLine(company.Tvs.Count()       + " Tv(s) created.");

            Console.ReadLine();
        }

        private static int ConvertToInt(string input) {
            if (string.IsNullOrWhiteSpace(input)) {
                return 0;
            }

            return Int32.Parse(input);
        }
    }
}
