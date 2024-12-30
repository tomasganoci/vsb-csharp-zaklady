using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F {

    internal class f13_otazka {

        public static void Mainx() {
            //            13) Zjistěte, proč ve Visual Studiu dává tento program i u subrutiny správný součet:
            //Moje odpověď 1: protože subrutina sectiS je sice volaná... ale už není nikde použita... divím se, že to nevyhazuje chybu... předám jí 3 parametry, ale už nemá návratovou hodnotu. (nevěděl jsem, že existuje void metoda)
            //Moje odpověď 2: nebyl použitý prefix ref nebo out.
            //Sub main()
            //    Dim soucet As Byte
            //    soucet = sectiF(3, 4)
            //    ret = ret + Chr(10) + "Soucet podle funkce je " + Str(soucet)
            //    sectiS(3, 4, soucet)
            //    ret = ret + Chr(10) + "Soucet  podle subrutiny je " + Str(soucet)
            //    MsgBox(ret)
            //End Sub

            //Function sectiF(a As Byte, b As Byte) As Byte
            //    sectiF = a + b
            //End Function

            //Sub sectiS(a As Byte, b As Byte, vys As Byte)
            //    vys = a + b + 5
            //End Sub
            byte soucet = 0;
            string ret = "";
            soucet = sectiF(3, 4);
            ret = ret + "\n" + "Soucet podle funkce je " + soucet;
            sectiS(3, 4, out soucet);
            ret = ret + "\n" + "Soucet  podle subrutiny je " + soucet;
            Console.WriteLine(ret);

            static byte sectiF(byte a, byte b) {
                return (byte)(a + b);
            }
        }

        private static void sectiS(byte a, byte b, out byte vys) {
            vys = (byte)(a + b + 5);
        }
    }
}