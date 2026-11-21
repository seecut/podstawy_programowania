
using System;
class Program
{
    static void Main()
    {
        Console.Write("Podaj wysokość: ");
        int wys = int.Parse(Console.ReadLine());
        for (int a = 1; a <= wys; a++)
        {
            for (int b = 1; b <= a; b++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }
    }
}