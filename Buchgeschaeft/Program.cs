using System;
using System.Collections.Generic;
using Buchgeschaeft;

namespace Buchgeschaeft
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Item> items = new List<Item>();
            Book b1 = new Book(49.99m, 200, "The Malta Exchange", "Steve Berry", "9781250140265", Category.Thriller);
            Newspaper n1 = new Newspaper(01.99m, 1000, "Der Standard", new DateTime(2020, 10, 20));
            AudioBook ab1 = new AudioBook(06.99m, 9999, "Alea Aquarius 6: Der Fluss des Vergessens", "Tanya Stewner", "9783789104367", 536, Category.Children);

            Console.WriteLine(b1);
            Console.WriteLine(n1);
            Console.WriteLine(ab1);
            Console.ReadKey();
        }
    }
}
