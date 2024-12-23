using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.FileIO;

namespace D {

    internal class d03_linearni_posloupnost {

        public static void Mainx_reseni_do_while() {
            //Řešení:

            //d03: Zadejte první, druhy a poslední člen lineární celočíselné posloupnosti.
            //Program vytiskne pod sebou všechny prvky posloupnosti.

            int prvni, druhy, posledni, rozdil, dalsiCislo;
            string s;

            Console.WriteLine("Zadej 1 cislo posloupnosti");
            prvni = int.Parse(Console.ReadLine());
            Console.WriteLine("Zadej 2 cislo posloupnosti");
            druhy = int.Parse(Console.ReadLine());
            Console.WriteLine("Zadej posledni cislo posloupnosti");
            posledni = int.Parse(Console.ReadLine());
            rozdil = druhy - prvni;
            dalsiCislo = druhy;
            s = $"{prvni}\n{druhy}\n";
            do {
                dalsiCislo += rozdil;
                s += $"{dalsiCislo}\n";
            }
            while ((dalsiCislo + rozdil) <= posledni);

            if (dalsiCislo != posledni) {
                s = $"Koncové číslo {posledni} neni součástí linearni posloupnosti\n";
            }
            Console.WriteLine($"{s}Lineární řada čísel {prvni}, {druhy} ..{posledni}");
        }

        public static void Mainx() {
            //3) Zadejte první, druhy a poslední člen lineární celočíselné posloupnosti (lineární posloupnost je taková, kde mezi jednotlivými členy jsou stejné odstupy, např. 12, 15, 18, 21...).
            //Program zobrazí pod sebou všechny prvky posloupnosti.
            //Pozn.: program musí fungovat, i kdyby třetí zadané číslo se nestrefilo do členů posloupnosti (tedy kdyby toto číslo nebylo v posloupnosti obsaženo).
            //Takže je to třeba chápat spíše tak, že třetí zadané číslo je limit.
            //Varianta: Zadá se první a druhy krok a počet prvku posloupnosti.
            //Moje poznámky: trochu jinak jsem pochopil zadání, myslel jsem že druhé číslo značí lineární posloupnost.

            int prvniCislo, druheCislo, posledniCislo, linearniPosloupnost;
            string posloupnoststring;

            Console.WriteLine("Zadejte první číslo lineární posloupnosti");
            prvniCislo = int.Parse(Console.ReadLine());
            Console.WriteLine("Zadejte druhé číslo lineární posloupnosti");
            druheCislo = int.Parse(Console.ReadLine());
            Console.WriteLine("Zadejte poslední číslo lineární posloupnosti");
            posledniCislo = int.Parse(Console.ReadLine());

            posloupnoststring = $"Číslo: {prvniCislo} posloupnost: {druheCislo}\n";
            linearniPosloupnost = prvniCislo + druheCislo;
            while (linearniPosloupnost > posledniCislo) {
                posloupnoststring += $"Číslo: {linearniPosloupnost}\n";
                linearniPosloupnost = linearniPosloupnost + druheCislo;
            }

            Console.WriteLine(posloupnoststring);
        }

        public static void Mainx_reseni() {
            //Řešení:

            //d03: Zadejte první, druhy a poslední člen lineární celočíselné posloupnosti.
            //Program vytiskne pod sebou všechny prvky posloupnosti.

            int prvni, druhy, posledni, rozdil, dalsiCislo;
            string s;

            Console.WriteLine("Zadej 1 cislo posloupnosti");
            prvni = int.Parse(Console.ReadLine());
            Console.WriteLine("Zadej 2 cislo posloupnosti");
            druhy = int.Parse(Console.ReadLine());
            Console.WriteLine("Zadej posledni cislo posloupnosti");
            posledni = int.Parse(Console.ReadLine());
            rozdil = druhy - prvni;
            dalsiCislo = druhy;
            s = $"{prvni}\n{druhy}\n";

            while ((dalsiCislo + rozdil) <= posledni) {
                dalsiCislo = dalsiCislo + rozdil;
                s += $"{dalsiCislo}\n";
            };

            if (dalsiCislo != posledni) {
                s = $"Koncové číslo {posledni} neni součástí linearni posloupnosti\n";
            }
            Console.WriteLine($"{s}Lineární řada čísel {prvni}, {druhy} ..{posledni}");
        }

        public static void Mainx_reseni_b() {
            //d03b: Zadejte první, druhy a poslední člen lineární posloupnosti.
            //Program vytiskne pod sebou všechny prvky posloupnosti.
            //Varianta b: Zadá se první a druhy krok a počet prvku posloupnosti.

            int prvni, druhy, pocetCisel, rozdil, dalsiCislo, i;

            string s;

            i = 2;
            Console.WriteLine("Zadej 1 cislo posloupnosti");
            prvni = int.Parse(Console.ReadLine());
            Console.WriteLine("Zadej 2 cislo posloupnosti");
            druhy = int.Parse(Console.ReadLine());
            Console.WriteLine("Zadej pocet cisel posloupnosti");
            pocetCisel = int.Parse(Console.ReadLine());

            rozdil = druhy - prvni;
            dalsiCislo = druhy;
            s = $"{prvni}\n{druhy}\n";

            do {                                    //toto by bylo vhodnější řešit pomocí for, neboť je počet průchodů smyčkou znám
                dalsiCislo = dalsiCislo + rozdil;

                s += $"{dalsiCislo}\n";

                i = i + 1;
            } while (i < pocetCisel);

            Console.WriteLine($"Lineární řada pro {pocetCisel} cisel začínajících na {prvni}, {druhy} je:\n{s}");
        }
    }
}