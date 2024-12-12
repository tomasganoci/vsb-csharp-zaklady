using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B {

    internal class b17_konverze_meny {

        public static void Mainx() {
            //17) Zadejte částku v Kč a pak si z nabídky vyberte měnu, na kterou chcete směnit (např. DEM, USD, FRF atd.). Počítač přepočítá částku na tuto měnu.

            Console.WriteLine("Zadejte částku a měnu a já ti to přepočítám.");
            Console.WriteLine("Dostupné měny: EUR, PLN, USD");
            Console.Write("Zadejte částku:");
            double zadanaCastka = double.Parse(Console.ReadLine());
            Console.Write("Zadejte měnu:");
            string zadanaMena = Console.ReadLine();
            double konverze = 0.0;

            switch (zadanaMena.ToLower()) {
                case "eur":
                    konverze = 25.0;
                    break;

                case "pln":
                    konverze = 5.0;
                    break;

                case "usd":
                    konverze = 20.0;
                    break;

                default:
                    konverze = 0.0;
                    break;
            }
            if (konverze != 0.0)
                Console.WriteLine($"Za částku {zadanaCastka:c} dostaneš {zadanaCastka / konverze} {zadanaMena.ToUpper()}.");
            else
                Console.WriteLine("Tuto měnu neznám");
        }
    }
}