using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C {

    internal class c12_jamka_golf {

        public static void Mainx() {
            //12) Sestavte program, který za vás zahraje poslední úder do golfového míčku.
            //Stojíte 3 metry od jamky o průměru 10cm(tedy vzdálenost 2,95 až 3,05) a na ty 3 metry má vaše chvějící se ruka rozptyl ± 1m(tedy náhodná reálná čísla 2 až 4).
            //Kolikrát ze 100 úderů se strefíte? A na kolikátý pokus jste se poprvé strefili ? (program Doc.Homoly)
            bool prvniJamka = true;
            Random rnd = new Random();
            double vzdalenostUderu = 0;
            for (int i = 1; i < 101; i++) {
                vzdalenostUderu = Math.Round(rnd.NextDouble() * (4 - 2)+2,2); //vzdalenost v metrech
                if (vzdalenostUderu >= 2.95 & vzdalenostUderu <= 3.05) {
                     
                    if (prvniJamka == true) {
                        Console.WriteLine($"První jamka byla na {i} pokus.");
                    }
                    Console.WriteLine($"Trefa! Vzdálenost úderu:{vzdalenostUderu:f} a pokus č.: {i}");
                    prvniJamka = false;
                }
            }
        }
    }
}