using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E {

    internal class e14_serazeni_cisel_bubble {

        public static void Mainx() {
            //14) Vygenerujte deset celých čísel a setřiďte je.
            //Použijte např. algoritmus Bublinkového třídění(Bubble sort)
            int[] pole = new int[10];
            Random rnd = new Random();
            int bubble = 0;

            for (int i = 0; i < pole.Length; i++) {
                pole[i] = rnd.Next(1, 21);
            }
            for (int i = 0; i < pole.Length; i++) {
                for (int j = 0; j < pole.Length - 1; j++) {
                    if (pole[j] > pole[j + 1]) {
                        bubble = pole[j];
                        pole[j] = pole[j + 1];
                        pole[j + 1] = bubble;
                    }
                }
            }
            //Array.Sort(pole); //seřazení pomoci funkce Array.Sort
            for (int i = 0; i < pole.Length; i++) {
                Console.WriteLine(pole[i]);
            }
        }
    }
}