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
    }
}