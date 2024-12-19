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

            int pocet = 10;
            string hvezdy = "";
            for (int i = 1; i < pocet + 1; i++) {
                hvezdy = "";
                for (int j = 1; j <= i; j++) {
                    hvezdy += "*";
                }
                Console.WriteLine(hvezdy);
            }
            for (int i = hvezdy.Length - 1; i >= 0; i--) {
                hvezdy = hvezdy.Substring(0, i);
                Console.WriteLine(hvezdy);
            }
        }

        public static void Mainx_varianta1() {
            //           Vytisknete na prvním řádku jednu hvězdu, na druhém dvě až do desátého.
            //Potom se začnou hvězdy ubírat.
            //Varianta: Totéž, ale na prvním řádku se vytisknou dvě hvězdy, na druhém
            //čtyři atd.
            //Varianta 2: Totéž, ale na prvnim i druhem řádku se vytiskne hvězda, na
            //třetím a čtvrtém dvě hvězdy atd.

            int pocet = 10;
            string hvezdy = "";
            for (int i = 1; i < pocet; i += 2) {
                hvezdy = "";
                for (int j = 0; j <= i; j++) {
                    hvezdy += "*";
                }
                Console.WriteLine(hvezdy);
            }
            for (int i = hvezdy.Length-2; i >= 0; i -= 2) {
                hvezdy = hvezdy.Substring(0, i);
                Console.WriteLine(hvezdy);
            }
        }

        public static void Mainx_varianta2() {
            //Vytisknete na prvním řádku jednu hvězdu, na druhém dvě až do desátého.
            //Potom se začnou hvězdy ubírat.
            //Varianta: Totéž, ale na prvním řádku se vytisknou dvě hvězdy, na druhém
            //čtyři atd.
            //Varianta 2: Totéž, ale na prvnim i druhem řádku se vytiskne hvězda, na
            //třetím a čtvrtém dvě hvězdy atd.

            int pocet = 10;
            string hvezdy = "";
            for (int i = 0; i < pocet + 1; i++) {
                for (int j = 0; j < i; j++) {
                    hvezdy += "*";
                }
                Console.WriteLine(hvezdy);
            }
        }
    }
}