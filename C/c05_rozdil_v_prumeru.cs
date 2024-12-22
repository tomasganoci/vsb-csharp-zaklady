using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.FileIO;
using static System.Net.Mime.MediaTypeNames;

namespace C {

    internal class c05_rozdil_v_prumeru {

        public static void Mainx() {
            //5)  Vygenerujte 20 celých náhodných celých čísel v rozsahu 10..50. Zjistěte, o kolik se jejich střední hodnota (průměr) liší od středu intervalu, tedy od 30.
            //Moje poznámky: doplněná větší mezera mezi čísly, doplněn v msgboxu index, v řešní je pouze průměr rozdílu v intervalu, já ho doplnil ke každému číslu, ještě doplním průměr rozdílu celkově

            double nahodneCislo;
            int scitaniRozdilu = 0;
            int rozdil = 0;
            int delitelPrumeru = 0;

            int min = 10;
            int max = 45;
            double prumerMinMax = (min + max) / 2;
            Random rand = new Random();

            string nahodneCisloRetezec = "";
            for (int i = 1; i < 21; i++) {
                nahodneCislo = rand.Next(min, max);
                rozdil = Convert.ToInt16(prumerMinMax - nahodneCislo);
                nahodneCisloRetezec += $"{i} číslo: {nahodneCislo}\tRozdíl: {rozdil}\n";
                scitaniRozdilu += + rozdil;
                delitelPrumeru += + 1;
            }
            Console.WriteLine($"Rozsah: {min} -> {max}\n" +
                              $"Průměr rozsahu: {prumerMinMax}" +
                              $"\n" +
                              $"{nahodneCisloRetezec}\n" +
                              $"Průměr od středu rozdílu: {scitaniRozdilu / delitelPrumeru}");
        }

        //Řešení:

        //c05: Vygenerujte 20 celých náhodných čísel v rozsahu 10..50.
        //Zjistěte, o kolik se jejich střední hodnota (průměr) liší od středu intervalu, tedy od 30.

        //      Sub main_reseni()
        //i byte, nah byte, rozsah byte
        //s string
        //sum int
        //rozdil float

        //sum = 0
        //s = "                     cislo"
        //rozsah = 50 - 10 + 1
        //for i = 1 To 20
        //  nah = Int(Rnd()* rozsah) + 10
        //  sum = sum + nah
        //  s = s + \n + i) + " cislo je        " + nah)
        //Next
        //rozdil = sum / 20 - 30
        //Console.WriteLine($"s + \n + "jejich prumer se lisi o  " + rozdil) + "  od stredu intervalu"
    }
}