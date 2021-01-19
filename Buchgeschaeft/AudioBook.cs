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

        public AudioBook(decimal price, int stock, string title, string author, string isbn, int duration) : base(price, stock, title, author, isbn)
        {

        }
    }
}
