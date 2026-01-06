using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Reflection;

string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("********************************************");
    Console.WriteLine("************** Vlastní zadání **************");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine("************* Jana Křelinová ***************");
    Console.WriteLine("************** 06.01.2025 ******************");
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

    for(int i = 0; i < n  ; i++)
    {
        myRandNumbs[i] = myRandNumb.Next(lowerBound, upperBound);
        Console.Write("{0}; ", myRandNumbs[i]);
    }

    Console.WriteLine();
    Console.WriteLine("===============");
    
    int max = myRandNumbs[0];

    for(int i = 0; i < n; i++)
    {
        if(myRandNumbs[i] > max)
        {
            max = myRandNumbs[i];
        }
    }

    Console.WriteLine($"Maximum: {max}");
    Console.Write("Pozice maxim:");

    for(int i = 0; i < n; i++)
    {
        if (myRandNumbs[i] == max)
        {
            Console.Write(i + " ");
        }
    }
    Console.WriteLine();
    Console.WriteLine("===============");
    Console.WriteLine("Seřazené pole:");

    for(int i = 0; i < n; i++)
    {
        int klic = myRandNumbs[i];
        int j = i - 1;

        while(j >= 0 && myRandNumbs[j] < klic)
        {
            myRandNumbs[j+1] = myRandNumbs[j];
            j--;
        }
        
        myRandNumbs[j+1] = klic;
    }

    for(int i = 0; i < n; i++)
    {
        Console.Write("{0} ", myRandNumbs[i]);
    }

    Console.WriteLine();
    Console.WriteLine("===========");
    
    int secondMax = max;
    for(int i = 0; i < n; i++)
    {
        if(secondMax < max)
        {
            secondMax = myRandNumbs[i];
            break;
        }
    }

    int thirdMax = secondMax;
    for(int i = 0; i < n; i++)
    {
        if(thirdMax < secondMax)
        {
            thirdMax = myRandNumbs[i];
            break;
        }
    }

    Console.WriteLine($"Třetí největší číslo je {thirdMax}");

    Console.WriteLine("==============");


    double suma = 0;
    for(int i = 0; i < n; i++)
    {
        suma += myRandNumbs[i];
    }
    double prumer = suma/n;    

    Console.WriteLine("Aritmetický součet je {0}", prumer);

    Console.WriteLine("===================");


    int vyska = (int)prumer + 8;
    int sirka = vyska;

    for(int i = 0; i < vyska; i++)
    {
        for(int j = 0; j < sirka; j++)
        {
            if(i == 0 || i == vyska -1 ||j == 0 || j == sirka - 1|| (j == i) || (j + i == vyska - 1))
            {
                Console.Write("* ");
            }
            else
            {
                Console.Write("  ");
            }
        }
        Console.WriteLine();
    }



    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();

}


