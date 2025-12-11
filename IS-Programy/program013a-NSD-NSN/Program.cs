string again = "a";
while (again == "a")
{
    Console.Clear();
    //metoda pro výpis hlavičky/razítka
    razitko();

    ulong a = nactiCislo("Zadejte číslo a: "); //je to string = řetězec
    ulong b = nactiCislo("Zadejte číslo b: ");

    ulong nsd = vypocitatNSD(a, b);
    ulong nsn = vypocitatNSN(a, b, nsd);
    
    zobrazVysledky(a, b, nsd, nsn);

    

   


    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();

}


static void razitko()
{
    Console.WriteLine("********************************************");
    Console.WriteLine("************** NSD a NSN *******************");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine("************* Jana Křelinová ***************");
    Console.WriteLine("************** 11.12.2025 ******************");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine();

}

static ulong nactiCislo(string zprava) //při ulong mi ta metoda musí něco vracet - return
{
     Console.Write(zprava);
    ulong cislo;
    while (!ulong.TryParse(Console.ReadLine(), out cislo)) 
    {
        Console.Write("Nezadali jste přirozené číslo. Zadejte číslo znovu: ");
    }

    return cislo;
}

static ulong vypocitatNSD(ulong a, ulong b)
{
    while (a != b)
    {
        if(a > b)
            a = a - b;
        else 
            b = b - a;
    } 
    return a;
}

static void zobrazVysledky(ulong a, ulong b, ulong nsd, ulong nsn)
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine();
    Console.WriteLine("=====================");
    Console.WriteLine($"Největší společný dělitel čísel {a} a {b} je {nsd}");
    Console.ForegroundColor = ConsoleColor.White;

    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine();
    Console.WriteLine("=====================");
    Console.WriteLine($"Nejmenší společný násobek čísel {a} a {b} je {nsn}");
    Console.ForegroundColor = ConsoleColor.White;
    
}

static ulong vypocitatNSN(ulong a, ulong b, ulong nsd)
{
    return (a*b)/nsd;
}


