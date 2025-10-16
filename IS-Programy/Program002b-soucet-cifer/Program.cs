using System;

class Program
{
    static void Main()
    {
        Console.Write("Zadej celé číslo: ");
        string vstup = Console.ReadLine();

        int soucet = 0;

        foreach (char znak in vstup)
        {
            if (char.IsDigit(znak))
            {
                int cifra = int.Parse(znak.ToString());
                soucet += cifra;
            }
        }

        Console.WriteLine($"Součet cifer je: {soucet}");
    }
}