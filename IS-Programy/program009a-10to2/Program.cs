string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("*************************************************************");
    Console.WriteLine("**** Převod z desítkové do binární (dvojkové) soustavy*******");
    Console.WriteLine("*************************************************************");
    Console.WriteLine("******************* Jana Křelinová **************************");
    Console.WriteLine("******************** 27.11.2025 ******************************");
    Console.WriteLine("*************************************************************");
    Console.WriteLine();

    Console.Write("Zadejte desítkové číslo (přirozené číslo): ");
    uint number10;
    while (!uint.TryParse(Console.ReadLine(), out number10))
    {
        Console.Write("Nezadali jste přirozené číslo. Zadejte desítkové číslo znovu: ");
    }

    uint[] myArray = new uint[32]; 
    uint backupNumber10 = number10;
    uint zbytek;

    // Speciální případ pro nulu
    if (number10 == 0)
    {
        Console.WriteLine("Desítkové číslo 0: 0");
    }
    else
    {
        int i = 0; 
        while (number10 > 0)
        {
            zbytek = number10 % 2;
            myArray[i] = zbytek;
            number10 = number10 / 2; 

            Console.WriteLine("Celá část po dělení: {0}; zbytek: {1}", number10, zbytek);
            i++;
        }

        Console.Write("Desítkové číslo {0} binárně: ", backupNumber10);
        
        
        for (int j = i - 1; j >= 0; j--)
        {
            Console.Write("{0}", myArray[j]);
        }
    }

    Console.WriteLine();
    Console.WriteLine("\nPro opakování programu stiskněte klávesu 'a'");
    again = Console.ReadLine(); 
}