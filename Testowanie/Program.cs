using System;

namespace InformacjeoUzytkowniku
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Witaj");
            Console.WriteLine("Podaj swoje imie");
            string imie = Console.ReadLine();

            
            double czas = 15.65;
            int cyfra = 7;
            int wiek = 20;

            Console.WriteLine($"Czas: {czas}");
            Console.WriteLine($"Cyferka: {cyfra}");
            Console.WriteLine("Wiek " + wiek);
        }

    }
}
