using System;
namespace EvenOrOddNumber
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę");

            while (true)
            {
                string input = Console.ReadLine();
                int number;
                if (int.TryParse(input, out number))
                {
                    if (number % 2 == 0)
                    {
                        Console.WriteLine("To jest liczba przysta");
                    }
                    else
                    {
                        Console.WriteLine("To jest liczba nieparzysta");
                    }
                    Console.WriteLine("Czy chcesz sprawdzić kolejną liczbę? Wpisz 'tak' lub 'nie'");
                    string answer = Console.ReadLine();
                    if (answer == "tak")
                    {
                        Console.WriteLine("Podaj liczbę");
                    }
                    else if (answer == "nie")
                    {
                        Console.WriteLine("Dziękuję za skorzystanie z programu");
                        break;
                    }
                    else if (answer != "nie")
                        Console.WriteLine("Nie rozumiem decyzji, wprowadz jeszcze raz decyzję");
                }
                else
                {
                    Console.WriteLine("Wprowdz cyfrę");
                }
            }
        }
    }
}
