using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F2 {

    internal class f2_10_serazene_cisla {

        public static void Mainx() {
            //10) Obtížné, třídění: Sestavte funkci SerazenePole, která má jediný parametr: pole celých čísel.
            //Výsledkem funkce je jednorozměrné celočíselné pole, ve kterém jsou stejná čísla jako v poli parametru, ale jsou seřazena vzestupně.
            //Funkci ověřte na zadání: sestavte program, který načte pole celých čísel ukončených nulou, která už k číslům nepatří, a pak zobrazí všechna zadaná čísla ve vzestupném pořadí.
            //(obdoba E14, ale třídění proběhne ve funkci)
            static int[] KontrolaVzestupu(int[] pole) {
                int[] vysledek = new int[pole.Length];
                Array.Copy(pole, vysledek, pole.Length);
                int bubble = 0;
                for (int i = 0; i < vysledek.Length; i++) {
                    for (int j = 0; j < vysledek.Length - 1; j++) {
                        if (vysledek[j] > vysledek[j + 1]) {
                            bubble = vysledek[j];
                            vysledek[j] = vysledek[j + 1];
                            vysledek[j + 1] = bubble;
                        }
                    }
                }
                return vysledek;
            }

            int[] zadanaCisla = new int[100];
            int zadaneCislo = 0;
            int pocetPruchodu = 0;

            Console.WriteLine("Zadejte postupne cisla a já ti řeknu jestli jsou vzestupně");
            for (int i = 0; i < zadanaCisla.Length; i++) {
                Console.WriteLine($"Zadejte číslo. Pořadí[{i + 1}] [Ukončete \"0\"]");
                zadaneCislo = int.Parse(Console.ReadLine());
                if (zadaneCislo == 0) {
                    break;
                }
                zadanaCisla[i] = zadaneCislo;
                pocetPruchodu++;
            }

            int[] naplneneCisla = new int[pocetPruchodu];
            int[] serazeneCisla = new int[pocetPruchodu];
            Array.Copy(zadanaCisla, naplneneCisla, pocetPruchodu);
            serazeneCisla = KontrolaVzestupu(naplneneCisla);
            Console.WriteLine();
            foreach (int i in naplneneCisla) {
                Console.WriteLine($"Původní řazení: {i}");
            }
            Console.WriteLine();
            foreach (int i in serazeneCisla) {
                Console.WriteLine($"Seřazené čísla: {i}");
            }
        }

        public static void Mainx_reseni(string[] args) {
            int[] pole = new int[100];
            int cislo = 0, n = 0;
            Console.WriteLine("Zadej pole cisel, ukoncis 0");
            do {
                int.TryParse(Console.ReadLine(), out cislo);
                if (cislo != 0) pole[n++] = cislo;
            }
            while (cislo != 0);
            Console.WriteLine();
            int[] zF = new int[n];
            zF = serazenepole(pole, n);
            for (int i = 0; i < zF.Length; i++) {
                if (zF[i] == 0) break;
                Console.WriteLine("{0}", zF[i]);
            }
        }

        private static int[] serazenepole(int[] poleF, int nF) {
            int k = 0;
            for (int i = 0; i < nF - 1; i++)                //nF-1 aby se nestalo, že bych porovnaval s prazdnym pole, ktere je samozrejme 0
            {
                for (int j = 0; j < nF - 1; j++) {
                    if (poleF[j] > poleF[j + 1]) {                                       //lze samozrejme pouzit metodu Sort tridy Array
                        k = poleF[j];
                        poleF[j] = poleF[j + 1];
                        poleF[j + 1] = k;
                    }
                }
            }
            return poleF;
        }
    }
}