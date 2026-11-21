using System;

class Program
{
    static void Main()
    {
        Console.Write("Podaj liczbę: ");
        int a = int.Parse(Console.ReadLine());

        for (int b = 1; b <= 10; b++)
        {
            Console.WriteLine($"{a} x {i} = {a * i}");
        }
    }
}