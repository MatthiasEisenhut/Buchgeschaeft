﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buchgeschaeft
{
    class Newspaper : Item
    {
        public DateTime dateOfIssue { get; set; }

        public Newspaper(decimal price, int stock, string title, DateTime dateOfIssue) : base(price, stock, title)
        {

        }
    }
}
