string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("********************************************");
    Console.WriteLine("*********** vykreslení obdélníku *************");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine("************* Jana Křelinová ******************");
    Console.WriteLine("************** 24.10.2025 *******************");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine();



  Console.Write("Zadejte velikost základny pravoúhlého trojúhelníku: ");
    int size;
    while (!int.TryParse(Console.ReadLine(), out size))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte hodnotu znovu: ");
    }

    
    for (int i = 1; i <= size; i++)  
    {
        for (int j = 1; j <= i; j++)     
        {
            Console.Write(". ");
        }

        Console.WriteLine();  
    }



    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();

}

