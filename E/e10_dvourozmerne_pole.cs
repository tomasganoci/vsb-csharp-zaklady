using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E {

    internal class e10_dvourozmerne_pole {

        public static void Mainx() {
            //10) Program Doc. Homoly: Dvojrozměrné pole: Naplňte zadáním po řádcích pole 4x4.
            //Potom zjistěte minimum a zobrazte řádkové a sloupcové indexy buněk, na kterých se minimum nachází.
            // 1  2  3  4
            // 5  6  7  8
            // 9 10 11 12
            //13 14 15 16
            int[,] pole = new int[4, 4];

            for (int row = 0; row < pole.GetLength(0); row++) {
                for (int column = 0; column < pole.GetLength(1); column++) {
                    Console.Write($"{pole[row, column]}  ");
                }
                Console.WriteLine();
            }
        }
    }
}