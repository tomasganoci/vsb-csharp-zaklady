using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.FileIO;

namespace B {

    internal class b12_slozena_podminka {

        public static void Mainx() {
            //b12_težší) Nejprve upravte program b12 z BasicCv.doc tak, aby program fungoval správně, ať už bude uživatel zadávat A či a(případně N nebo n).

            char denSvetlo, jeHorko;

            Console.WriteLine("Je venku ještě světlo ? (a / n)");
            denSvetlo = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Je venku horko ? (a / n)");
            jeHorko = Convert.ToChar(Console.ReadLine());

            if (denSvetlo == 'a' || denSvetlo == 'A' && jeHorko == 'a' || jeHorko == 'A') {
                Console.WriteLine("Tak si pojď zaplavat!");
            }
            else {
                Console.WriteLine("Tak raději zůstaň doma");
            }
        }

        public static void Mainx_VBA() {
            //b12) Program se zeptá, zda je den a zda je horko (odpověď a/n).
            //Pouze v případě obou odpovědí kladných vám navrhne jít si zaplavat.
            //Použijte jen jeden příkaz IF (ale se složenou podmínkou).
            //Předpokládejme, že uživatel bude uvědomněle zadávat malá písmena.
            //moje poznámky: nepočítal jsem při podmínkách s další možností a/n, nepočítám s možností, že by dal někdo velké písmeno,

            char denSvetlo, jeHorko;

            Console.WriteLine("Je venku ještě světlo ? (a / n)");
            denSvetlo = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Je venku horko ? (a / n)");
            jeHorko = Convert.ToChar(Console.ReadLine());

            if (denSvetlo == 'a' && jeHorko == 'a') {
                Console.WriteLine("Tak si pojď zaplavat!");
            }
            else {
                Console.WriteLine("Tak raději zůstaň doma");
            }
        }

        public static void Mainx_reseni() {
            //Řešení:
            //b12) Program se zeptá, zda je den a zda je horko.Pouze v případě obou odpovědí kladných vám navrhne jít si zaplavat.Použijte jen jeden příkaz IF(ale se složenou podmínkou).

            char jeDen, jeHorko;

            Console.WriteLine("Je den ? (a / n) ");
            jeDen = char.Parse(Console.ReadLine());
            Console.WriteLine("Je horko ? (a / n)");
            jeHorko = char.Parse(Console.ReadLine());

            if (jeDen == 'a' && jeHorko == 'a') {
                Console.WriteLine("Jdi si zaplavat");
            }
            else if (jeDen == 'a' && jeHorko == 'n') {
                Console.WriteLine("dnes neni dobre pocasi na plavani");
            }
            else if (jeDen == 'n') {
                Console.WriteLine("jdi spat, je noc");
            }
            else {
                Console.WriteLine("neplatna volba");
            }
        }

        public static void Mainx_reseni2() {
            //b12: Program se zeptá, zda je den a zda je horko.
            //    Pouze v případě obou odpovědí kladných vám navrhne jít si zaplavat.
            //    Použijte jen jeden příkaz IF(ale se složenou podmínkou).

            char den, h;
            Console.WriteLine("Je den?[A / N] ");
            den = char.Parse(Console.ReadLine());
            Console.WriteLine("je horko?[A / N] ");
            h = char.Parse(Console.ReadLine());
            if (den == 'A' || den == 'a' && h == 'A' || h == 'a') {
                Console.WriteLine("Bez si zaplavat");
            }
            else {
            }
        }
    }
}