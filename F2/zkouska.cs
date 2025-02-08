using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F2 {

    internal class zkouska {

        public static void Mainx() {
            int[] zadaneCisla = new int[100];
            int zadaneCislo = 0;
            int i = 1;
            int pocetZadanych = 0; 
            int soucetLichych = 0;
            int pocetLichych = 0;
            double prumerLichych;
            do {
                Console.WriteLine("Zadejte číslo a já ti na konci zobrazím průměr lichých čísel v pozici");
                zadaneCislo = int.Parse(Console.ReadLine()); 
                if (zadaneCislo == 0) {
                    break;
                }
                zadaneCisla[i] = zadaneCislo;
                i++;
                pocetZadanych++;
            } while (zadaneCislo != 0);

            for (i = 1; i <= pocetZadanych; i+=2) {
                soucetLichych += zadaneCisla[i];
                pocetLichych++;
            }
            prumerLichych = (double)soucetLichych / pocetLichych;
            Console.WriteLine($"Průměr lychých čísel je {prumerLichych:f}");
        }

        public static void Main_f() {

            int[] poleCisel = new int[100];
            int zadaneCislo = 0;

            Random rnd = new Random();

            for (int i = 0; i < poleCisel.Length; i++) {
                zadaneCislo = rnd.Next(-100,100);
                poleCisel[i] = zadaneCislo;
            }
            Console.WriteLine($"Nejmenší číslo ze zadání je {FunkceNejmensi(poleCisel)}");
        }
        private static int FunkceNejmensi(int[] cislo) {
            int nejmensiCislo = cislo[0];
            for (int i = 0; i < cislo.Length; i++) {
                if (cislo[i] < nejmensiCislo) {
                    nejmensiCislo = cislo[i];
                }
            }
            return nejmensiCislo;
        }


        public static void Main_f1() {
            int[] poleCisel = new int[100];
            int zadaneCislo = 0;
            int vysledekNejmensiCislo = 0;

            Random rnd = new Random();

            for (int i = 0; i < poleCisel.Length; i++) {
                zadaneCislo = rnd.Next(-100, 100);
                poleCisel[i] = zadaneCislo;
            }
            FunkceNejmensiSubrutina(poleCisel, out vysledekNejmensiCislo);
            Console.WriteLine($"Nejmenší číslo ze zadání je {vysledekNejmensiCislo}");
        }
        private static void FunkceNejmensiSubrutina(int[] cisla, out int nejmensiCislo) {
            nejmensiCislo = cisla[0];
            for (int i = 0; i < cisla.Length; i++) {
                if (cisla[i] < nejmensiCislo) {
                    nejmensiCislo = cisla[i];
                }
            }
        }
    }
}