using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F2 {

    internal class f2_08_poruseni_serazeni {

        public static void Mainx() {
            //8) Sestavte program, který nejprve čte řadu čísel ukončených nulou, která už do řady nepatří.
            //Pole se předá funkci, která sdělí, kolikátý prvek v řadě porušuje vzestupné řazení čísel.
            //Pokud je pole celé vzestupné, pak vrátí -1
            static int KontrolaVzestupu(int[] pole) {
                int posledniCislo = int.MinValue;
                for (int i = 0; i < pole.Length; i++) {
                    if (posledniCislo > pole[i]) {
                        return i;
                    }
                    posledniCislo = pole[i];
                }
                return -1;
            }

            int[] zadanaCisla = new int[100];
            int zadaneCislo = 0;
            int pocetPruchodu = 0;
            int jeVzestupne = 0;
            Console.WriteLine("Zadejte postupne cisla a já ti řeknu jestli jsou vzestupně a pokud ne, tak ti vypíšu, které číslo to porušuje");
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
            Array.Copy(zadanaCisla, naplneneCisla, pocetPruchodu);
            jeVzestupne = KontrolaVzestupu(naplneneCisla);
            if (jeVzestupne == -1) {
                Console.WriteLine($"Čísla jsou seřazená vzestupně. Výsledek {jeVzestupne}");
            }
            else { Console.WriteLine($"Zadaná čísla nejsou vzestupná. Porušuje to prvek v řadě (index) {jeVzestupne} a číslo {naplneneCisla[jeVzestupne]}"); }
        }

        public static void Mainx_reseni(string[] args) {
            int[] pole = new int[100];
            int cislo = 0, n = 0, por = 0;
            Console.WriteLine("Zadej pole cisel,ukoncis nulou");
            do {
                int.TryParse(Console.ReadLine(), out cislo);
                if (cislo != 0) pole[n++] = cislo;
            }
            while (cislo != 0);
            por = porusuje(pole, n);
            if (por != 0) Console.WriteLine("posloupnost cisel porusuje {0} znak", porusuje(pole, n));
            else Console.WriteLine("posloupnost cisel neporusuje zadny znak");
        }

        private static int porusuje(int[] poleF, int n) {
            int j = 0, por = 0;
            do {
                if (poleF[j] >= poleF[j + 1]) {
                    por = j + 2;    //+2 kvuli tomu, ze pole zacina od 0 a +1 kvuli tomu, že to porusuje znak v poli j+1
                    break;          //vyskoc z cyklu
                }
                j++;
            }
            while (j < n - 1);
            return por;
        }
    }
}