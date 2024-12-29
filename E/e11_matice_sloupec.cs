using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E {
    internal class e11_matice_sloupec {
        public static void Mainx() {
            //            11) Program Doc. Homoly: Dvojrozměrné pole: Naplňte zadáním pole 4x4.
            //            Poté ji zobrazí překlopenou kolem hlavní diagonály(tedy prohodí indexy řádků a sloupců).Takže například místo pole:
            //            1  2  3  4
            //            5  6  7  8
            //            9 10 11 12
            //            13 14 15 16
            //            bude pole:
            //            1  5  9  13
            //            2  6  10 14
            //            3  7  11 15
            //            4  8  12 16
            int[,] pole = new int[4,4];
            int bunka = 1;


            for (int row = 0; row < pole.GetLength(0); row++) {
                for (int column = 0; column < pole.GetLength(1); column++) {
                    pole[row, column] = bunka;
                    Console.Write($"{pole[row, column]}\t");
                    bunka++;
                }
                Console.WriteLine();
            }
            bunka = 1;
            Console.WriteLine();
            for (int column = 0; column < pole.GetLength(1); column++) { 
                for (int row = 0;row < pole.GetLength(0); row++) {
                    pole[row, column] = bunka;
                    bunka++;
                }
            }
            for (int i = 0; i < pole.GetLength(0); i++) {
                for (int j = 0; j < pole.GetLength(1); j++) {
                    Console.Write(pole[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
