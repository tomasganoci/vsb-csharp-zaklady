using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace F2 {

    internal class f2_04_pocet_vyskytu {

        public static void Mainx() {
            //Programy Doc. Homoly:
            //4) Sestavte funkci PocetVyskytu, která má dva parametry: Prvním je jednorozměrné pole čísel A, druhým je číslo C.
            //Výsledkem funkce je celé číslo udávající, kolikrát se číslo C vyskytuje v poli A.
            //Funkci ověřte na zadání: sestavte program, který postupně načte pole A a hodnotu C, a poté zobrazí počet výskytů hodnoty C v poli A.
            static int PocetVyskytu(int[] poleCisel, int hledatCislo) {
                int pocet = 0;
                for (int i = 0; i < poleCisel.Length; i++) {
                    if (poleCisel[i] == hledatCislo) {
                        pocet++;
                    }
                }
                return pocet;
            }
            int[] pole = new int[100];
            int hledat = 0;
            Random rnd = new Random();
            for (int i = 0; i < pole.Length; i++) {
                pole[i] = rnd.Next(1, 51);
            }
            Console.WriteLine("Vygeneroval jsem 100 čísel s hodnotami od 1-50.\nNapiš, které číslo chceš hledat a já ti vypíšu kolik jich je.");
            hledat = int.Parse(Console.ReadLine());

            Console.WriteLine($"Počet výskytů čísla {hledat} je {PocetVyskytu(pole, hledat)}");
        }

        public static void Mainx_reseni(string[] args) {
            int[] pole = new int[100];
            int c = 0, cislo = 0, n = 0;
            Console.WriteLine("zadej cisla");
            do {
                int.TryParse(Console.ReadLine(), out cislo);
                if (cislo != 0) pole[n++] = cislo;
            }
            while (cislo != 0);
            Console.WriteLine("jake cislo chceš najit?");
            int.TryParse(Console.ReadLine(), out c);
            Console.WriteLine("zadane cislo {0} se zde vyskytuje celkem {1}x", c, najdi(pole, c, n));
        }

        private static int najdi(int[] poleF, int cF, int nF) {
            int p = 0;
            for (int i = 0; i < nF - 1; i++) {
                if (poleF[i] == cF) p++;
            }
            return p;
        }
    }
}