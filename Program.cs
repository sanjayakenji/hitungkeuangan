using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menghitungkeuangan
{
    class Program
    {
        static void Main(string[] args)
        {
            Presentase presentase = new Presentase();

            Console.Write("Dana yang kamu punya = ");
            int uang = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Persepuluhan : Rp. {0}", presentase.persepuluhan(uang));

            Console.WriteLine("Keinginan : Rp. {0}", presentase.keinginan(uang));

            Console.WriteLine("Investasi : Rp. {0}", presentase.investasi(uang));

            Console.WriteLine("Kebutuhan : Rp. {0}", presentase.kebutuhan(uang));
        }
    }
}
