using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cn_Article
{
    internal class Program
    {
        static void Main(string[] args)
        {
            clsType4 CamCab = new clsType4("Camisa Caballero",59900);
            CamCab.name();
            Console.WriteLine("Tipo: {0}", CamCab.TYPE);
            Console.WriteLine("Nombre: {0}", CamCab.Name);
            Console.WriteLine("Precio Total: {0}" + "$", CamCab.Price);
            Console.WriteLine("%Iva Pagado: {0}" + "$", CamCab.IVAPart());

            Console.WriteLine();

            clsType7 BluDam = new clsType7("Blusa Dama",49900);
            BluDam.name();
            Console.WriteLine("Tipo: {0}", BluDam.TYPE);
            Console.WriteLine("Nombre: {0}", BluDam.Name);
            Console.WriteLine("Precio Total: {0}" + "$", BluDam.Price);
            Console.WriteLine("%Iva Pagado: {0}", BluDam.IVAPart());

            Console.WriteLine();

            clsType17 PantMix = new clsType17("Pantalon Mixto",159900);
            PantMix.name();
            Console.WriteLine("Tipo: {0}", PantMix.TYPE);
            Console.WriteLine("Nombre: {0}", PantMix.Name);
            Console.WriteLine("Precio Total: {0}" +"$", PantMix.Price);
            Console.WriteLine("% Iva Pago: {0}" + " $", PantMix.IVAPart());
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
