using System;

namespace aritmetk_işlemler_örn_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int kısakenar, uzunkenar, dikalan, dikcevre;
            int kenar, karealan, karecevre;
            Console.WriteLine("***karenin alan ve çevresini bulma");

            Console.WriteLine("karenin bir kenari giriniz");
            kenar = Convert.ToInt32(Console.ReadLine());
            karealan = kenar * kenar;
            karecevre = kenar * 4;

            Console.WriteLine("karenin alanı= " + karealan);
            Console.WriteLine("karenin cevresi= " + karecevre);
            Console.WriteLine();

            Console.WriteLine("dikdörtgenin alan ve cevresini bulma");

            Console.WriteLine("kısa kenari giriniz");
            kısakenar = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("uzun kenari giriniz");
            uzunkenar = Convert.ToInt32(Console.ReadLine());
            dikalan = uzunkenar * kısakenar;
            dikcevre = (kısakenar + uzunkenar) * 2;

            Console.WriteLine("dikdörtgenin alanı=" + dikalan);
            Console.WriteLine("dikdörtgenin cevresi= " + dikcevre);



            Console.ReadLine();


        }

    }
}

