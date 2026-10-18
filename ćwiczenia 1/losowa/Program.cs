using System;
{
    Random los = new Random();
    int losowy = los.Next(1, 101);
    int aa;
    Console.WriteLine("Zgadnij liczbę od 1 do 100");
    do
    {
        Console.Write("Podaj liczbę: ");
        aa = int.Parse(Console.ReadLine());

        if (aa > losowy)
            Console.WriteLine("Za dużo!");
        else if (aa < losowy)
            Console.WriteLine("Za mało!");
        else
            Console.WriteLine("Brawo, zgadłeś!");
    } while (aa != losowy);
}