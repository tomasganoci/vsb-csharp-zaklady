using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace F {

    internal class f11_vyskyty {

        public static void Mainx() {
            //11) Sestavte funkci Vyskyty se dvěma parametry -textovými řetězci.Druhý parametr je subřetězec, případně jen jednoznakový řetězec.
            //Výsledkem volání funkce je počet opakování druhého parametru v parametru prvním.
            //Funkci ověřte na zadání: sestavte program, který načte textový řetězec a zobrazí například počet písmen "A" v tomto řetězci.
            static int Vyskyty(string text, string hledat) {
                int delkaTextu = text.Length;
                int pocetVyskytu = 0;
                for (int i = 0; i <= delkaTextu - 1; i++) {
                    if (i + hledat.Length > delkaTextu) {
                        text += " ";
                    }
                    if (text.Substring(i, hledat.Length) == hledat) {
                        pocetVyskytu++;
                    }
                }
                return pocetVyskytu;
            }

            string zadanyText = "";
            string zadaneHledani = "";
            Console.WriteLine("Napiš mi text a jaký znak nebo slovo chceš hledat a já ti vypíšu kolikrát se objevuje v textu.");
            Console.WriteLine("Napiš text");
            zadanyText = Console.ReadLine();
            Console.WriteLine("Jaký znak nebo slovo chceš najít?");
            zadaneHledani = Console.ReadLine();
            Console.WriteLine($"V text \"{zadanyText}\" jsem vyhledal \"{zadaneHledani}\" {Vyskyty(zadanyText, zadaneHledani)}x.");
        }
    }
}