using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.FileIO;

namespace B {

    internal class b08_znak_ascii {

        public static void Mainx() {
            //b8)  Uživatel zadá znak, program odpoví, zda se jedná o velké písmeno, malé písmeno, číslici nebo jiný znak.
            //Řešte pomocí } else { if. (nebo je možno řešit i složenou podmínkou).
            //U písmen uvažujte jen písmena anglické abecedy (tedy bez háčků a čárek).
            //Řešte intervalem (čili od-do), tedy využijte toho, že číslice jsou v ASCII za sebou seřazeny podle hodnoty (podobně velká písmena seřazená podle anglické abecedy a stejně tak i malá písmena).
            //Tedy neřešte výčtem (vyjmenováním jednotlivých písmenek).
            //moje poznámka: taky jsem to mohl vyřešit jako v prvním řešení, ale to mě nenapadlo, že to můžu udělat i takto, nemusel jsem použít proměnnou "ascii" a mohl jsem jí rovnou zadat v "zadanyZnak".
            //               použil jsem jiné podmínky s " &&" a " || "

            string zadanyZnak;
            byte ascii;

            Console.WriteLine("Zadejte jeden znak a já ti řeknu, o jaký znak se jedná");
            zadanyZnak = Console.ReadLine();

            ascii = byte.Parse(zadanyZnak);

            if (ascii == 32) {
                Console.WriteLine("Toto není znak, ale mezera!");
            }
            else if (ascii >= 33 & ascii <= 47 || ascii >= 58 & ascii <= 64 || ascii >= 91 & ascii <= 96 || ascii >= 123 & ascii <= 126) {
                Console.WriteLine($"Zadal jsi znak {zadanyZnak}");
            }
            else if (ascii >= 48 & ascii <= 57) {
                Console.WriteLine($"Zadal jsi číslici {zadanyZnak}");
            }
            else if (ascii >= 65 & ascii <= 90) {
                Console.WriteLine($"Zadal jsi velké písmeno {zadanyZnak}");
            }
            else if (ascii >= 97 & ascii <= 122) {
                Console.WriteLine($"Zadal jsi malé písmeno {zadanyZnak}");
            }
            else {
                Console.WriteLine("Tento znak není v ASCII tabulce");
            }
        }

        public static void Mainx_reseni() {
            //
            //Řešení:
            //
            //b08: Uživatel zadá znak, program odpoví, zda se jedná o písmeno,
            //číslici nebo jiný znak.Řešte pomocí } else { if.
            //
            char znak;

            Console.WriteLine("Zadej znak: ");
            znak = Convert.ToChar(Console.ReadLine());
            //ifc(znak) >= 97  &&c(znak) <= 122 {   //druhá možnost
            if (znak >= 'a' && znak <= 'z') {
                Console.WriteLine("znak je male pismeno");
            }
            else if (znak >= 'A' && znak <= 'Z') {
                Console.WriteLine("znak je velke pismeno");
            }
            else if (znak >= 'a' && znak <= 'z') {
                Console.WriteLine("znak je cislo");
            }
            else {
                Console.WriteLine("znak je jiny znak");
            }
        }

        public static void Mainx_reseni2() {
            //Druhá možnost:

            byte x;

            Console.WriteLine("Zadejte znak");
            x = Convert.ToByte(char.Parse(Console.ReadLine()));
            if (x < 33) {
                Console.WriteLine("Funkční klávesa");
            }
            else if (x < 48) {
                Console.WriteLine("Speciální znak");
            }
            else if (x < 58) {
                Console.WriteLine("Číslice");
            }
            else if (x < 65) {
                Console.WriteLine("Speciální znak");
            }
            else if (x < 91) {
                Console.WriteLine("Velké písmeno");
            }
            else if (x < 97) {
                Console.WriteLine("Speciální znak");
            }
            else if (x < 123) {
                Console.WriteLine("Malé písmeno");
            }
            else {
                Console.WriteLine("Speciální znak");
            }
        }
    }
}