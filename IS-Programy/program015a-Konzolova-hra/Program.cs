using System;

namespace KonzolovaHra
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Clear();
            Console.WriteLine("********************************************");
            Console.WriteLine("************** Konzolová hra ***************");
            Console.WriteLine("********************************************");
            Console.WriteLine("********************************************");
            Console.WriteLine("************* Jana Křelinová ***************");
            Console.WriteLine("************** 02.01.2026 ******************");
            Console.WriteLine("********************************************");
            Console.WriteLine("********************************************");
            Console.WriteLine();
            Console.ResetColor();

            // Inicializace proměnných pro skóre
            int skoreHrac = 0;
            int skorePocitac = 0;
            string[] volby = { "Kámen", "Nůžky", "Papír" };
            Random nahoda = new Random(1);

            Console.WriteLine("=== VÍTEJ VE HŘE KÁMEN, NŮŽKY, PAPÍR ===");
            Console.WriteLine("Hrajeme, dokud někdo nezíská 3 body.");

            // Hlavní herní smyčka - běží, dokud někdo nevyhraje 3x
            while (skoreHrac < 3 && skorePocitac < 3)
            {
                Console.WriteLine($"\nSTAV: Hráč {skoreHrac} - {skorePocitac} Počítač");
                Console.Write("Vyber (0-Kámen, 1-Nůžky, 2-Papír): ");

                // Ošetření vstupu - TryParse zajistí, že program nespadne při zadání písmene
                if (!int.TryParse(Console.ReadLine(), out int volbaHrace) || volbaHrace < 0 || volbaHrace > 2)
                {
                    Console.WriteLine("Neplatná volba! Zadej číslo 0, 1 nebo 2.");
                    continue; // Skočí zpět na začátek smyčky
                }

                int volbaPocitace = nahoda.Next(0, 3);
                Console.WriteLine($"-> Tvůj výběr: {volby[volbaHrace]}");
                Console.WriteLine($"-> Výběr počítače: {volby[volbaPocitace]}");

                // Vyhodnocení kola
                if (volbaHrace == volbaPocitace)
                {
                    Console.WriteLine("VÝSLEDEK: Remíza!");
                }
                else if ((volbaHrace == 0 && volbaPocitace == 1) || 
                         (volbaHrace == 1 && volbaPocitace == 2) || 
                         (volbaHrace == 2 && volbaPocitace == 0))
                {
                    Console.WriteLine("VÝSLEDEK: Bod pro tebe!");
                    skoreHrac++;
                }
                else
                {
                    Console.WriteLine("VÝSLEDEK: Bod pro počítač!");
                    skorePocitac++;
                }
            }

            // Konec hry
            Console.WriteLine("\n==============================");
            if (skoreHrac == 3){
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("GRATULUJI! Vyhrál jsi celou hru!");
                Console.ResetColor();
                }

            else{
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("BOHUŽEL! Počítač byl tentokrát lepší.");
                Console.ResetColor();
                }
            Console.WriteLine("Stiskni libovolnou klávesu pro ukončení...");
            Console.ReadKey();
        }
    }
}