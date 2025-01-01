using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace F {

    internal class f12_cislo_dne_v_roce {

        public static void Mainx() {
            //            12) Sestavte funkci CisloDneVRoce, která má tři parametry: prvním je číslo dne, druhým číslo měsíce, třetím číslo roku včetně století.
            //            Výsledkem volání funkce je pořadové číslo zadaného dne v daném roce(nebo - 1, jestliže takové datum neexistuje).
            //            Uvažujte i přestupné roky.
            //            Funkci ověřte na zadání: sestavte program, který postupně načte den, měsíc a rok, a poté zobrazí, kolikátý den v roce to je.
            //            Vyzkoušejte i pro den = 32 nebo pro měsíc = 13.Dále vyzkoušejte pro[31 / 12 / 1900] a pro[31 / 12 / 2000].
            //            V programu využijete datový typ Date a funkce Weekday, WeekdayName a CDate
            //            Pozor, Excel považuje chybně rok 1900 za přestupný.
            //            Tento program je dost náročný, můžete si jej nechat na konec
            static int CisloDneVRoce(int den, int mesic, int rok) {
                try {
                    DateTime denVRoce = new DateTime(rok, mesic, den);
                    return denVRoce.DayOfYear;
                }
                catch (ArgumentOutOfRangeException) {
                    return -1;
                }
            }
            int zadanyDen = 0;
            int zadanyMesic = 0;
            int zadanyRok = 0;
            Console.WriteLine("Zadej den/měsic/rok a já ti řeknu, jaký má den pořadí.");
            Console.WriteLine("Zadejte den (číslo)");
            zadanyDen = int.Parse(Console.ReadLine());
            Console.WriteLine("Zadejte měsíc (číslo)");
            zadanyMesic = int.Parse(Console.ReadLine());
            Console.WriteLine("Zadejte rok");
            zadanyRok = int.Parse(Console.ReadLine());
            Console.WriteLine($"Podle tvého zadání {zadanyDen}.{zadanyMesic}.{zadanyRok} má den pořadí {CisloDneVRoce(zadanyDen, zadanyMesic, zadanyRok)}");
        }

        public static void Mainx_reseni(string[] args) {
            int den, mesic, rok;
            Console.WriteLine("Zadejte den, mesic a rok");
            int.TryParse(Console.ReadLine(), out den);
            int.TryParse(Console.ReadLine(), out mesic);
            int.TryParse(Console.ReadLine(), out rok);
            if (CisloDneS(den, mesic, rok) == 0.5) {
                Console.WriteLine("Zadali jste spatne datum");
            }
            else {
                Console.WriteLine("Pocet dnu od 31.12.1899 do {0}.{1}.{2} je {3}", den, mesic, rok, CisloDneS(den, mesic, rok));
            }
        }

        private static double CisloDneS(int dn, int mes, int r) {
            double cislo = 0;
            DateTime datum0 = new DateTime(1899, 12, 31);
            if (mes == 1 || mes == 3 || mes == 5 || mes == 7 || mes == 8 || mes == 10 || mes == 12) {
                if (dn > 31) {
                    cislo = 0.5;
                }
            }
            else if (mes == 4 || mes == 6 || mes == 9 || mes == 11) {
                if (dn > 30) {
                    cislo = 0.5;
                }
            }
            else if (mes == 2) {
                if (r % 100 == 0) {
                    if (r % 400 == 0) {
                        if (dn > 29) {
                            cislo = 0.5;
                        }
                    }
                    else {
                        if (dn > 28) {
                            cislo = 0.5;
                        }
                    }
                }
                else {
                    if (dn > 28) {
                        cislo = 0.5;
                    }
                }
            }
            else {
                cislo = 0.5;
            }
            if (cislo == 0) {
                DateTime datum = new DateTime(r, mes, dn);
                TimeSpan rozdil = datum - datum0;

                cislo = (rozdil.TotalDays);
            }

            return cislo;
        }
    }
}