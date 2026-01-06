string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("********************************************");
    Console.WriteLine("************* Kombinovaná úloha ************");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine("************* Jana Křelinová ***************");
    Console.WriteLine("************** 29.12.2025 ******************");
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

    Console.WriteLine();
    int max = myRandNumbs[0];
    int min = myRandNumbs[0];
    

    for(int i = 0; i < n ; i++)
    {
        if(myRandNumbs[i] > max)
        {
        max = myRandNumbs[i];
        }

        if(myRandNumbs[i]< min)

        {
            min = myRandNumbs[i];
        }
    }

    
    Console.WriteLine($"Maximum: {max}");
    Console.Write("Pozice maxim: ");

    for(int i = 0; i < n; i++)
    {
        if(myRandNumbs[i]== max)
        Console.Write(i + " ");
        
    }
    Console.WriteLine();

    Console.WriteLine($"Minimum: {min}");
    Console.Write("Pozice minim: ");

    for(int i = 0; i < n; i++)
    {
        if(myRandNumbs[i]==min)
        Console.Write(i + " ");
    }
    Console.WriteLine();

    //selection sort

    for(int i = 0; i < n - 1; i++)
    {
        int maxIndex = i;

        for(int j = i + 1; j < n; j++)
        {
            if(myRandNumbs[j] > myRandNumbs[maxIndex])
            {
                maxIndex = j;
            }
        }

        int tmp = myRandNumbs[maxIndex];
        myRandNumbs[maxIndex] = myRandNumbs[i];
        myRandNumbs[i] = tmp;

    }


    Console.Write("Seřazené pole: ");
    for(int i = 0; i < n; i++)
    {
        Console.Write("{0} ", myRandNumbs[i]);
    }
    

    //druhé, třetí, čtvrté největší
    Console.WriteLine();

    int secondMax = max;
    for(int i = 0; i < n; i++)
    {
        if (myRandNumbs[i] < max)
        {
            secondMax = myRandNumbs[i];
            break;
        }
    }

    int thirdMax = secondMax;
    for(int i = 0; i < n; i++)
    {
        if(myRandNumbs[i] < secondMax)
        {
            thirdMax = myRandNumbs[i];
            break;
        }
    }

    int fourMax = thirdMax;
    for(int i = 0; i < n; i++)
    {
        if(myRandNumbs[i] < thirdMax)
        {
            fourMax = myRandNumbs[i];
            break;
        }
    }

    Console.WriteLine($"Druhé největší číslo {secondMax}, třetí {thirdMax}, čtvrté {fourMax}");
    
    //medián
    double median;
    if(n % 2 == 0)
    {   
        median = (myRandNumbs[(n/2)-1]+myRandNumbs[(n/2)])/2.0;
    }
    else
    {       
        median = myRandNumbs[(n/2)];
    }

    Console.WriteLine("Medián: {0}", median);

    //prumer

    double soucet = 0;

    for(int i = 0; i < n; i++)
    {
        soucet += myRandNumbs[i];
    }

    double prumer = soucet / n;

    Console.WriteLine($"Aritmerický průměr je: {prumer}");

    //10to2
 // string binarni = Convert.ToString(fourMax, 2);
  //Console.WriteLine($"Desítkové číslo {fourMax} převedené do binární soustavy je: {binarni}");

    int cislo = fourMax;
    string vysledek = "";

    if(cislo == 0)
    {
        vysledek = "0";
    }

    while(cislo > 0)
    {
        int zbytek = cislo % 2;
        vysledek = zbytek + vysledek;
        cislo = cislo / 2;
    }

   Console.WriteLine($"Desítkové číslo {fourMax} převedené do binární soustavy je: {vysledek}");


    int sirka = (int)thirdMax;
    int vyska = (int)median;

    for(int i = 0; i < vyska; i++)
    {
        for(int j = 0; j < sirka; j++)
        {
            if((i >= vyska/3 && i < 2*vyska/3) || (j >= sirka/3 && j < 2* sirka/3))
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
