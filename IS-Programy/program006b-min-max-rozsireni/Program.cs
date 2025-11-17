string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("********************************************");
    Console.WriteLine("* Generátor pseudonáhodných čísel + min a max*");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine("************* Jana Křelinová ***************");
    Console.WriteLine("************** 013.11.2025 ******************");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine();


    Console.Write("Zadajte počet čísel (celé číslo): ");
    int n;
    while (!int.TryParse(Console.ReadLine(), out n))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte počet čísel znovu");
    }

    Console.Write("Zadajte dolní mez (celé číslo): ");
    int lowerBound; //dolní mez
    while (!int.TryParse(Console.ReadLine(), out lowerBound))
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

    for (int i = 0; i < n; i++)
    {
        myRandNumbs[i] = myRandNumb.Next(lowerBound, upperBound);
        Console.Write("{0}; ", myRandNumbs[i]);
    }

    //Hledání maxima, pozice maxima, minima, pozice minima


    int max = myRandNumbs[0];
    int min = myRandNumbs[0];
    int posMax = 0;
    int posMin = 0;

    //7; 5; 9
    for (int i = 1; i < n; i++) //můžu nechat i nulu, jedna je efektivnější - porovnáváme dva prvky mezi sebou, ne jen jeden
    {
        if (myRandNumbs[i] > max)  //5 > 7 -- nepravda, akce se neprovede, 9 > 7 -- napíše se 9 do max
        {
            max = myRandNumbs[i];
            posMax = i;
        }

        if (myRandNumbs[i] < min) //5 < 7 --pravda -- 5 se zapíše do min
        {
            min = myRandNumbs[i];
            posMin = i;
        }
    }

    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine($"Maximum: {max}: ");
    Console.WriteLine($"Pozice maxima {posMax}: ");
    Console.WriteLine($"Minimum: {min}: ");
    Console.WriteLine($"Pozice minima {posMin}: ");
    Console.WriteLine();
    Console.WriteLine();

    //Vykreslování přesýpacích hodin

    if (max >= 3)
    {
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine($"Přesýpací hodiny o velikosti: {max}");
        Console.WriteLine();
        Console.WriteLine();

        //Tento cyklus se stará o to, aby se vykreslil správný počet řádků
        for (int i = 0; i < max; i++) //kdyby i = 1, potom i <= max
        {
            int spaces, stars;
            if (i < max / 2)
            {
                //počet mezer v i-tém řádku - horní polovina
                spaces = i;

                //počet hvězd - horní polovina - s každým řádkem ubývají 2 *
                stars = max - 2 * i; //10 -2*0, 10 - 2*2

            }

            else
            {
                //dolní polovina - počet mezer v i-tém řádku
                spaces = max - i - 1; //začínáme od 0 -- proto odečítám 1
                if (max % 2 == 1)
                {
                    stars = 2 * (i - max / 2) + 1; //řádek - polovina maxima + 1 
                }
                else
                {
                    stars = 2 * (i - max / 2) + 2;
                }
            }

            Console.ForegroundColor = ConsoleColor.DarkRed;

            //Vykreslení mezer pro každý řádek
            for (int sp = 0; sp < spaces; sp++)
                Console.Write(" ");

            //Vykreslení hvezdiček 
            for (int st = 0; st < stars; st++)
                Console.Write("*");

            Console.WriteLine();

        }
        
        Console.ResetColor();

    }
    else
    {
        Console.WriteLine("Maximum je menší než 3 => obrazec se nebude vykreslovat!!");
    }

    //počet max a min

    int pocetMax = 0;
    int pocetMin = 0;
   

    for(int j = 0; j < n; j++)
    {
        if (myRandNumbs [j] == max)
        {
            pocetMax++;
        }

        if(myRandNumbs [j] == min)
        {
            pocetMin++;
        }
    }

    Console.WriteLine();
    Console.WriteLine($"Počet maximalích hodnot: {pocetMax}");
    Console.WriteLine($"Počet minimálních hodnot: {pocetMin}");
    Console.WriteLine();







    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();

}


