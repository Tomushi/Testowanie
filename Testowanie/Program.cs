using System;
    class Program
{
    static void Main()
    {
        Console.WriteLine("Czesc, testujemy");
        Console.WriteLine("Podaj liczbe calkowita: ");

        string input = Console.ReadLine();

        int number;

        bool success = int.TryParse(input, out number);

        if (success)
        {
            Console.WriteLine("Podales liczbe: " + number);
        }
        else
        {
            Console.WriteLine("To nie jest liczba calkowita");
        }
    }
}



