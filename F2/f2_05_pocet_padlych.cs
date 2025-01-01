using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F2 {

    internal class f2_05_pocet_padlych {

        public static void Mainx() {
            //5) Sestavte funkci PocetPadlych, která kromě předaného pole má i parametr, kolikrát se kostkou hodilo.
            //Výsledkem funkce je jednorozměrné celočíselné pole udávající, kolikrát padla ta která hodnota na kostce.
            //Funkci ověřte na zadání: sestavte program, který se zeptá na počet hodů, vygeneruje pole a pak zobrazí, kolikrát každé číslo padlo.
            //Povšimněte si, že čím více hodů, tím více se počty vyrovnají(podobné e9, ale zde je to s použitím funkce)
            //Moje poznámky: už se mi tím nechce déle zdržovat, ale funkci bych asi převedl tak, aby byla univeerzálnější a nepočítala pouze s hrací kostkou.
            static int[] PocetPadlych(int[] poleHodu, int pocetHodu) {
                int[] vysledkyFunkce = new int[7];
                for (int i = 0; i < pocetHodu; i++) {
                    switch (poleHodu[i]) {
                        case 1: vysledkyFunkce[0]++; break;
                        case 2: vysledkyFunkce[1]++; break;
                        case 3: vysledkyFunkce[2]++; break;
                        case 4: vysledkyFunkce[3]++; break;
                        case 5: vysledkyFunkce[4]++; break;
                        case 6: vysledkyFunkce[5]++; break;
                        default: vysledkyFunkce[6]--; break;
                    }
                }
                return vysledkyFunkce;
            }
            Random rnd = new Random();
            int[] pole = new int[100];
            int[] vysledky;
            int pocet = 0;

            Console.WriteLine("Zadej počet hodů (max. 100) kostkou a já ti vypíšu statistiku");
            pocet = int.Parse(Console.ReadLine());
            Console.WriteLine();
            for (int i = 0; i < pocet; i++) {
                pole[i] = rnd.Next(1, 7);
            }
            vysledky = PocetPadlych(pole, pocet);

            for (int i = 0; i < vysledky.Length; i++) {
                if (i == 6) {
                    Console.WriteLine($"Mimo rozsah 1-6: {vysledky[6]}x");
                    break;
                }
                Console.WriteLine($"Počet výskytů čísla {i + 1}: {vysledky[i]}x");
            }
        }

        public static void Mainx_reseni() {
            Console.WriteLine("kolikrat mam hodit kostkou?");
            int kolikrat = int.Parse(Console.ReadLine());
            int[] zF = new int[7];
            Console.WriteLine("Padla cisla:");
            zF = padlo(kolikrat);                           //POZOR, vracim-li pole z funkce je potreba nejdrive naplnit pole, ktere jsem si vytvoril pro naplneni z funkce. ZF
            for (int i = 1; i < 7; i++) {
                Console.WriteLine("cislo {0} padlo celkem {1}x", i, zF[i]);
            }
        }

        private static int[] padlo(int kolikratF) {
            Random r = new Random();
            int[] polepoctu = new int[7];
            int hod = 0;
            for (int i = 0; i <= kolikratF; i++) {
                hod = r.Next(1, 7);
                polepoctu[hod]++;
            }
            return polepoctu;
        }
    }
}