using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E {
    internal class e12_sousedici_nizsi_hodnoty {
        public static void Mainx() {
            //            12) Program zjistí indexy všech lokálních maxim(tedy prvků pole, které sousedí s nižšími hodnotami, čili které mají vlevo i vpravo nižší hodnotu).
            //            Např.mějme pole:
            //1 2 3 1 5 6 7 4 3 2 6 5
            //Lokální maxima jsou 3, 7, 6
            //Moje poznámky: tento příklad mi trval nadměrně dlouho...
            int[] pole = { 1, 2, 3, 1, 5, 6, 7, 4, 3, 2, 6, 5 }; //{ 1, 2, 3, 1, 5, 6, 7, 4, 3, 2, 6, 5 };
            int meziNejnizsimi = 0;
            string vypisNejvyzsich = "";
            int hodnotaPole = 0;
            int predchoziHodnota = 0;
            int nasledujiciHodnota = 0;

            for (int i = 0; i < pole.Length; i++) {
                hodnotaPole = pole[i];
                if (i > 0) {
                    meziNejnizsimi=pole[i-1];
                }
                if (i > 1) {
                    predchoziHodnota = pole[i-2];
                }
                nasledujiciHodnota = hodnotaPole;
               if (meziNejnizsimi > predchoziHodnota & meziNejnizsimi > nasledujiciHodnota) {
                    vypisNejvyzsich += $"{meziNejnizsimi}, ";
                }
            }
            Console.WriteLine(vypisNejvyzsich);
        }
    }
}
