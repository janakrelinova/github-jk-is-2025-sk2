string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("********************************************");
    Console.WriteLine("**** vykreslení obrazce - šachovnice *******");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine("************* Jana Křelinová ***************");
    Console.WriteLine("************** 25.10.2025 ******************");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine();



  Console.Write("Zadejte šířku obrazce: ");
    int width;
    while (!int.TryParse(Console.ReadLine(), out width))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte šířku obdélníka znovu: ");
    }

    Console.Write("Zadejte výšku obrazce: ");
    int height;
    while (!int.TryParse(Console.ReadLine(), out height))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte výšku obdélníka znovu: ");
    }


    for (int i = 1; i <= height; i++)
    {
        for (int j = 1; j <= width; j++)
        {
            if ((i + j) % 2 == 0)
                Console.Write("**");
            else
                Console.Write("  ");
        }
        Console.WriteLine();
    }  
    
    
    


    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();

}

