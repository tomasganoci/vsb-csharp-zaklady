using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.FileIO;

namespace A {

    internal class a07_litry_v_sudech {

        public static void Mainx() {
            //a7) Zadejte počet sudů a množství litrů v sudu (ve všech je stejně). Kolik litrů je celkem? (příliš lehké)

            int pocetSudu;
            float mnozstviLitru;

            Console.WriteLine("Kolik chcete sudů?");
            pocetSudu = int.Parse(Console.ReadLine());
            Console.WriteLine("Kolika litry vody, chceš naplnit sudy?");
            mnozstviLitru = int.Parse(Console.ReadLine());

            Console.WriteLine($"Celkem v {pocetSudu} sudech bude naplněno {mnozstviLitru * pocetSudu} l vody.");
        }

        public static void Mainx_reseni() {
            //Řešení:
            //a07: Zadejte počet sudů a množství litrů v sudu(ve všech je stejně).
            //    Kolik litrů je celkem?

            long pocSudu;
            float objem1sudu;
            Console.WriteLine("zadej pocet sudu (ks): ");
            pocSudu = long.Parse(Console.ReadLine());
            Console.WriteLine("zadej maximalni obsah sudu (l):");
            objem1sudu = float.Parse(Console.ReadLine());
            Console.WriteLine($"maximalni obsah vsech sudu je:  {pocSudu * objem1sudu} l");
        }
    }
}