using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace F {

    internal class f08_pocet_dni_v_mesici {

        public static void Mainx() {
            //            Náročnější
            //            Doporučuji do C# i Javy předělat i předchozí programy sekce f1.
            //            8) Sestavte funkci PocetDniMesice, která má jako jediný parametr číslo měsíce.
            //            Výsledkem volání funkce je počet dní tohoto měsíce(nebo -1, není - li hodnota měsíce správná).
            //            Přestupné roky pro únor neuvažujte.
            //            Funkci ověřte na zadání: sestavte program, který načte číslo měsíce a poté zobrazí, kolik dní má tento měsíc.
            //            Vyzkoušejte i pro měsíc = 13.Návod: řešte pomocí složené podmínky nebo konstrukcí Select Case. (program Doc.Homoly)
            //            Pozor: Vstupy a výstupy budou v hlavním programu, předávat se budou přes parametry funkce či subrutiny.
            //            V hlavním programu musí být použity jiné názvy proměnných než v subrutině či funkci.

            static int PocetDniMesice(int cisloMesice) {
                switch (cisloMesice) {
                    case 1: return 31;
                    case 2: return 28;
                    case 3: return 31;
                    case 4: return 30;
                    case 5: return 31;
                    case 6: return 30;
                    case 7: return 31;
                    case 8: return 31;
                    case 9: return 30;
                    case 10: return 31;
                    case 11: return 30;
                    case 12: return 31;
                    default: return -1;
                }
            }

            int zadaneCisloMesice = 0;
            Console.WriteLine("Napiš číslo měsíce a já ti vypíšu, kolik má dní");
            zadaneCisloMesice = int.Parse(Console.ReadLine());
            Console.WriteLine($"V {zadaneCisloMesice} měsící je {PocetDniMesice(zadaneCisloMesice)} dní.");
        }
    }
}