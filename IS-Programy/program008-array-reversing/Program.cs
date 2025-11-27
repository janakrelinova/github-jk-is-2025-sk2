string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("********************************************");
    Console.WriteLine("************ Reverze pole ******************");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine("************* Jana Křelinová ***************");
    Console.WriteLine("************** 27.11.2025 ******************");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine();


    Console.Write("Zadajte počet čísel (celé číslo): ");
    int n;
    while(!int.TryParse(Console.ReadLine(), out n))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte počet čísel znovu");
    }

    Console.Write("Zadajte dolní mez (celé číslo): ");
    int lowerBound; //dolní mez
    while(!int.TryParse(Console.ReadLine(), out lowerBound))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte dolní mez znovu");
    }

    Console.Write("Zadajte horní mez (celé číslo): ");
    int upperBound; //horní mez
    while (!int.TryParse(Console.ReadLine(), out upperBound))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte horní mez znovu");
    }

    Console.WriteLine();
    Console.WriteLine("======================");
    Console.WriteLine("Zadané hodnoty");
    Console.WriteLine("Počet čísel: {0}, Dolní mez: {1}, Horní mez: {2}", n, lowerBound, upperBound);
    //pokud by byla v {} všude 0, vypsalo by se všude jen "n"
    Console.WriteLine("======================");
    Console.WriteLine();

    // deklarace pole (array)
    int[] myRandNumbs = new int[n];

    // příprava pro využití třídy Random
    //Random myRandNumb = new Random();
    Random myRandNumb = new Random(15); //seed - semínko


    Console.WriteLine();
    Console.WriteLine("Náhodná čísla: ");

    for(int i = 0; i < n ; i++)
    {
        myRandNumbs[i] = myRandNumb.Next(lowerBound, upperBound);
        Console.Write("{0}; ", myRandNumbs[i]);
    }



    for(int i = 0; i < n/2; i++)
    {
        int tmp = myRandNumbs[i]; //do proměnný si vložím aktuální prvek
        myRandNumbs[i] = myRandNumbs[n - 1 - i]; // když mám 5 čísel, prohodím i = 0 s i = 4; tzn 5 - 1 - 0 = 4 (-1 protože začínám od 0)
        myRandNumbs[n - 1 - i] = tmp;
    }

    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("Pole po reverzi: ");
    for(int i = 0; i < n; i++)
    {
    
        Console.Write("{0}; ", myRandNumbs[i]);
    }



    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();

}

