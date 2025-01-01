using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace F {

    internal class f09_obrat_text {

        public static void Mainx() {
            //Složité programy Doc.Homoly:
            //9) Sestavte funkci ObratText s jedním parametrem -textovým řetězcem.
            //Výsledkem volání funkce je tentýž textový řetězec, ale má znaky v obráceném pořadí.
            //Funkci ověřte na zadání: sestavte program, který načte textový řetězec a zobrazí ho v obráceném pořadí znaků.

            static string ObratText(string text) {
                string vysledek = "";
                for (int i = text.Length-1; i >= 0; i--) {
                    vysledek += text.Substring(i, 1);
                }
                return vysledek;
            }
            string zadanyText = "";
            Console.WriteLine("Zadejte text a já ti ho otočím");
            zadanyText = Console.ReadLine();
            Console.WriteLine($"Zadaný text {zadanyText} a obrácený je {ObratText(zadanyText)}");
        }
        public static void Mainx_reseni(string[] args) {
            Console.WriteLine("Zadejte slovo");
            string text = Console.ReadLine();
            Console.WriteLine("Obracene slovo je {0}", ObratText(text));
        }
        static string ObratText(string text1) {
            string obrT = "", z;
            for (int i = 0; i < text1.Length; i++) {

                z = text1.Substring(i, 1);
                obrT = z + obrT;
            }
            return obrT;
        }
    }
}