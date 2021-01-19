using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buchgeschaeft
{
    class Book : Item
    {
        public string author { get; set; }
        public string isbn { get; set; }

        public Book(decimal price, int stock, string Title, string author, string isbn) : base(price, stock, Title)
        {
            this.price = price;
            this.stock = stock;
            this.Title = Title;
            this.author = author;
            this.isbn = isbn;
        }

        public override string ToString()
        {
            return $"{Title} ({author})";
        }
    }
}
