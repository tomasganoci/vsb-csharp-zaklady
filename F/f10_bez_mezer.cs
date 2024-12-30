using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace F {

    internal class f10_bez_mezer {

        public static void Mainx() {
            //10) Sestavte funkci BezMezer s jedním parametrem -textovým řetězcem.
            //Výsledkem volání funkce je tentýž textový řetězec, ve kterém však jsou vypuštěny všechny mezery.
            //Funkci ověřte na zadání: sestavte program, který načte textový řetězec a zobrazí ho tak, že v něm jsou vypuštěny všechny mezery.
            static string BezMezer(string text) {
                return text.Replace(" ", "");
            }
            string zadanyText = "";
            Console.WriteLine("Napiš větu s mezerami a já ti je odstraním");
            zadanyText = Console.ReadLine();
            Console.WriteLine($"Tvoje věta: {zadanyText}\nVěta bez mezer: {BezMezer(zadanyText)}");
        }
    }
}