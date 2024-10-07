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
            
            Console.WriteLine("Witaj " + imie);
            
            Console.WriteLine("Podaj swoje nazwisko");
            
            string nazwisko = Console.ReadLine();
            
            Console.WriteLine("Super nazwisko " + nazwisko);
            
            Console.WriteLine("Podaj swoj wiek");
            
            int wiek = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Twój wiek to " + wiek);
            
            string sex = "";
            
            bool validSex = false;
            
            while (!validSex)
            {
                Console.WriteLine("Podaj swoja plec (M lub K)");
            
                sex = Console.ReadLine();
                
                if (sex == "M" || sex == "K")

                    validSex = true;
                
                else
                    Console.WriteLine("Podales zla plec");
            }
            
            Console.WriteLine("Twoja plec " + sex);
            
            if (sex == "M")
                Console.WriteLine("Czyli jestes normalnym facetem");
            else
                Console.WriteLine("Czyli jestes normalna kobieta");
        }

    }
}
