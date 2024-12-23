using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.FileIO;

namespace D {

    internal class d01_zaku_ve_tride {
        public static void Mainx_reseni_do_while() {
            //Řešení:
            //d01: Zadejte postupně, kolik je v každé třídě žáků (0=konec).
            //Program spočítá, kolik je žáků v celé škole a průměrný počet žáků ve třídě.
            //Ověřte, že nula do platných dat nepatří.
            //Nesmí se tedy stát, že při zadání 30 a 0 (tedy jen jedna třída a to s 30 žáky)
            //vyjde průměrný počet žáků 15 (omylem se uvažovaly dvě třídy, jedna má 30 a druhá 0 žáků)

            byte pocetTrid, pocetZaku;
            int suma;
            float Prumer;

            pocetTrid = 0;
            pocetZaku = 0;
            suma = 0;

            Console.WriteLine($"Zadej pocet zaku ve tride[0 = konec]");
            pocetZaku = byte.Parse(Console.ReadLine());
            while (pocetZaku > 0) {
                suma += pocetZaku;
                pocetTrid++;
                Console.WriteLine($"Zadej pocet zaku ve tride[0 = konec]");
                pocetZaku = byte.Parse(Console.ReadLine());
            }
            if (suma == 0) {
                Console.WriteLine("Škola je prádná.");
            }
            else {
                Prumer = suma / (pocetTrid - 1);
                Console.WriteLine($"Celkem {suma} žáků na škole\nPrůměrně {Prumer} žáků ve třídách");
            }
        }

        public static void Mainx() {
            //1) Zadejte postupně, kolik je v každé třídě žáků (0=konec).
            //Program spočítá, kolik je žáků v celé škole a průměrný počet žáků ve třídě.
            //Ověřte, že nula do platných dat nepatří.
            //Nesmí se tedy stát, že při zadání 30 a 0 (tedy jen jedna třída a to s 30 žáky) vyjde průměrný počet žáků 15 (omylem se uvažovaly dvě třídy, jedna má 30 a druhá 0 žáků)
            //Moje poznámky: počet žáku a tříd jsem dal int a mohl jsem dát byte, přepsal jsem proměnnou "trida" na pocetTrid", součet počtu žáků jsem mohl nechat v do - 0 nevadí když se sečte
            //               nevzal jsem v potaz, že by první číslo mohla být 0 a tak by byla škola prázdná, zahrnul jsem podmínky do DO, průměr jsem udělal přímo v MsgBox,
            //               Podmínku vyhodnocují ve smyčce, což není dobré, ale zase vypisuji přímo třídy a počet žáků.

            int zadanoZaku;
            double poceTrid, pocetZaku;
            string zakuVeTride;

            poceTrid = 0;
            pocetZaku = 0;
            zakuVeTride = "";
            zadanoZaku = 0;

            do {
                poceTrid++;
                Console.WriteLine($"Zadejte počet žáků ve tříde číslo: {poceTrid}\nZadejte \"0\" pro ukončení.");
                zadanoZaku = int.Parse(Console.ReadLine());
                if (zadanoZaku == 0) {
                    poceTrid = poceTrid - 1;
                }
                else {
                    zakuVeTride += $"Třída: {poceTrid}, Počet dětí: {zadanoZaku}\n";
                    pocetZaku += zadanoZaku;
                }
            }
            while (zadanoZaku != 0);

            Console.WriteLine($"{zakuVeTride}\n" +
                              $"Celkový počet žáků ve třídách: {pocetZaku}\n" +
                              $"Průměrně žáků ve třídách: {Math.Round(pocetZaku / poceTrid, 1)}");
        }

        public static void Mainx_reseni() {
            //Řešení:
            //d01: Zadejte postupně, kolik je v každé třídě žáků (0=konec).
            //Program spočítá, kolik je žáků v celé škole a průměrný počet žáků ve třídě.
            //Ověřte, že nula do platných dat nepatří.
            //Nesmí se tedy stát, že při zadání 30 a 0 (tedy jen jedna třída a to s 30 žáky)
            //vyjde průměrný počet žáků 15 (omylem se uvažovaly dvě třídy, jedna má 30 a druhá 0 žáků)

            byte pocetTrid, pocetZaku;
            int suma;
            float Prumer;

            pocetTrid = 0;
            suma = 0;
            do {
                Console.WriteLine($"Zadej pocet zaku ve tride[0 = konec]");
                pocetZaku = byte.Parse(Console.ReadLine());
                suma += pocetZaku;
                pocetTrid++;
            }
            while (pocetZaku > 0);
            if (suma == 0) {
                Console.WriteLine("Škola je prádná.");
            }
            else {
                Prumer = suma / (pocetTrid - 1);
                Console.WriteLine($"Celkem {suma} žáků na škole\nPrůměrně {Prumer} žáků ve třídách");
            }
        }
    }
}