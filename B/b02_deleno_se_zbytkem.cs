using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.FileIO;

namespace B {

    internal class b02_deleno_se_zbytkem {

        public static void Mainx() {
            //b2)  Zadejte dvě celá čísla x a y. Zjistěte, zda číslo x je beze zbytku dělitelné číslem y.
            //moje poznámky: já použil deklaraci long místo int, výpočet mám správným jen jsem zvolil jiný postup

            long x, y, vypocetxy;

            Console.WriteLine("Zadejte dvě čísla x a y.Zjistěte, zda číslo x je dělitelné číslem y");
            Console.WriteLine("Zadejte číslo, které chcete dělit");
            x = long.Parse(Console.ReadLine());
            Console.WriteLine("Zadejte dělitele a já ti řeknu, jestli první číslo je beze zbytku dělitelné");
            y = long.Parse(Console.ReadLine());

            vypocetxy = x % y;

            if (vypocetxy > 0) {
                Console.WriteLine($"Děleno se zbytkem. Zůstalo: {vypocetxy}");
            }
            else {
                Console.WriteLine("Děleno beze zbytku");
            }
        }

        public static void Mainx_reseni() {
            //Řešení:
            //
            //b02: Zadejte dvě čísla x a y.Zjistěte, zda číslo x je dělitelné číslem y
            //

            int x, y;

            Console.WriteLine("Zadejte dvě čísla x a y.Zjistěte, zda číslo x je dělitelné číslem y");
            Console.WriteLine("zadej x: ");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("zadej y: ");
            y = int.Parse(Console.ReadLine());
            if (x % y == 0) {
                Console.WriteLine("Cislo x je delitelne cislem y");
            }
            else {
                Console.WriteLine("Cislo x není delitelne cislem y");
            }
        }
    }
}