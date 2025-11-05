string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("********************************************");
    Console.WriteLine("***** vykreslení obrazce - písmeno N *******");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine("************* Jana Křelinová ***************");
    Console.WriteLine("************** 05.11.2025 ******************");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine();



  Console.Write("Zadejte velikost obrazce: ");
    int size;
    while (!int.TryParse(Console.ReadLine(), out size))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte velikost obrazce znovu: ");
    }



    for (int i = 0; i < size; i++)
    {
        for (int j = 0; j < size; j++) 
        {
            if (j == 0 || j == size - 1 || j == i) //diagonála - když sloupec = řádek!!, př.: 3. sloupec a 3.řádek
            {
                Console.Write("*");
            }
            else
            {
                Console.Write(" ");
            }

        }
        Console.WriteLine();
    }



    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();

}


