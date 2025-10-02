
string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("**********************************");
    Console.WriteLine("********Výpis číselné řady********");
    Console.WriteLine("**********************************");
    Console.WriteLine("********Jana Křelinová************");
    Console.WriteLine("*********02.10.2025***************");
    Console.WriteLine("**********************************");
    Console.WriteLine();

    //Vstup hodnoty do programu, ale špatně řešený
    //Console.Write("Zadejte první čislo řady")
    //int first = int.Parse(Console.ReadLine());

    //Vstup do programu řešený lépe
    Console.Write("Zadejte první číslo řady(celé číslo)")
    int first;
    while (!int.TryParse(Console.ReadLine(), out first))
    {
        Console.WriteLine("Nezadali jste celé číslo. Zadejte první číslo řady znovu")

    }

    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();

}



