using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C {

    internal class c16_cisla_za_sebou {

        public static void Mainx() {
            //16) Vypište 10 řádků.Na prvním řádku číslo 1, na druhém řádku 12, na třetím 123 atd.
            //(použijte vnořenou smyčku)
            //moje poznámky: proč použít u tohoto lehkého příkladu vnořenou smyčku? To bych mohl dát jen ať splní jednoduchou podmínku...
            string radek = "";

            for (int i = 0; i < 10; i++) {
                radek += $"{i + 1}";
                Console.WriteLine(radek);
            }
        }
    }
}