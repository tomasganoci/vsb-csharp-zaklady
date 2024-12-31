using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace F2 {

    internal class f2_01_uroceni {

        public static void Mainx() {
            //            !!!!!!Pozor: všechny příklady týkající se funkcí(sekce f1 i f2) je nutné umět velmi rychle převést na použití subrutiny.
            //Při použití subrutiny se řiďte postupem v kapitole Parametry volané odkazem a hodnotou.
            //Tedy měli byste rozumět, kdy před parametrem použít ByRef a kdy ByVal.
            //A i pro subrutinu platí totéž co pro funkci: měli byste výpočet nějakým způsobem dostat do hlavního programu a až tam vypsat.
            //Tedy NEPOUŽÍVAT v subrutině MsgBox.

            //    Předělejte co nejvíce z předchozích programů e) tak, aby používaly funkci.

            //1) Zadejte ve smyčce do pole úspory několika osob.
            //Poté se program zeptá, jaká je roční úroková míra.
            //Pole předejte funkci, která vrátí pole po započítání úroků.
            //Původní pole nesmí být voláním funkce ovlivněno(to platí i pro všechny další příklady).
            //chtěl jsem dodělat ještě jména... ale to by tvalo a nejlépe bych to dal do dvourozměrného pole.
            static double[] Uroceni(double[] poleCastek, double rocniUrok) {
                double[] vysledek = new double[poleCastek.Length];
                for (int i = 0; i < poleCastek.Length; i++) {
                    vysledek[i] = poleCastek[i] + (poleCastek[i] / 100 * rocniUrok);
                }
                return vysledek;
            }

            double[] poleNasporeno = new double[100];
            double zadaneUspory = 0.0;
            double zadanyUrok = 0.0;
            int zadanychCastek = 0;

            Console.WriteLine("Zadejte částky osob a já ti vypíšu kolik si naspoří. [Ukončete 0]");
            for (int i = 0; i < poleNasporeno.Length; i++) {
                Console.WriteLine($"Zadejte naspořenou částku pro osobu {i + 1}");
                zadaneUspory = double.Parse(Console.ReadLine());
                if (zadaneUspory == 0) {
                    break;
                }
                poleNasporeno[i] = zadaneUspory;
                zadanychCastek++;
            }
            Console.WriteLine("Zadejte roční úrok v %");
            zadanyUrok = double.Parse(Console.ReadLine());

            double[] omezenoPoleNasporeno = new double[zadanychCastek];
            Array.Copy(poleNasporeno, omezenoPoleNasporeno, zadanychCastek);

            double[] poleUroceni = new double[zadanychCastek];
            poleUroceni = Uroceni(omezenoPoleNasporeno, zadanyUrok);

            Console.WriteLine();
            for (int i = 0; i < poleUroceni.Length; i++) {
                Console.WriteLine($"Osoba {i + 1} má {poleUroceni[i]:f}");
            }
        }
    }
}