using System;
using System.Collections.Generic;
using System.Text;

namespace Session5Task
{
    internal class BooK
    {
        private string password = "secret";
        internal int copiesInStock = 5;
        public string Title = null!;

        public Genre Genre { get; set; }
    }
}
