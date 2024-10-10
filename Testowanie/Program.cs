using System;

namespace Testowanie

{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Pierwsze pytanie:");

            Console.WriteLine("Ile kot ma oczu?");

            string odp1 = Console.ReadLine();

            Console.WriteLine(" Podales odpowiedz: " + odp1 + " Bardzo dobrze");

            Console.WriteLine("Drugie pytanie");

            Console.WriteLine("Ile pies ma siersci?");

            string odp2 = Console.ReadLine();

            Console.WriteLine("Twoja Odpowiedz to " + odp2 + " No swietnie");

            Console.WriteLine("Trzecie pytanie, bedzie trudno ");

            Console.WriteLine("Ile nóg ma z przecinkiem?");

            double odp3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Twoja odpowiedz to " + odp3 + " Ja pierdziele, jestem zszokowany");

            Console.WriteLine("Dziekuje i do widzenia");

        }
    }
}