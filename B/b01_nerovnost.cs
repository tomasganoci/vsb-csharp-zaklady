using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B {

    internal class b01_nerovnost {

        public static void Mainx() {
            //b1)  Určete, zda dvě zadaná čísla x,y čísla splňují nerovnost x+3<5y-1
            //moje poznámka: mám to skoro identické, zapomněl jsem dát příklady do závorek

            float x, y;

            Console.WriteLine("Dosaďte číslo čísla do příkladu \"x + 3 < 5 * y - 1\"\njá ti napíšu, jestli splňují nerovnost");
            Console.WriteLine("Dosaďte číslo \"x\"");
            x = float.Parse(Console.ReadLine());
            Console.WriteLine("Dosaďte číslo \"y\"");
            y = float.Parse(Console.ReadLine());

            if ((x + 3) < (5 * y - 1)) {
                Console.WriteLine("Zadaná čísla splňují nerovnost.");
            }
            else {
                Console.WriteLine("Zadaná čísla nesplňují nerovnost.");
            }
        }

        public static void Mainx_reseni() {
            //Řešení:
            //b01: Určete, zda dvě zadaná čísla x,y čísla splňují nerovnost x+3<5y-1

            float x, y;
            Console.WriteLine("zadej x: ");
            x = float.Parse(Console.ReadLine());
            Console.WriteLine("zadej y: ", "splnuje x a y nerovnost x + 3 < 5y - 1 ? ");
            y = float.Parse(Console.ReadLine());
            if ((x + 3) < (5 * y - 1)) {
                Console.WriteLine("Cisla splnuji nerovnost x+3<5y-1");
            }
            else {
                Console.WriteLine("Cisla nesplnuji nerovnost x+3<5y-1");
            }
        }

        public static void Mainx_reseni1() {
            //b1)  Určete, zda dvě zadaná čísla x,y čísla splňují nerovnost x+3<5y-1
            //Moje poznámka: Zadání jsem špatně pochopil a nevěděl jsem, že 5y je 5 x y

            long x, y, y5;
            string spojeni;
            bool vysledek;
            Console.WriteLine("Zadejte první číslo");
            x = long.Parse(Console.ReadLine());
            Console.WriteLine("Zadejte druhé číslo, k číslu bude na začátku přidano číslo 5");
            y = long.Parse(Console.ReadLine());

            spojeni = $"5{y}";
            y5 = long.Parse(spojeni);
            vysledek = x + 3 < y5 - 1;

            if (vysledek) {
                Console.WriteLine("První číslo je menší!");
            }
            else {
                Console.WriteLine("První číslo je větší!");
            }
        }
    }
}