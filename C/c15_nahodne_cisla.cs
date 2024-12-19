using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C {

    internal class c15_nahodne_cisla {

        public static void Mainx() {
            //náročnější:
            //    15) Vygenerujte 100 náhodných celých čísel od 1 do 5.
            //    Zjistěte, zda jsou někdy dvě stejná vedle sebe, která to jsou a jaké je jejich pořadové číslo.

            Random rnd = new Random();
            int nahodneCislo = 0;
            int predchoziCislo = 0;
            string vypisCisel = "";
            string stejnaCisla = "";

            for (int i = 1; i < 101; i++) {
                predchoziCislo = nahodneCislo;
                nahodneCislo = rnd.Next(1, 6);
                vypisCisel += nahodneCislo;
                if (predchoziCislo == nahodneCislo) {
                    stejnaCisla += $"Číslo vedle sebe: {nahodneCislo}, pořadové číslo: {i-1} a {i}\n";
                }
            }
            Console.WriteLine($"Náhodné čísla: {vypisCisel}.\nStejná čísla:\n{stejnaCisla}");
        }
    }
}