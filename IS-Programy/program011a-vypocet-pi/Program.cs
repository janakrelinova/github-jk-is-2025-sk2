string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("********************************************");
    Console.WriteLine("*************** Výpočet PI *****************");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine("************* Jana Křelinová ***************");
    Console.WriteLine("************** 04.12.2025 ******************");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine();


    Console.Write("Zadejte číslo přesnosti: ");
    double presnost;
    while (!double.TryParse(Console.ReadLine(), out presnost)) 
    {
        Console.Write("Nezadali jste číslo. Zadejte číslo znovu: ");
    }
     
    double i = 1;
    double piCtvrt = 1;
    double znam = 1;

    while((1/i) >= presnost)
    {
        i = i + 2;
        znam = - znam;
        piCtvrt = piCtvrt + znam *1/i;
    }

    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("Hodnota čísla PI = {0}", 4 * piCtvrt);




    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();

}

