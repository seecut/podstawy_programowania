using System;
class Program
{
    static void Main()
    {
        Console.Write("Podaj liczbę: ");
        int liczba = int.Parse(Console.ReadLine());
        int dzielnik = 0;
        if (liczba > 1)
        {
            for (int a = 2; a < liczba; a++)
            {
                if (liczba % a == 0)
                {
                    dzielnik = 1;
                    break;
                }
            }
        }
        else
        {
            dzielnik = 1;
        }

        if (dzielnik == 0)
        {
            Console.WriteLine(liczba + " jest liczbą pierwszą.");
        }
        else
        {
            Console.WriteLine(liczba + " nie jest liczbą pierwszą.");
        }
    }
}