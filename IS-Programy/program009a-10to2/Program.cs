string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("*************************************************************");
    Console.WriteLine("**** Převod z desítkové do binární (dvojkové) soustavy*******");
    Console.WriteLine("*************************************************************");
    Console.WriteLine("*************************************************************");
    Console.WriteLine("******************* Jana Křelinová **************************");
    Console.WriteLine("******************** 27.11.2025 ******************************");
    Console.WriteLine("*************************************************************");
    Console.WriteLine("*************************************************************");
    Console.WriteLine();


    Console.Write("Zadejte desítkové číslo (přirozené číslo): ");
    uint number10;
    while (!uint.TryParse(Console.ReadLine(), out number10)) 
    {
        Console.Write("Nezadali jste přirozené číslo. Zadejte desítkové číslo znovu: ");
    }

    // 123 / 2 = 61 (1)  !!!zbytky zapisuju zprava!!!
    // 61 / 2 = 30 (1)
    // 30 / 2 = 15 (0)
    // 15 / 2 = 7 (1)
    // 7 / 2 = 3 (1)
    // 3 / 2 = 1 (1)
    // 1 / 2 = 0 (1) -----> 1111011

    uint[] myArray = new uint [32]; //32 buňek pole :) - abych převedla max možnou hodnotu
    uint backupNumber10 = number10;
    uint zbytek;

    uint i;
    for(i = 0; number10 > 0; i++)
    {
        zbytek = number10 % 2;
        number10 = (number10 - zbytek)/2;
        myArray[i] = zbytek;

        Console.WriteLine("Celá část: {0}; zbytek: {1}", number10, zbytek);
    }

    Console.Write("Desítkové číslo {0}: ", backupNumber10);
    for (uint j = i - 1 ; j >= 0; j--)
    {
        Console.Write("{0}", myArray[j]);
    }

    

    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();

}

