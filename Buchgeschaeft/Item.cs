using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buchgeschaeft
{
    class Item
    {
        public decimal price { get; set; }
        public int stock { get; set; }
        public string Title { get; set; }

        public Item(decimal price, int stock, string Title)
        {
            this.price = price;
            this.stock = stock;
            this.Title = Title;
        }
    }
}
