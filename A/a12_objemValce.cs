using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A {
    internal class a12_objemValce {
        public static void Mainx() {
            //12) Sestavte program, který se zeptá na průměr vašeho kruhového bazénu a poté na jeho výšku(obojí v metrech). 
            //    Poté zobrazí, kolik tun vody se do něj vejde(1 m3 vody = 1 tuna). (program Doc.Homoly)

            double prumerBazenu, vyskaBazenu;

            Console.WriteLine("Sestavte program, který se zeptá na průměr vašeho kruhového bazénu a poté na jeho výšku(obojí v metrech). \r\n" +
                              "Poté zobrazí, kolik tun vody se do něj vejde(1 m3 vody = 1 tuna). (program Doc.Homoly)");
            Console.WriteLine("Napište průměr vašeho bazénu v metrech");
            prumerBazenu=double.Parse(Console.ReadLine());
            Console.WriteLine("Napište výšku bazénu v metrech");
            vyskaBazenu=double.Parse(Console.ReadLine());

            Console.WriteLine($"Do bazénu se vejde {Math.PI * Math.Pow(prumerBazenu,2) * vyskaBazenu:f} tun vody");
        }

    }
}
