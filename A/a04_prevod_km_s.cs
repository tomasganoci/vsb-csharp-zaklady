using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.FileIO;

namespace A {
    internal class a04_prevod_km_s {
        public static void Mainx() {

            //a4) Zadejte rychlost v m/s a převeďte na km/hod.

            long mZaSek;
            float kmZaHod; //mZaSek = m/s, kmZaHod = km/h

            Console.WriteLine("Zadejte rychlost v m/s a převeďte na km/hod.");
            Console.WriteLine("Zadejte rychlost v m/s a já ti to převedu na km/h");
            mZaSek = long.Parse(Console.ReadLine());
            kmZaHod = (mZaSek * 60) * 60 / 1000;

            
            Console.WriteLine($"Podle mých výpočtů je to {kmZaHod} km/h"); //Šlo by to jednodušeni Str(mZaSek * 3.6)
    }
        public static void Mainx_reseni() {
            //Řešení:

            //a04: Zadejte rychlost v m/ s a převeďte na km/ hod.

            float v;

            Console.WriteLine("zadej rychlost(m / s): ");
            v = float.Parse(Console.ReadLine());
            Console.WriteLine($"Rychlost je:  {v * 3.6} km/h");


        }
    }
}
