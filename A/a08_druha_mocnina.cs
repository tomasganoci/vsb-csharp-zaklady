using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.FileIO;

namespace A {

    internal class a08_druha_mocnina {

        public static void Mainx() {
            //a8) Zadejte číslo, počítač vypíše: Druhá mocnina čísla… je...  (příliš lehké)

            double zadaneCislo;

            Console.WriteLine("Zadejte číslo, počítač vypíše: Druhá mocnina čísla… je...  (příliš lehké)");
            Console.WriteLine("Zadejte číslo a já Vám napíšu, jaká je jeho druhá mocnina.");
            zadaneCislo = double.Parse(Console.ReadLine());

            Console.WriteLine($"Druhá mocnina čísla {zadaneCislo} je {Math.Pow(zadaneCislo, 2.0)}");
        }

        public static void Mainx_reseni() {
            //Řešení:
            //a08: Zadejte číslo, počítač vypíše: Druhá mocnina čísla... je...

            float cislo;
            Console.WriteLine("zadej číslo : ");
            cislo = float.Parse(Console.ReadLine());
            Console.WriteLine($"Druhá mocnina čísla {cislo} je {Math.Pow(cislo, 2)}");
        }
    }
}