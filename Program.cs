﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            //deklarasi variabel
            int hasil;

            //membuat objek dari class Calculator
            Calculator calculator = new Calculator();

            //panggil method penjumlahan
            hasil = calculator.Penjumlahan(10, 2);
            CetakHasil("Hasil penjumlahan : " + hasil);

            //panggil method penjumlahan dengan 3 parameter (overload method)
            hasil = calculator.Penjumlahan(10, 2, 3);
            CetakHasil("Hasil penjumlahan overload : " + hasil);

            //panggil method Pengurangan
            hasil = calculator.Pengurangan(7, 2);
            CetakHasil("Hasil pengurangan : " + hasil);

            //panggil static method langsung dari nama classnya
            hasil = Calculator.Perkalian(5, 2);
            CetakHasil("Hasil Perkalian : " + hasil);


            Console.ReadKey();
        }

        static void CetakHasil(string hasil)
        {
            Console.WriteLine(hasil);
        }
    }
}
