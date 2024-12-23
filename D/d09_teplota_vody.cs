using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.FileIO;

namespace D {

    internal class d09_teplota_vody {

        public static void Mainx_reseni_do_while() {
            //Řešení:

            //d09) Uživatel bude zadávat postupně teploty s přesností na desetinu stupně.
            //Zadávání ukončí zadáním teploty přesahující 100°
            //(tato teplota je ale také součástí dat!). Program zobrazí zadané teploty, minimální teplotu
            //a kolikátá v pořadí tato teplota byla. A také průměr teplot
            float teplota, minT, sum;
            byte i, poradi;
            string s;

            poradi = 0;
            i = 0;
            sum = 0;
            s = "";
            minT = 0;
            teplota = 0;

            Console.WriteLine("Zadej teplotu s přesností na desetinu stupně, teplota vetsi nez 100 zadavani ukonci");
            teplota = float.Parse(Console.ReadLine());
            if (i == 0) {
                minT = teplota;      //lepší by bylo inicializovat minimum před smyčkou
                poradi = 1;
            }
            s += $"\n{teplota}";
            i++;
            sum += teplota;
            while (teplota < 100) {
                //if teplota <= 100 {             //toto ne, protože i tentokrát poslední hodnota patří do platných dat                
                Console.WriteLine("Zadej teplotu s přesností na desetinu stupně, teplota vetsi nez 100 zadavani ukonci");
                teplota = float.Parse(Console.ReadLine());
                s += $"\n{teplota}";
                i++;
                sum += teplota;
                if (teplota < minT) {
                    minT = teplota;
                    poradi = i;
                }
            }
            //}
            //nebo }  while ( teplota <= 100

            s = $"Zadané teploty: {s}\nNejnižší je {minT}° a je {poradi} v pořadí.";
            Console.WriteLine($"{s}\nprůměrná teplota: {Math.Round(sum / i, 1)}");
        }

        public static void Mainx() {
            //9) Uživatel bude zadávat postupně teploty vody s přesností na desetinu stupně.
            //Zadávání ukončí zadáním teploty přesahující 100° (tato teplota je ale také součástí dat!).
            //Zadávání končí, protože pak už voda vyvřela.
            //Program zobrazí zadané teploty, minimální teplotu a kolikátá v pořadí tato teplota byla.
            //A také průměr teplot
            //Moje poznámky: pořadí jsem mohl vyřešit úplně jednoduše a nemusel jsem do toho tahat proměnnou "i", nedošlo mi, že už by nemělo být součásti dat teplota více než 100,

            float zadanaTeplota, minTeplota, soucetTeplot;
            string zadaneTeploty;
            byte i;
            int poradi;
            minTeplota = 0;
            poradi = 0;
            soucetTeplot = 0;

            zadaneTeploty = "";
            i = 0;
            do {
                Console.WriteLine("Zadejte postupně teplotu vody na desetinu stupně.\nJakmile voda vyvře, tak se ukončím.");
                zadanaTeplota = float.Parse(Console.ReadLine());
                zadaneTeploty += $"{Math.Round(zadanaTeplota, 1)}, ";
                if (i == 0) {
                    minTeplota = zadanaTeplota; //inizializace teploty
                    poradi++;
                }
                else {
                    if (zadanaTeplota < minTeplota) {
                        minTeplota = zadanaTeplota;
                        poradi++;
                    }
                }
                soucetTeplot += zadanaTeplota;
                i++;
            }
            while (soucetTeplot <= 100);

            Console.WriteLine($"Zadané hodnoty: {zadaneTeploty}\n" +
                              $"Minimální teplota: {Math.Round(minTeplota, 1)}\n" +
                              $"Pořadí minimální teploty: {poradi}\n" +
                              $"Průměr teplot: {Math.Round(soucetTeplot / i, 1)}");
        }

        public static void Mainx_reseni() {
            //Řešení:

            //d09) Uživatel bude zadávat postupně teploty s přesností na desetinu stupně.
            //Zadávání ukončí zadáním teploty přesahující 100°
            //(tato teplota je ale také součástí dat!). Program zobrazí zadané teploty, minimální teplotu
            //a kolikátá v pořadí tato teplota byla. A také průměr teplot
            float teplota, minT, sum;
            byte i, poradi;
            string s;

            poradi = 0;
            i = 0;
            sum = 0;
            s = "";
            minT = 0;
            do {
                Console.WriteLine("Zadej teplotu s přesností na desetinu stupně, teplota vetsi nez 100 zadavani ukonci");
                teplota = float.Parse(Console.ReadLine());
                if (i == 0) {
                    minT = teplota;      //lepší by bylo inicializovat minimum před smyčkou
                    poradi = 1;
                }
                //if teplota <= 100 {             //toto ne, protože i tentokrát poslední hodnota patří do platných dat
                s += $"\n{teplota}";
                i++;
                sum += teplota;
                if (teplota < minT) {
                    minT = teplota;
                    poradi = i;
                }
            }
            //}
            while (teplota < 100);  //nebo }  while ( teplota <= 100

            s = $"Zadané teploty: {s}\nNejnižší je {minT}° a je {poradi} v pořadí.";
            Console.WriteLine($"{s}\nprůměrná teplota: {Math.Round(sum / i, 1)}");
        }
    }
}