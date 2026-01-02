string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("*************************************************************");
    Console.WriteLine("************ Převod z desítkové do jakékoli soustavy*********");
    Console.WriteLine("*************************************************************");
    Console.WriteLine("*************************************************************");
    Console.WriteLine("******************* Jana Křelinová **************************");
    Console.WriteLine("******************** 27.12.2025 *****************************");
    Console.WriteLine("*************************************************************");
    Console.WriteLine("*************************************************************");
    Console.WriteLine();


    Console.Write("Zadejte desítkové číslo (přirozené číslo): ");
    uint number10;
    while (!uint.TryParse(Console.ReadLine(), out number10)) 
    {
        Console.Write("Nezadali jste přirozené číslo. Zadejte desítkové číslo znovu: ");
    }
    
    
    uint cislo = number10;

    string binarne = Convert.ToString(cislo, 2);  // např. "1010"
    string osmickove = Convert.ToString(cislo, 8); // např. "12"
    string sestnactkove = Convert.ToString(cislo, 16); // např. "a"

    Console.WriteLine($"Převod čísla do binární soustavy: {binarne}, osmičkové: {osmickove} a šestnáctkové: {sestnactkove}");

    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();

    }