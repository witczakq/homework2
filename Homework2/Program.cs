using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2         // Aplikacja losuje liczbę a użytkownik musi odgadnąć ją poprzez wpisanie liczby w konsoli. Aplikacja zwraca informację o tym czy użytkownik trafił. 
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var result = false;
                var trialCounter = 1;
                var randomNumber = new Random();
                var guessNumber = randomNumber.Next(0, 100);
                Console.WriteLine("Komputer wylosował liczbę z zakresu 0-100.\n");
                Console.WriteLine("Spróbuj zgadnąć. Wprowadź liczbę:\n");

                while (!result)
                {
                    if (!int.TryParse(Console.ReadLine(), out int userNumber))
                        throw new Exception("Podana wartość jest nieprawidłowa!");
                    if (userNumber < 0 || userNumber > 100)
                        throw new Exception("Podana przez Ciebie liczba jest spoza zakresu!\n");
                    if (userNumber == guessNumber)
                    {
                        Console.WriteLine("Brawo! Odgadłeś liczbę wylosowaną przez komputer w {0} próbie.", trialCounter);
                        result = true;
                    }
                    else if (userNumber > guessNumber)
                    {
                        Console.WriteLine("\nPodałeś większą liczbę. Spróbuj ponownie!");
                        result = false;
                        trialCounter++;
                    }
                    else if (userNumber < guessNumber)
                    {
                        Console.WriteLine("\nPodałeś mniejszą liczbę. Spróbuj ponownie!");
                        result = false;
                        trialCounter++;
                    }
                }
                Console.WriteLine("\nDziękuję za udział w grze!\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("\nPrzykro mi, ale to koniec gry.");
                Console.WriteLine("\nNaciśnj dowolony klawisz, aby zakończyć grę i wyjść.");
                Console.ReadKey();
            }
        }
    }
}
