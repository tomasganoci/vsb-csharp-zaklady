using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.FileIO;

namespace B {

    internal class b03_jmenovatel_0 {

        public static void Mainx() {
            //b3)Úkolem je pro danou dvojici čísel x,y spočítat hodnotu výrazu 1 / (x * y)
            //Pokud by ale byl jmenovatel nulový, tak nepočítat (aby nedošlo k havárii programu), ale vypsat varovné hlášení.
            //moje poznámka: správně, jen jsem pouřil "||" místo *

            float x, y;

            Console.WriteLine("Úkolem je pro danou dvojici čísel x,y spočítat hodnotu výrazu 1 / (x * y) \n" +
                              "Pokud by ale byl jmenovatel nulový, tak nepočítat (aby nedošlo k havárii programu), ale vypsat varovné hlášení.\n");
            Console.WriteLine("Dosaď x");
            x = float.Parse(Console.ReadLine());
            Console.WriteLine("Dosať y");
            y = float.Parse(Console.ReadLine());

            if (x == 0 || y == 0) {
                Console.WriteLine("Jmenovatel nemůže být 0");
            }
            else {
                Console.WriteLine($"Výsledek je: {1 / (x * y)}");
            }
        }

        public static void Mainx_reseni() {
            //Řešení:
            //b03: Pro danou dvojici čísel x,y spočítejte hodnotu výrazu 1/(x.y).
            //Pokud by byl jmenovatel nulový, tak nepočítá, ale vypíše varovné hlášení.
            //

            float x, y;

            Console.WriteLine("Úkolem je pro danou dvojici čísel x,y spočítat hodnotu výrazu 1 / (x * y) \n" +
                              "Pokud by ale byl jmenovatel nulový, tak nepočítat (aby nedošlo k havárii programu), ale vypsat varovné hlášení.\n");
            Console.WriteLine("zadej x: ");
            x = float.Parse(Console.ReadLine());
            Console.WriteLine("zadej y: ");
            y = float.Parse(Console.ReadLine());
            if (x * y == 0) {
                Console.WriteLine("pozor jmenovatel(x*y)=0");
            }
            else {
                Console.WriteLine($"Vyraz  1/(x.y)  je roven {1 / (x * y)}");
            }
        }
    }
}