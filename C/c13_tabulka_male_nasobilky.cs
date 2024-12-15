using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C {

    internal class c13_tabulka_male_nasobilky {

        public static void Mainx() {
            //            Dvojitý cyklus for
            //13) Vypište tabulku malé násobilky.
            //Bude 10 sloupců(+záhlaví) a 10 řádků(+záhlaví).Tedy první sloupec a první řádek jsou záhlaví:
            //    1   2   3   4   5   6  7    8   9  10      toto je záhlaví
            //1   1   2   3   4   5   6  7    8   9  10
            //2   2   4   6   8   10  12 14   16  18 20
            //3   3   6   9   12  15  18 21   24  27 30
            //4   atd.
            //Moje poznámky: jak to udělat, aby tam nebyli podmínky?

            int pocet = 10;
            string sloupecString = "";
            for (int radek = 0; radek <= pocet; radek++) {
                for (int sloupec = 0; sloupec <= pocet; sloupec++) {
                    if (radek == 0) {
                        if (sloupec == 0) {
                            sloupecString += "\t";
                            }
                        else{
                            sloupecString += $"{sloupec}\t";
                        }
                    }
                    else if (sloupec == 0) {
                        sloupecString += $"{radek}\t";
                    }
                    else {
                        sloupecString += $"{sloupec * radek}\t";
                    }
                }
                sloupecString += "\n";
            }

            Console.Write(sloupecString);
        }
    }
}