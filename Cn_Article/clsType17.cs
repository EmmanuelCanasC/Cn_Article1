using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Cn_Article
{
     class clsType17 : clsArticle
    {
        public double TYPE = 17;
        public double Iva;
        public clsType17(string name, double price) : base(name, price)
        {
            Name = name;
        }

        public override double IVAPart()
        {
            Iva = (Price * 19) / 100;
            return Iva;
        }

        public override void name()
        {
            Console.WriteLine("Artículo: ");
        }

        public override double price()
        {
            return Price = Price;
        }

        public override double Type()
        {
            return TYPE;
        }
     }
}
    

