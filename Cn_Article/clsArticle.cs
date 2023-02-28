using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cn_Article
{
    abstract class clsArticle
    {
        public string Name { get; set; }
        public double Price { get; set; }


        public abstract double price();
        public abstract double IVAPart();
        public abstract double Type();
        public clsArticle(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public abstract void name();
    }
}
