using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E {

    internal class e10_matice_radky {

        public static void Mainx() {
            //10) Program Doc. Homoly: Dvojrozměrné pole: Naplňte zadáním po řádcích pole 4x4.
            //Potom zjistěte minimum a zobrazte řádkové a sloupcové indexy buněk, na kterých se minimum nachází.
            int[,] pole = new int[4, 4];
            int minimum = 0;
            bool prvniPruchod = true;
            string poleMinima = "";

            for (int row = 0; row < pole.GetLength(0); row++) {
                for (int column = 0; column < pole.GetLength(1); column++) {
                    Console.WriteLine($"Napište číslo do pole [{row}, {column}]. Maximum polí je [{pole.GetLength(0)}, {pole.GetLength(1)}].");
                    pole[row, column] = int.Parse(Console.ReadLine());
                    if (prvniPruchod) {
                        minimum = pole[row, column];
                        prvniPruchod = false;
                        poleMinima = $"[{row}, {column}]";
                    }
                }
                Console.WriteLine();
            }
            for (int i = 0; i < pole.GetLength(0); i++) {
                for (int j = 0; j < pole.GetLength(1); j++) {
                    Console.Write($"{pole[i, j]}\t");
                    if (pole[i, j] < minimum) {
                        minimum = pole[i, j];
                        poleMinima = $"[{i}, {j}]";
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine($"Minimum je {minimum} a je umístěno v poli {poleMinima}");
        }
    }
}