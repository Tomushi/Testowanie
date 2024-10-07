using System;

namespace InformacjeoUzytkowniku
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Podaj swoje imię: ");
            string imie = Console.ReadLine();

            int a = 100;
            int b = 200;
            int c = a + b;
            string potrawa = "paczki";
            string napoj = "piwo";
            double cena = 5.25;

            Console.WriteLine("zmienna a = " + a);
            Console.WriteLine("zmienna b = " + b);
            Console.WriteLine("zmienna c = " + c);
            Console.WriteLine("zmienna potrawa = " + potrawa);
            Console.WriteLine("zmienna napoj = " + napoj);
            Console.WriteLine("zmienna cena = " + cena);
        }
    }
}
