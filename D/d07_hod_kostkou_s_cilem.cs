using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.FileIO;

namespace D {

    internal class d07_hod_kostkou_s_cilem {

        public static void Mainx() {
            //7) Program hází kostkou tak dlouho, dokud nepadne šestka. Potom vypíše, kolik hodů bylo potřeba.
            //Moje poznámky: skoro stejné, až na vzorec hodu kostkou

            byte i;
            float hodKostkou;
            int ciloveCislo, min, max;
            string hozenaCisla;

            min = 1;
            max = 6;
            ciloveCislo = 6;

            Random random = new Random();
            hozenaCisla = "";
            i = 0;
            do {
                hodKostkou = (int)(random.NextDouble() * max)+1 ;
                hozenaCisla += $"{hodKostkou},";
                i++;
            }
            while (ciloveCislo != hodKostkou);
            Console.WriteLine($"Program musel hodit kostkou {i}x\n" +
                              $"Hozené čísla: {hozenaCisla}");
        }

        public static void Mainx_reseni() {
            //Řešení:

            //d07: Program hází kostkou tak dlouho, dokud nepadne šestka.
            //Potom vypíše, kolik hodů bylo potřeba.

            float nah;
            byte i;
            string s;

            i = 0;
            s = "";
            Random random = new Random();
            do {
                nah = (int)(random.NextDouble() * 6) + 1;
                s += $"{nah}, ";
                i++;
            }
            while (nah != 6);
            Console.WriteLine($"{s}\nŠestka padla na {i} pokus");
        }
    }
}