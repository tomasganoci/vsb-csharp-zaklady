using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F2 {

    internal class f2_06_suda_cisla_z_pole {

        public static void Mainx() {
            //6) Sestavte funkci SudaCislaZpole, která má jediný parametr: pole celých čísel.
            //Výsledkem funkce je jednorozměrné celočíselné pole, ve kterém jsou jen sudá čísla obsažená v poli parametru.
            //Funkci ověřte na zadání: sestavte program, který načte pole celých čísel ukončených nulou, která už k číslům nepatří, a pak zobrazí všechna ze zadaných čísel, která jsou sudá.
            //ještě bych přidal parametr, jestli má funkce počítat s 0. Takhle jsem to do funkce nerval na tvrdo.
            static int[] SudaCislaZPole(int[] pole) {
                int velikostSudych = 0;
                for (int i = 0; i < pole.Length; i++) {
                    if (pole[i] % 2 == 0 & pole[i] != 0) {
                        velikostSudych++;
                    }
                }

                int[] sudaPole = new int[velikostSudych];
                int sudeCislo = 0;
                for (int i = 0; i < pole.Length; i++) {
                    if (pole[i] % 2 == 0 & pole[i] != 0) {
                        sudaPole[sudeCislo++] = pole[i];
                    }
                }
                return sudaPole;
            }

            int[] ciselnePole = new int[100];
            int zadanaHodnota = 0;
            Console.WriteLine("Zadejte čísla a já ti vypíšu pouze sudá[Ukončete 0]");
            for (int i = 0; i < ciselnePole.Length; i++) {
                Console.WriteLine($"Zadejte hodnotu číslo {i + 1}");
                zadanaHodnota = int.Parse(Console.ReadLine());
                if (zadanaHodnota == 0) {
                    break;
                }
                ciselnePole[i] = zadanaHodnota;
            }

            // pro testování
            //for (int i = 0; i < ciselnePole.Length; i++) {
            //    ciselnePole[i] = i+1;
            //}

            ciselnePole = SudaCislaZPole(ciselnePole);
            Console.WriteLine();
            foreach (int prvek in ciselnePole) {
                Console.WriteLine(prvek);
            }
        }
    }
}