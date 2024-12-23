using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.FileIO;

namespace D {

    internal class d08_zadavani_ascii_znaku {

        public static void Mainx() {
            //8) Varianta příkladu ze skupiny b: Uživatel opakovaně zadá znak, program vždy odpoví, zda se jedná o písmeno, číslici nebo jiný znak.
            //Zadávání končí zadáním např. nuly (nebo to pro změnu zkuste ukončit nějakým jiným znakem).
            //Řešte pomocí } else { if.
            //Moje poznámky: skoro stejný postup
            //Moje poznámky C#: musím opravit, když je vstup prázdný.

            string zadaneZnaky;
            char zadanyZnak;

            zadaneZnaky = "";
            do {
                Console.WriteLine("Zadejte znak a já ti napíšu o jaký typ znaku se jedná.\nUkončete znakem \";\"");
                zadanyZnak = Convert.ToChar(Console.ReadLine());
                zadaneZnaky += $"{zadanyZnak}\n";
                if (zadanyZnak != ';') {
                    if (zadanyZnak >= 'a' && zadanyZnak <= 'z') {
                        Console.WriteLine("Znak je malé písmeno");
                    }
                    else if (zadanyZnak >= 'A' && zadanyZnak <= 'Z') {
                        Console.WriteLine("Znak je velké písmeno");
                    }
                    else if (zadanyZnak >= '0' && zadanyZnak <= '9') {
                        Console.WriteLine("Znak je číslo");
                    }
                    else {
                        Console.WriteLine("Znak je jiný znak");
                    }
                }
            }
            while (zadanyZnak != ';');
            Console.WriteLine($"Zadané znaky:\n{zadaneZnaky}");
        }

        public static void Mainx_reseni() {
            //Řešení:

            //d08: Varianta příkladu ze skupiny b: Uživatel opakovaně zadá znak, program vždy odpoví, zda se jedná o písmeno,
            //číslici nebo jiný znak. Zadávání končí zadáním prázdného znaku (tedy jen ENTER). Řešte pomocí } else { if.

            char znak;  //ve Visual studiu by se použil typ Char

            do {
                Console.WriteLine("Zadej znak:", "Druh znaku [číslo,písmeno,jiný]");
                znak = Convert.ToChar(Console.ReadLine());
                if (znak != null) {
                    if (znak >= 97 && znak <= 122) {   //druhá možnost
                                                           //if znak >= "a"  && znak <= "z" {
                        Console.WriteLine("znak je malé písmeno");
                    }
                    else if (znak >= 'A' && znak <= 'Z') {
                        Console.WriteLine("znak je velké písmeno");
                    }
                    else if (znak >= '0' && znak <= '9') {
                        Console.WriteLine("znak je číslo");
                    }
                    else {
                        Console.WriteLine("znak není písmeno ani číslo");
                    }
                }
            }
            while (znak != null);
        }

        public static void Mainx_reseni_b() {
            //d08: Varianta příkladu ze skupiny b: Uživatel opakovaně zadá znak, program vždy odpoví, zda se jedná o písmeno,
            //číslici nebo jiný znak. Zadávání končí zadáním prázdného znaku (tedy jen ENTER). Řešte pomocí } else { if.

            //Tato verze je přehlednější, neboť v ní není vnořená podmínka
            string s;   //ve Visual studiu by se použil typ Char
            char znak;

            do {
                Console.WriteLine("Zadej znak:", "Druh znaku [číslo,písmeno,jiný]");
                znak = Convert.ToChar(Console.ReadLine());

                if (znak >= 'a' && znak <= 'z') {
                    s = "znak je malé písmeno";
                }
                else if (znak >= 'A' && znak <= 'Z') {
                    s = "znak je velké písmeno";
                }
                else if (znak >= '0' && znak <= '9') {
                    s = "znak je číslo";
                }
                else {
                    s = "znak není písmeno ani číslo";
                }
                if (znak != null) {
                    Console.WriteLine($"{s}");
                }while (znak != null);
            } while (znak != null);

        }
    }
}