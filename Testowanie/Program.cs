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

            string temp;

            bool validTemp = false;

            while (!validTemp)
            {
                Console.WriteLine("Czwarte pytanie, bedzie wybor");

                Console.WriteLine("Czy jest zimny czy cieply? Wybierz \"C\" dla cieply lub \"Z\" dla zimny");

                temp = Console.ReadLine();

                if (temp == "C")
                {
                    Console.WriteLine("Dziekuje za odpowiedz");
                }
                else if (temp == "Z")
                {
                    Console.WriteLine("Dziekuje za odpowiedz");
                }
                else
                {
                    Console.WriteLine("Niepoprawna odpowiedz");
                }

                Console.WriteLine("Rozumiem ale pamietaj, ");

                if (temp == "C")
                
                    Console.WriteLine("ze bedzie gorecej");
                
                else if (temp == "Z")
                    
                    Console.WriteLine("aby zalozyc czapke na wszelki wypadek");

                {
                    validTemp = true;
                }

            }
            Console.WriteLine("Dziekuje i do widzenia");

        }
    }
}