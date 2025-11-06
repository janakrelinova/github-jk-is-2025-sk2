string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("********************************************");
    Console.WriteLine("***** Generátor pseudonáhodných čísel ******");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine("************* Jana Křelinová ***************");
    Console.WriteLine("************** 06.11.2025 ******************");
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
    Random myRandNumb = new Random();
    //Random myRandNumb = new Random(15); //seed - semínko

    //kladná, záporná nebo nuly
    int negativeNumbs = 0;
    int positiveNumbs = 0;
    int zeros = 0;

    //sudá nebo lichá
    int evenNumbs = 0;
    int oddNumbs = 0;




    Console.WriteLine();
    Console.WriteLine("Náhodná čísla: ");
    Console.WriteLine();

    for (int i = 0; i < n; i++)
    {
        myRandNumbs[i] = myRandNumb.Next(lowerBound, upperBound);
        Console.Write("{0}; ", myRandNumbs[i]);

        /*
            if (myRandNumbs[i] > 0)
                positiveNumbs++; //když je číslo větší než 0, positiveNumbs zvýšíme o 1
            if (myRandNumbs[i] < 0)
                negativeNumbs--;
            if (myRandNumbs[i] == 0)
                zeros++; */

        if (myRandNumbs[i] > 0)      // program nemusí projít celým souborem porovnávání - když je číslo kladné, nepokračuje dál
            positiveNumbs++;
        else if (myRandNumbs[i] < 0)
            negativeNumbs++;
        else
            zeros++;

        if (myRandNumbs[i] % 2 == 0)
            evenNumbs++;
        else
            oddNumbs++;



    }

    Console.WriteLine();
    Console.WriteLine("Počet kladných {0}", positiveNumbs);
    Console.WriteLine("Počet záporných: {0}", negativeNumbs);
    Console.WriteLine("Počet nul: {0}", zeros);
    Console.WriteLine("Počet sudých čísel {0}", evenNumbs);
    Console.WriteLine("Počet lichých čísel: {0}", oddNumbs);

    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();

}

