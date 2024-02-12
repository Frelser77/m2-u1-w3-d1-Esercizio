using System;
using System.Collections.Generic;

namespace Esercizio_console_Menu
{
    internal static class Menu
    {
        private static readonly List<(string Nome, decimal Prezzo)> opzioniMenu = new List<(string, decimal)>
        {
            ("Coca Cola 150 ml", 2.50m),
            ("Insalata di pollo", 5.20m),
            ("Pizza Margherita", 10.00m),
            ("Pizza 4 Formaggi", 12.50m),
            ("Pz patatine fritte", 3.50m),
            ("Insalata di riso", 8.00m),
            ("Frutta di stagione", 5.00m),
            ("Pizza fritta", 5.00m),
            ("Piadina vegetariana", 6.00m),
            ("Panino Hamburger", 7.90m),
        };

        private static readonly List<(string Nome, int Quantita, decimal PrezzoTotale)> riepilogoOrdini = new List<(string, int, decimal)>();

        public static void PrintMenu()
        {
            Console.WriteLine("==============MENU==============");
            for (int i = 0; i < opzioniMenu.Count; i++)
            {
                Console.WriteLine($"{i + 1}: {opzioniMenu[i].Nome}(€ {opzioniMenu[i].Prezzo})");
            }
            Console.WriteLine("11: Stampa conto finale e conferma");
            Console.WriteLine("==============MENU==============");
        }

        public static void GetUserSelection()
        {
            bool isOrdering = true;
            decimal total = 0.00m;

            while (isOrdering)
            {
                Console.Write("Seleziona un'opzione (1-11): ");
                if (int.TryParse(Console.ReadLine(), out int choice))
                {
                    if (choice >= 1 && choice <= 10)
                    {
                        var selezione = opzioniMenu[choice - 1];
                        var indice = riepilogoOrdini.FindIndex(x => x.Nome == selezione.Nome);
                        if (indice != -1)
                        {
                            var ordineEsistente = riepilogoOrdini[indice];
                            riepilogoOrdini[indice] = (ordineEsistente.Nome, ordineEsistente.Quantita + 1, ordineEsistente.PrezzoTotale + selezione.Prezzo);
                        }
                        else
                        {
                            riepilogoOrdini.Add((selezione.Nome, 1, selezione.Prezzo));
                        }
                        total += selezione.Prezzo;
                    }
                    else if (choice == 11)
                    {
                        Console.WriteLine("\nRiepilogo del tuo ordine:");
                        foreach (var ordine in riepilogoOrdini)
                        {
                            Console.WriteLine($"{ordine.Nome}: {ordine.Quantita}x - Totale: €{ordine.PrezzoTotale}");
                        }
                        total += 3.00m; // Servizio al tavolo
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"Servizio al tavolo: €3.00");
                        Console.WriteLine($"Totale ordine: €{total}");
                        isOrdering = false;
                        Console.ResetColor();
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Opzione non valida. Riprova.");
                    }
                }
                else
                {
                    Console.WriteLine("Input non valido. Inserisci un numero.");
                }
            }
        }
    }
}
