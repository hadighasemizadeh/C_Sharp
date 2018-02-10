using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDP
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a NotebookPro and NoteBookLite
            var notebookPro  = new NoteBookPro (1500m);
            var notebookLite = new NoteBookLite(1000m);

            // Creat 4 customers
            var customer1 = new Customer();
            var customer2 = new Customer();
            var customer3 = new Customer();
            var customer4 = new Customer();

            // Add two customer to follow new price: Use list
            notebookPro.AddFollower(customer1);
            notebookPro.AddFollower(customer2);

            // Add two customer to follow new price: Event system
            notebookLite.AddFollower(customer3);
            notebookLite.AddFollower(customer4);

            // New changes in prices: use their methods to update their customers
            notebookPro.Price = 1300m;
            notebookLite.Price = 800m;

            // Wait for a key to Quit
            Console.ReadKey();
        }
    }
}
