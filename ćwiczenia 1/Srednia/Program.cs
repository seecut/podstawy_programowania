using System;
{
        Console.WriteLine("Podaj swoje imię:");
        string imie = Console.ReadLine();
    
    
        Console.WriteLine("Podaj pierwszą ocenę:");
        string a = Console.ReadLine();
        int aint = int.Parse(a);

        Console.WriteLine("Podaj drugą ocenę:");
        string b = Console.ReadLine();
        int bint = int.Parse(b);

        Console.WriteLine("Podaj trzecią ocenę:");
        string c = Console.ReadLine();
        int cint = int.Parse(c);
    
int suma = (aint+bint+cint);
double srednia = (double)suma / 3;
Console.WriteLine($"{imie}, twoja średnia to {srednia}!");

    if (srednia > 3)
    Console.WriteLine("zdane!");
    else
    {
        Console.WriteLine("nie zdane");
    }
}