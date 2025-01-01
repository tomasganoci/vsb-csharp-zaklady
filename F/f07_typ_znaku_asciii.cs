using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.FileIO;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace F {

    internal class f07_typ_znaku_asciii {
        ////7) Funkci se předá znak a funkce vrátí řetězec: "malé písmeno", "velké písmeno", "číslice", "ostatní".
        ////MOje poznámky: Jen jsem převzal výsledek z předchozích příkladů a upravil.
        //Function TypZnaku(hodnota string) string
        //    hodnotaStr string

        //    hodnotaStr = hodnota
        //    hodnota =c(hodnota)
        //    if hodnota = 32 {
        //        TypZnaku = "Toto není znak, ale mezera!"
        //    } else {if(hodnota >= 33 && hodnota <= 47)
        //            ||(hodnota >= 58 && hodnota <= 64)
        //            ||(hodnota >= 91 && hodnota <= 96)
        //            ||(hodnota >= 123 && hodnota <= 126) {
        //        TypZnaku = "Zadal jsi znak  hodnotaStr
        //    } else {if(hodnota >= 48 && hodnota <= 57) {
        //        TypZnaku = "Zadal jsi číslici  hodnotaStr
        //    } else {if(hodnota >= 65 && hodnota <= 90) {
        //        TypZnaku = "Zadal jsi velké písmeno  hodnotaStr
        //    } else {if(hodnota >= 97 && hodnota <= 122) {
        //        TypZnaku = "Zadal jsi malé písmeno  hodnotaStr
        //    } else {
        //       TypZnaku = "Tento znak není v ASCII tabulce"
        //    }
        //End Function

        //    zadanyZnak string

        //    zadanyZnak = Console.ReadLine();Console.WriteLine("Zadejte znak a já ti napíšu o jaký znak se jedná")
        //    Console.WriteLine("TypZnaku(zadanyZnak))

        public static void Mainx() {
            //Řešení:
            //f7) Metodě se zadá znak a metoda vypíše (nebo vrací) slovy: písmeno (pozná malé i velké), číslice, ostatní.
            char vstup;
            Console.WriteLine("Zadej znak");
            vstup = char.Parse(Console.ReadLine());
            Console.WriteLine($"{TypZnaku(vstup)}");

            static string TypZnaku(char znak) {
                //if(znak >= "A"  && znak <= "Z") {         //toto je jednodušší
                if (znak >= 65 && znak <= 90) {
                    return "velke pismeno";
                }
                else if (znak >= 97 && znak <= 122) {
                    return "male pismeno";
                }
                else if (znak >= 48 && znak <= 57) {
                    return "cislice";
                }
                else {
                    return "jiny znak";
                }
            }
        }
        public static void Mainx_reseni(string[] args) {
            Console.WriteLine("Zadej znak");
            char vstup = (char)Console.Read();
            Console.WriteLine(signum(vstup));
        }
        static string signum(char v) {
            string vystup = "";
            if (v >= 'a' && v <= 'z') vystup = "Jedna se o male pismeno.";
            else if (v >= 'A' && v <= 'Z') vystup = "Jedna se o velke pismeno.";
            else if (v >= '0' && v <= '9') vystup = "Jedna se o cislici.";
            else vystup = "Jedna se o jiny znak.";
            return vystup;
        }
    }
}