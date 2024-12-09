using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A {
    internal class a03_prumerna_teplota {
        public static void Mainx() {
            //a3) Zadejte teplotu v 6, 12 a 18 hodin. Zobrazí se průměrná denní teplota.
            float teplotaV6h, teplotaVe12h, teplotaV18h, prumernaTeplota;

            Console.WriteLine("Zadejte teplotu v 6, 12 a 18 hodin. Zobrazí se průměrná denní teplota.");
            Console.WriteLine("Zadej teplotu v °C, která byla v 6h");
            teplotaV6h = float.Parse(Console.ReadLine());
            Console.WriteLine("Zadej teplotu v °C, která byla ve 12h", "Teplota ve 12h");
            teplotaVe12h = float.Parse(Console.ReadLine());
            Console.WriteLine("Zadej teplotu °C, která byla v 18h", "Teplota v 18h");
            teplotaV18h = float.Parse(Console.ReadLine());
            prumernaTeplota = (teplotaV6h + teplotaVe12h + teplotaV18h) / 3;
            Console.WriteLine($"Průměrná teplota dnešního dne je {prumernaTeplota} °C.");
        }
        public static void Mainx_reseni() {
            //Řešení:
            //a03: Zadejte teplotu v 6,12 a 18 hodin.Vytiskne se průměrná denní teplota.
            float t6, t12, t18;
            Console.WriteLine("zadej teplotu v 6h(°C): ");
            t6 = float.Parse(Console.ReadLine());
            Console.WriteLine("zadej teplotu v 12h(°C): ");
            t12 = float.Parse(Console.ReadLine());
            Console.WriteLine("zadej teplotu v 18h (°C): ");
            t18 = float.Parse(Console.ReadLine());
            Console.WriteLine($"Prumerna deni teplota je: {(t6 + t12 + t18) / 3} °C");
        }
    }
}
