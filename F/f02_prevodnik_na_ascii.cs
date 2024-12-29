using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.FileIO;
using Microsoft.VisualBasic;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace F {

    internal class f02_prevodnik_na_ascii {
        ////2)  Napište funkci, které se zadá znak a která vrátí jeho ASCII hodnotu.  (příliš lehké)
        ////Moje poznámky: skoro stejné, druhá možnost mi příjde asi více náročnější na proce.

        //    zadanyZnak string

        //    zadanyZnak = Console.ReadLine();Console.WriteLine("Zadejte znak a já ti vypíšu jeho ASCII hodnotu")
        //    Console.WriteLine("Zadaný znak: zadanyZnak\n
        //            "ASCII hodnota: vratASCII(zadanyZnak)))

        //Function vratASCII(ascii string) byte
        //    vratASCII =c(ascii)
        //End Function

        //Řešení:
        //f02) Napište funkci, které se zadá znak a která vrátí jeho ASCII hodnotu.
        public static void Mainx() {
            char znak;
            byte ascii;
            Console.WriteLine("Zadej znak!");
            znak = char.Parse(Console.ReadLine());
            ascii = asciiHodnota(znak);
            Console.WriteLine($"ASCII hodnota zadaneho znaku {znak} je {ascii}");

            ascii = asciiHodnota2(znak);
            Console.WriteLine($"ASCII hodnota zadaneho znaku {znak} je {ascii}");

            static byte asciiHodnota(char zadanyZnak) {
                return Convert.ToByte(zadanyZnak);
            }

            //Druhá možnost: kdybychom se chtěli vyhnout hotové funkcic
            static byte asciiHodnota2(char zadanyZnak) {
                byte i;
                for (i = 32; i < 254; i++) {
                    if (i == Convert.ToChar(zadanyZnak)) {
                        return i;
                    }
                }
                return 0;
            }
        }
    }
}