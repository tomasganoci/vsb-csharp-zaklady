using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.FileIO;

namespace B {

    internal class b10_odmocnina_zaporu {

        public static void Mainx() {
            //b10) Zadejte číslo. Počítač vypíše: "Odmocnina čísla ... je  ..." nebo oznámí, že odmocninu záporného čísla počítat nebude.
            //moje poznámky: spletl jsem si odmocninu a mocninu, tak jsem místo 0.5 dal 2, do podmínkyj sme dal i 0, nevím jestli to je špatně nebo dobře.

            float zadaneCislo;

            Console.WriteLine("Zadejte číslo a já ti napíšu, jaká je jeho odmocnina");
            zadaneCislo = float.Parse(Console.ReadLine());

            if (zadaneCislo <= 0) {
                Console.WriteLine("Odmocninu z 0 nebo záporného čísla počítat nebudu!");
            }
            else {
                Console.WriteLine($"Odmocnina čísla {zadaneCislo} je {Math.Sqrt(zadaneCislo)}");
            }
        }

        public static void Mainx_reseni() {
            //Řešení:
            //
            //b10: Zadejte číslo.Počítač vypíše: "Odmocnina čísla ... je  ..." nebo oznámí,
            //že odmocninu záporného čísla počítat nebude.

            float c;
            Console.WriteLine("zadej cislo:");
            c = float.Parse(Console.ReadLine());
            if (c < 0) {
                Console.WriteLine("Zaporne cilo pocitat nebudu");
            }
            else {
                Console.WriteLine($"odmocnina čísla {c} je {Math.Pow(c, 0.5)}");
            }
        }
    }
}