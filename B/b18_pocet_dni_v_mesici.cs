using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B {

    internal class b18_pocet_dni_v_mesici {

        public static void Mainx() {
            //18) Zadejte číslo měsíce (1 až 12). Program vypíše, kolik má měsíc dní (únor má zjednodušeně 28 dní). Proveďte pomocí if i case.
            Console.WriteLine("Zadejte číslo měsíce a já ti vypíšu, kolik má dní");
            Console.Write("Zadejte měsíc:");
            string zadanyMesic = Console.ReadLine();
            byte pocetDni = 0;

            switch (zadanyMesic.ToLower()) {
                case "leden":
                    pocetDni = 31;
                    break;

                case "únor":
                    pocetDni = 28;
                    break;

                case "březen":
                    pocetDni = 31;
                    break;

                case "duben":
                    pocetDni = 30;
                    break;

                case "květen":
                    pocetDni = 31;
                    break;

                case "červen":
                    pocetDni = 30;
                    break;

                case "červenec":
                    pocetDni = 31;
                    break;

                case "srpen":
                    pocetDni = 31;
                    break;

                case "záři":
                    pocetDni = 30;
                    break;

                case "říjen":
                    pocetDni = 31;
                    break;

                case "listopad":
                    pocetDni = 30;
                    break;

                case "prosinec":
                    pocetDni = 31;
                    break;

                default:
                    pocetDni = 0;
                    break;
            }
            if (pocetDni == 0)
                Console.WriteLine("Měsíc jsi napsal špatně. Použij i diakritiku");
            else
                Console.WriteLine($"Měsíc {zadanyMesic.ToUpper()} má {pocetDni}.");
        }
    }
}