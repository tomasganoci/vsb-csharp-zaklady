using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.FileIO;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace F {

    internal class f04_prestupnyRok {

        public static void Mainx() {
            //4) Napište funkci, které se předá rok (čtyřciferný) a která vrací logickou hodnotu "true", pokud je rok přestupný (má 366 dní místo 365).
            //Pro jednoduchost stačí řešit podle Juliánského kalendáře (gregoriánský bude za úkol později).
            //Potřebná teorie: Podle Juliánského kalendáře jsou přestupné roky ty, které jsou dělitelné čtyřmi
            //%ifikace programu: funkce, která místo true-false bude vracet přímo délku roku (tedy 365 nebo 366), tedy celočíselný datový typ.
            //Moje poznámky: je to skoro stejné.
            static bool prestupnyRok(int hodnota) {
                if (hodnota % 4 == 0) {
                    return true;
                }
                else {
                    return false;
                }
            }
            static int prestupnyRokModifikace(int hodnota) {
                if (hodnota % 4 == 0) {
                    return 366;
                }
                else {
                    return 365;
                }
            }

            int zadanyRok;
            string jePrestupny;

            Console.WriteLine("Zadejte rok a já Vám napíšu, jestli je přestupný");
            zadanyRok = int.Parse(Console.ReadLine());
            if (prestupnyRok(zadanyRok)) {
                jePrestupny = "Ano";
            }
            else {
                jePrestupny = "Ne";
            }

            Console.WriteLine($"Rok: {zadanyRok}\n" +

                    $"Přestupný: {jePrestupny}\n" +

                    $"Počet dní: {prestupnyRokModifikace(zadanyRok)}");
        }
        public static void Mainx_tezsi() {
//            4) Napište funkci(a pak předělejte na subrutinu), které se předá rok(čtyřciferný) a která vrací logickou hodnotu "True", pokud je rok přestupný(přepracujte z Juliánského kalendáře z BasicCv.doc na Gregoriánský).
//            Řešte dvěma způsoby: dvěma podmínkami(či if-else) i jednou složenou podmínkou.
//            Potřebná teorie: Podle gregoriánského kalendáře jsou přestupné roky ty, které jsou dělitelné čtyřmi.
//            Ale roky dělitelné stem jsou přestupné jenom tehdy, jsou-li dělitelné také 400.
//            Přestupnými roky jsou proto například roky 1600, 2000, 2400 apod., zatímco roky 1700, 1800, 1900, 2100 atd.přestupné nejsou. (zdroj: wikipedia)

        }
    }
}