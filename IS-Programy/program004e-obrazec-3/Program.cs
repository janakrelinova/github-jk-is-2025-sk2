string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("********************************************");
    Console.WriteLine("******* vykreslení obrazce - diamant *******");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine("************* Jana Křelinová ***************");
    Console.WriteLine("************** 05.11.2025 ******************");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine();



  Console.Write("Zadejte lichou velikost diamantu: ");
    int size;
    while (!int.TryParse(Console.ReadLine(), out size))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte velikost obrazce znovu: ");
    }

    if(size % 2 == 0) //když je zbytek 0, číslo je sudé
    {
        Console.WriteLine("Velikost musí být liché číslo");
    }

    int middle = size / 2; //zadám př.: 5, potom je middle 2

    //Horní část diamantu
    for (int r = 0; r <= middle; r++)
    {
        int space = middle - r;
        int star = size - 2 * space;

        //mezery
        for (int i = 0; i < space; i++)
            Console.Write(" ");

        //hvězdy
        for (int i = 0; i < star; i++)
            Console.Write("*");

        Console.WriteLine();

    }

    for (int r = middle - 1; r >= 0; r--)
    {
        int space = middle - r;
        int star = size - 2 * space;

        for (int i = 0; i < space; i++)
            Console.Write(" ");

        for (int i = 0; i < star; i++)
            Console.Write("*");
            
        Console.WriteLine();

    }



    



    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();

}
