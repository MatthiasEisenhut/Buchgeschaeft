using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buchgeschaeft
{
    public class Book : Item
    {
        public string author;
        public string isbn;
        protected Category category;

        public Book(decimal price, int stock, string Title, string author, string isbn, Category category) : base(price, stock, Title)
        {
            this.author = author;
            this.isbn = isbn;
            this.category = category;
        }

        public override string ToString()
        {
            return $"{Title} ({author}, {category} ({(int)this.category}))";
        }
    }

    public enum Category
    {
        History = 10,
        Thriller = 20,
        Fantasy = 30,
        Food = 40,
        Children = 50
    }
}
