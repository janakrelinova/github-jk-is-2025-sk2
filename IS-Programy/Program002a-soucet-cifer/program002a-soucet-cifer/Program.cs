﻿string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("********************************************");
    Console.WriteLine("*********** Součet a součin cifer *************");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine("************* Jana Křelinová ******************");
    Console.WriteLine("************** 16.10.2025 *******************");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine();

    
    Console.Write("Zadejte celé číslo: ");
    int number;
    while (!int.TryParse(Console.ReadLine(), out number)) 
    {
        Console.Write("Nezadali jste celé číslo. Zadejte ho znovu: ");
    }

    int suma = 0;
    int numberBackup = number;
    int digit;

    //Pokud je vstup záporný, tak ho změníme na kladný
    if (number < 0)
    {
        number = -number;
    }

    while (number >= 10)
    {
        digit = number % 10; //určí se nám zbytek
        number = (number - digit) / 10;
        Console.WriteLine("Hodnota zbytku = {0}", digit);
        suma = suma + digit;
    }

    //musíme poslední cifru vypsat
    Console.WriteLine("Poslední zbytek = {0}", number);

    //musiíme poslední cifru přičíst
    suma = suma + number;

    Console.WriteLine() 
    Console.WriteLine("Součet cifer šísla {0} je , {1}", numberBackUp, suma)




    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();

}

