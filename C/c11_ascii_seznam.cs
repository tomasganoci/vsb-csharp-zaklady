using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.FileIO;
using static System.Net.Mime.MediaTypeNames;

namespace C {

    internal class c11_ascii_seznam {

        public static void Mainx() {
            //11) Tabulka ASCII: zobrazit v  MsgBoxu v levém sloupci čísla např. 65 až 100 a v pravém příslušný znak.
            //Moje poznámky: nemám "hlavičku", zapomněl jsem inicializaci asci,

            string asci = "ASCII\tznak\n";
            for (int i = 65; i <= 100; i++) {
                asci += $"{i}\t{(Char)i}\n";
            }
            Console.WriteLine(asci);
        }

        public static void Mainx_reseni() {
            //Řešení:
            //c11: Tabulka ASCII: zobrazit v  msgBoxu v levém sloupci čísla např. 65 až 100 a v pravém příslušný znak.

            string znak;

            string s = "ASCII   znak\n";
            for (byte i = 65; i < 100; i++) {
                znak = $"{(Char)i}";
                s = $" {s} + {i}) +        + {znak} + \n";
            }
            Console.WriteLine($"{s}, , Tabulka ASCII [65-100]");
        }
    }
}