using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F2 {

    internal class f2_07_serazeni_cisel_bool {

        public static void Mainx() {
            //7) Sestavte program, který nejprve čte řadu čísel ukončených nulou, která už do řady nepatří.
            //Pole se předá funkci, která sdělí(boolean), zda jsou čísla seřazena vzestupně.
            //Tedy každé další číslo je větší než předchozí.
            //Čili stačí jeden jediný pokles a už to není pravda.
            static bool KontrolaVzestupu(int[] pole) {
                int posledniCislo = int.MinValue; ;
                for (int i = 0; i < pole.Length; i++) {
                    if (posledniCislo > pole[i]) {
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
            Console.WriteLine($"Jsou zadaná čísla seřazená vzestupně: {jeVzestupne}");
        }

        public static void Mainx_reseni() {
            int[] pole = new int[100];
            int cislo = 0, n = 0;
            bool vzeF = false;
            Console.WriteLine("zadej cisla max.100, ja zjistim, jestli si je zadal od nejmensiho po nejvetsi, nulou zadavani ukoncis.");
            do {
                int.TryParse(Console.ReadLine(), out cislo);
                if (cislo != 0) pole[n++] = cislo;
            }
            while (cislo != 0);
            vzeF = vzestupne(pole, n);
            if (vzeF == true) Console.WriteLine("cisla byla zadana vzestupne");
            else Console.WriteLine("cisla nebyla zadana vzestupne");
        }

        private static bool vzestupne(int[] poleF, int nF) {
            bool vze = true;
            int i = 0;
            do {
                if (poleF[i] >= poleF[i + 1]) vze = false;
                i++;
            }
            while (nF - 1 > i);
            return vze;
        }
    }
}