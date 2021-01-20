using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buchgeschaeft
{
    public class AudioBook : Book
    {
        public int duration;

        public AudioBook(decimal price, int stock, string Title, string author, string isbn, int duration, Category category) : base(price, stock, Title, author, isbn, category)
        {          
            this.duration = duration;
        }

        public override string ToString()
        {
            return $"{Title} ({author}, {duration} Minuten, {category} ({(int)this.category}))";
        }
    }
}
