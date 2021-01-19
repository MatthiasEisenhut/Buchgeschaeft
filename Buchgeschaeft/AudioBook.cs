using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buchgeschaeft
{
    class AudioBook : Book
    {
        public int duration { get; set; }

        public AudioBook(decimal price, int stock, string Title, string author, string isbn, int duration) : base(price, stock, Title, author, isbn)
        {
            this.price = price;
            this.stock = stock;
            this.Title = Title;
            this.author = author;
            this.isbn = isbn;
            this.duration = duration;
        }

        public override string ToString()
        {
            return $"{Title} ({author}, {duration})";
        }
    }
}
