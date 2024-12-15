using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C {

    internal class c14_hvezdy {

        public static void Mainx() {
            //           Vytisknete na prvním řádku jednu hvězdu, na druhém dvě až do desátého.
            //Potom se začnou hvězdy ubírat.
            //Varianta: Totéž, ale na prvním řádku se vytisknou dvě hvězdy, na druhém
            //čtyři atd.
            //Varianta 2: Totéž, ale na prvnim i druhem řádku se vytiskne hvězda, na
            //třetím a čtvrtém dvě hvězdy atd.

            int pocet = 9;
            string hvezda = "";
            for (int i = 0; i < pocet; i++) {
                Console.WriteLine(hvezda += "*");
                for (int j = pocet; j == i; j--) {
                    Console.WriteLine(hvezda += "-");
                }
            }
        }
    }
}