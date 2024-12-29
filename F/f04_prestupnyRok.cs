using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}