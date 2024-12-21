using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace C {

    internal class c18_prvocisla {

        public static void Mainx() {
            //18) Program vypíše všechna prvočísla do čísla 1000.
            //Prvočísla jsou čísla dělitelná jen jedničkou a sama sebou.
            //(použij modulo)
            int prvoCislo = 0;
            for (int i = 1000; i >= 2; i--) {
                prvoCislo = 0;
                for (int j = 2; j <= i; ++j) {
                    if (i % j == 0) {
                        prvoCislo += 1;
                    }
                }
                if (prvoCislo == 1) {
                    Console.WriteLine($"Číslo {i} je prvočíslo");
                }
            }
        }
    }
}