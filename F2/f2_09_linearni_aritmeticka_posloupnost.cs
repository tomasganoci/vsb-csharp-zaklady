using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F2 {

    internal class f2_09_linearni_aritmeticka_posloupnost {

        public static void Mainx() {
            //9) Sestavte program, který nejprve čte řadu čísel ukončených nulou, která už do řady nepatří.
            //Pole se předá funkci, která sdělí(boolean), zda čísla tvoří lineární aritmetickou(tj.lineární) posloupnost(rozdíl dvou sousedních je vždy tentýž).
            static bool KontrolaVzestupu(int[] pole) {
                int posledniCislo = 0;
                int aritmeticka = 0;

                for (int i = 0; i < pole.Length; i++) {
                    if (i == 1) {
                        aritmeticka = pole[i] - posledniCislo;
                    }
                    if (aritmeticka != pole[i] - posledniCislo & i > 1) {
                        return false;
                    }
                    posledniCislo = pole[i];
                }
                return true;
            }

            int[] zadanaCisla = new int[100];
            int zadaneCislo = 0;
            int pocetPruchodu = 0;
            bool jeVzestupne = true;
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
            Array.Copy(zadanaCisla, naplneneCisla, pocetPruchodu);
            jeVzestupne = KontrolaVzestupu(naplneneCisla);
            Console.WriteLine($"Tvoří zadaná čísla tvoří lineární aritmetickou posloupnost: {jeVzestupne}");
        }

        public static void Mainx_reseni() {
            int[] pole = new int[1];
            int cislo = 0, n = 0;
            bool mF = false;
            Console.WriteLine("Zadej pole cisel,ukoncis nulou");
            do {
                int.TryParse(Console.ReadLine(), out cislo);
                if (cislo != 0) {
                    pole[n++] = cislo;
                    Array.Resize(ref pole, n + 1);
                }
            }
            while (cislo != 0);
            mF = aritpos(pole);
            if (mF == true) Console.WriteLine("posloupnost je aritmeticka");
            else Console.WriteLine("posloupnost neni aritmeticka");
        }

        private static bool aritpos(int[] poleF) {
            bool yes = false;
            int mez = poleF[1] - poleF[0];
            for (int i = 1; i < poleF.Length; i++) {
                if (mez == poleF[i + 1] - poleF[i] && mez != 0) yes = true;
                else break;
            }
            return yes;
        }
    }
}