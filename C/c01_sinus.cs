using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.FileIO;
using static System.Net.Mime.MediaTypeNames;

namespace C {

    internal class c01_sinus {

        public static void Mainx() {
            //1)  Vypište tabulku x funkce sinus(x) pro x od 0 do 2*PI s krokem 0,1. Výpis bude vypadat např. takto:
            //Sin(0, 0) = 0
            //sin(0,1) = 0,0998
            //atd.
            //Nevadí, když místo 0,0998 bude ,0998
            //Moje poznámky: špatně jsem pochopil zadání a tak jsem nedal do 2* PI ale do 2. asi "krok" je lepší na pochopení, protože se liší od "index",

            string sinus = "";
            for (double step = 0; step <= 2.0 * Math.PI; step += 0.1) //i = radiany To 2 * pi
                        {
                sinus = sinus + $"Sin ({Math.Round(step, 2)}) = {Math.Round(Math.Sin(step), 4)}\n";
            }
            Console.WriteLine(sinus);
        }

        public static void Mainx_reseni() {
            //Řešení:
            //c01) Vypište tabulku funkce sinus od 0 do 2*PI s krokem 0,1.
            //
            double krok;
            string s;
            int i;

            s = "";
            for (krok = 0; krok <= 2 * Math.PI; krok += 0.1) {
                s = s + $"sin  + {Math.Round(krok, 2)} je {Math.Round(Math.Sin(krok), 4)} \n"; //Chr(9) je tabulátor
            }
            Console.WriteLine(s);

            //Druhá možnost, počitadlo je celočíselné (obvykle se tomu dává přednost)

            s = "";
            for (i = 0; i <= (10 * 2 * Math.PI); i++) {
                s = s + $"sin {Math.Round(i / 10.0, 2)} je {Math.Round(Math.Sin(i / 10.0), 4)}\n"; //Chr(9) je tabulátor}
            }
            Console.WriteLine(s);
        }
    }
}