using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B {

    internal class b16_vyber_operatoru {

        public static void Mainx() {
            //16) Uživatel zadá dvě čísla. Poté se objeví nabídka, zda chce sčítat, odčítat, násobit, dělit nebo končit.
            //Poté se objeví výsledek vybrané operace se zadanými čísly nebo program skončí.

            Console.WriteLine("Zadejte dvě čísla a potom se zobrazí nabídka operací");
            Console.WriteLine("Zadejte první číslo");
            double prvniCislo = double.Parse(Console.ReadLine());
            Console.WriteLine("Zadejte druhé číslo");
            double druheCislo = double.Parse(Console.ReadLine());
            Console.WriteLine("Napiš, co chceš dělat. \"sčítat\", \"odčítat\", \"násobit\", \"dělit\", \"ukončit\"");
            string operace = Console.ReadLine();

            switch (operace) {
                case "sčítat":
                case "+":
                    Console.WriteLine($"Součtem čísel {prvniCislo} a {druheCislo} je {prvniCislo + druheCislo}");
                    break;

                case "odčítat":
                case "-":
                    Console.WriteLine($"Odečet čísel {prvniCislo} a {druheCislo} je {prvniCislo - druheCislo}");
                    break;

                case "násobit":
                case "*":
                    Console.WriteLine($"Násobek čísel {prvniCislo} a {druheCislo} je {prvniCislo * druheCislo}");
                    break;

                case "dělit":
                case "/":
                    Console.WriteLine($"Děleno čísel {prvniCislo} a {druheCislo} je {prvniCislo / druheCislo}");
                    break;

                default:
                    Console.WriteLine("Tento operátor neznám");
                    break;
            }
        }
    }
}