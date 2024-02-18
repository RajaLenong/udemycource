using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest1
{
    class Program
    {
        static void Main(string[] args)
        {
            int angka1;
            int angka2;
            int hasil;

            angka1 = 10;
            angka2 = 5;
            hasil = (angka1 + angka2);

            Console.WriteLine("Hasil dari penjumlahan " + angka1.ToString() + " ditambah " + angka2.ToString() + " adalah " + hasil.ToString());
            Console.ReadKey();
        }
    }
}
