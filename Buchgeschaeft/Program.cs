using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buchgeschaeft
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Item> items = new List<Item>();
            Book b1 = new Book(49.99m, 200, "The Malta Exchange", "Steve Berry", "1234");
            Newspaper n1 = new Newspaper(01.99m, 1000, "Der Standard", new DateTime(2020, 10, 20));
            AudioBook ab1 = new AudioBook(06.99m, 9999, "Alea Aquarius 6: Der Fluss des Vergessens", "Tanya Stewner", "4321", 536);
        }
    }
}
