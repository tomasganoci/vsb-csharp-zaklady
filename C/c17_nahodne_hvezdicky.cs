using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C {

    internal class c17_nahodne_hvezdicky {

        public static void Mainx() {
            //17) Počítač popíše 20 řádků náhodným počtem hvězdiček.
            //(použijte vnořenou smyčku)
            Random random = new Random();
            int nahodneCislo = 0;
            string hvezdicky = "";
            for (int i = 0; i < 21; i++) {
                hvezdicky = "";
                nahodneCislo = random.Next(1, 11);
                for (int j = 0; j < nahodneCislo; j++) {
                    hvezdicky += "*";
                }
                Console.WriteLine(hvezdicky);
            }
        }
    }
}