using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.FileIO;

namespace A {

    internal class a10_radiany_na_stupne {

        public static void Mainx() {
            //a9) Z klávesnice se zadá očekávaný a skutečný příjem. Počítač oznámí, kolika procent bylo dosaženo.

            double ocekavanyPrijem, skutecnyPrijem;

            Console.WriteLine("Zadejte, jaký očekáváte finanční příjem.");
            ocekavanyPrijem = double.Parse(Console.ReadLine());
            Console.WriteLine("Zadejte, jaký je Váš skutečný finanční příjem.", "Skutečný finanční příjem");
            skutecnyPrijem = double.Parse(Console.ReadLine());

            Console.WriteLine($"Bylo dosaženo {skutecnyPrijem / ocekavanyPrijem * 100} % očekavaných finančních příjmů.");
        }

        public static void Mainx_reseni() {
            //Řešení:
            //a09: Z klávesnice se zadá očekávaný a skutečný příjem.
            //Počítač oznámí, kolika procent bylo dosaženo.

            float ocek, skut;
            Console.WriteLine("zadej ocekavany příjem (Kč): ");
            ocek = float.Parse(Console.ReadLine());
            Console.WriteLine("zadej skutecny příjem (Kč): ");
            skut = float.Parse(Console.ReadLine());
            Console.WriteLine($"Plán byl splněn na  {skut / ocek * 100} % ");
        }
    }
}