using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F2 {

    internal class f2_02_sportka_bez_duplicit {

        public static void Mainx() {
            //2) Stroj na losování Sazky se porouchal.
            //Tahal sice z osudí čísla 1 až 49, ale některá opakovaně.
            //Vytvořte funkci, které se předá pole takovýchto čísel, funkce pole vrátí očištěné od druhých a dalších výskytů opakujících se čísel(pro jednoduchost stačí, aby na jejich místě dosadila nulu).
            //Nevadí, že tedy může být ve výsledku méně čísel než požadovaných pět.
            static int[] SportkaBezDuplicit(int[] poleVylosovanychCisel) {
                int cislo = 0;
                for (int i = 0; i < poleVylosovanychCisel.Length; i++) {
                    for (int j = 0;j < poleVylosovanychCisel.Length;j++) {
                        if (i != j & poleVylosovanychCisel[i] == poleVylosovanychCisel[j]) {
                            poleVylosovanychCisel[i] = 0;
                        }
                    }
                    
                }
                return poleVylosovanychCisel;
            }
            Random rnd = new Random();
            int[] vylosovanaCisla = new int[5];
            for (int i = 0; i < 5; i++) {
                vylosovanaCisla[i] = rnd.Next(1, 50);
            }
            int[] vylosovanaCislaBezDuplicit = new int[5];
            vylosovanaCislaBezDuplicit = SportkaBezDuplicit(vylosovanaCisla);

            foreach (int i in vylosovanaCislaBezDuplicit) {
                Console.WriteLine($"Vylosované číslo {i}");
            }
        }
    }
}