using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.FileIO;

namespace D {

    internal class d02_uctenky {

        public static void Mainx() {
            //2) Máte schované účtenky z různých nákupů, nevíte ale, kolik účtenek je. Proto částky na účtenkách budete zadávat postupně, jako poslední zadáte nulu.
            //Program spočítá, kolik jste utratili a zároveň oznámí, kolik nákupů přesáhlo částku 100 Kč.
            //Moje poznámky: doplnil jsem více proměnných a více údajů, použíl jsem u "while" nerovná se tedy != a dává to větší logiku, protže musím zadat kladné číslo, když dám ">",
            //               použil jsem exit do - což jsem asi neměl, když jsem to neměl v učení,

            float castkaUctenky, soucetUctenek, uctenkyNadHodnotou;
            int pocetNadHodnotou;
            string uctenky;

            int i = 0;
            uctenkyNadHodnotou = 100;
            pocetNadHodnotou = 0;
            soucetUctenek = 0;
            uctenky = "";

            do {
                i++;
                Console.WriteLine($"Zadejte částku z účtenky číslo {i}\n" +
                                  $"Počítání ukončíte zadáním \"0\".");
                castkaUctenky = float.Parse(Console.ReadLine());
                if (castkaUctenky == 0) {
                    break;
                }

                soucetUctenek = soucetUctenek + castkaUctenky;
                uctenky += $"Účtenka číslo {i} je na částku {castkaUctenky}";
                if (castkaUctenky > uctenkyNadHodnotou) {
                    pocetNadHodnotou++;
                    uctenky += $" - Tato účtenka je nad {uctenkyNadHodnotou} Kč\n";
                }
                else {
                    uctenky += "\n";
                }
            }
            while (castkaUctenky != 0);

            Console.WriteLine($"{uctenky}" +
                    $"\n" +
                    $"Celkový součet účtenek: {soucetUctenek} Kč\n" +
                    $"Počet účtenek nad hodnotu {uctenkyNadHodnotou}: {pocetNadHodnotou}x");
        }

        public static void Mainx_reseni() {
            //Řešeni:

            //d02: Máte schované účtenky z různých nákupů, nevíte ale, kolik účtenek je.
            //Proto částky na účtenkách budete zadávat postupně, jako poslední zadáte nulu.
            //Program spočítá, kolik jste utratili a zároveň oznámí, kolik nákupů přesáhlo částku 100 Kč.

            float castka, suma;
            byte pocet100;

            suma = 0;
            pocet100 = 0;
            do {
                Console.WriteLine("Zadej částku na účtence(Kč)[0 = konec]");
                castka = float.Parse(Console.ReadLine());

                suma = suma + castka;
                if (castka > 100) {
                    pocet100++;
                }
            }
            while (castka > 0);
            Console.WriteLine($"Celkem utraceno {suma} kc\n{pocet100}x nákup větší než 100 Kč");
        }
    }
}