using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanalMetod
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri m1 = new Musteri();

            m1.isim = "Salih";
            m1.soyisim = "Koç";

            Console.WriteLine(m1.ToString());
            Console.ReadKey();
        }
    }
}
