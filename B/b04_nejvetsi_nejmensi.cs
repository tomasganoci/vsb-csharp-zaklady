using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.FileIO;

namespace B {

    internal class b04_nejvetsi_nejmensi {

        public static void Mainx() {
            //b4)  Zadejte tři čísla, počítač zjistí, které je největší a které nejmenší.
            //Aby program nebyl příliš dlouhý, tak nemusíte uvažovat případy, že by nějaká dvě čísla byla stejně velká.
            //Tento program je těžší, můžete jej nechat na později.
            //moje poznámka: proti řešení nemám proměnnou pro větší a menší číslo, které jsem neshloubil dohromady v "MsgBox".
            //               Druhé řešení je super. Je mnohem kratší a snadnější,
            //               mám přidané v druhém a třetím číslo ještě podmínku " &&"

            float cislo1, cislo2, cislo3;

            Console.WriteLine("Zadejte tři čísla, počítač zjistí, které je největší a které nejmenší.\r\n" +
                "Aby program nebyl příliš dlouhý, tak nemusíte uvažovat případy, že by nějaká dvě čísla byla stejně velká.\r\n" +
                "Tento program je těžší, můžete jej nechat na později.\n");
            Console.WriteLine("Zadejne první číslo.");
            cislo1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Zadejte druhé číslo.");
            cislo2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Zadejte třetí číslo.");
            cislo3 = float.Parse(Console.ReadLine());

            if (cislo1 > cislo2 && cislo1 > cislo3) {
                Console.WriteLine($"První číslo je největší: {cislo1}");
            }
            else if
                         (cislo2 > cislo3 && cislo2 > cislo1) {
                Console.WriteLine($"Druhé číslo je největší: {cislo2}");
            }
            else if
                            (cislo3 > cislo1 && cislo3 > cislo2) {
                Console.WriteLine($"Třetí číslo je největší: {cislo3}");
            }
            else {
                Console.WriteLine("Žádné číslo není největší");
            }

            if (cislo1 < cislo2 && cislo1 < cislo3) {
                Console.WriteLine($"První číslo je nejmenší: {cislo1}");
            }
            else if (cislo2 < cislo3 && cislo2 < cislo1) {
                Console.WriteLine($"Druhé číslo je nejmenší: {cislo2}");
            }
            else if (cislo3 < cislo1 && cislo3 < cislo2) {
                Console.WriteLine($"Třetí číslo je nejmenší: {cislo3}");
            }
            else {
                Console.WriteLine("Žádné číslo není nejmenší");
            }
        }

        public static void Mainx_reseni() {
            //Řešení:
            //b04: Zadejte tři čísla, počítač zjistí, které je největší a které nejmenší.
            //

            float a, b, c;
            string v, m;

            Console.WriteLine("Zadejte tři čísla, počítač zjistí, které je největší a které nejmenší.\r\n            //Aby program nebyl příliš dlouhý, tak nemusíte uvažovat případy, že by nějaká dvě čísla byla stejně velká.\r\n            //Tento program je těžší, můžete jej nechat na později.\n");
            Console.WriteLine("Zadej prvni cislo: ");
            a = float.Parse(Console.ReadLine());
            Console.WriteLine("Zadej druhe cislo: ");
            b = float.Parse(Console.ReadLine());
            Console.WriteLine("Zadej treti cislo: ");
            c = float.Parse(Console.ReadLine());

            if (a > b && a > c) {
                v = ("Prvni cislo je nejvetsi");
            }
            else if (b > c) {
                v = ("Druhe cislo je nejvetsi");
            }
            else if (c > b) {
                v = ("Treti cislo je nejvetsi");
            }
            else {
                v = ("Žádné číslo není největší");
            }
            if (a < b && a < c) {
                m = ("Prvni cislo je nejmensi");
            }
            else if (b < c) {
                m = ("Druhe cislo je nejmensi");
            }
            else if (c < b) {
                m = ("Treti cislo je nejmensi");
            }
            else {
                m = ("Žádné číslo není nejmenší");
            }
            Console.WriteLine($"{v}\n{m}");
        }

        public static void Mainx_reseni2() {
            //Následuje efektivnější algoritmus, obsahuje jen čtyři testování podmínek:
            //Sub main2()
            float a, b, c, max, min;

            Console.WriteLine("Zadej prvni cislo: ");
            a = float.Parse(Console.ReadLine());
            Console.WriteLine("Zadej druhe cislo: ");
            b = float.Parse(Console.ReadLine());
            Console.WriteLine("Zadej treti cislo: ");
            c = float.Parse(Console.ReadLine());

            max = a;

            min = a;

            if (b > max) {
                max = b;
            }
            if (c > max) {
                max = c;
            }
            if (b < min) {
                min = b;
            }
            if (c < min) {
                min = c;
            }
            Console.WriteLine($"Nejvetsi cislo je:{max}\nNejmensi cislo je: {min}");
        }

        public static void Mainx_reseni3() {
            //Další možnost

            float a, b, c, max, min;

            Console.WriteLine("Zadej prvni cislo: ");
            a = float.Parse(Console.ReadLine());
            Console.WriteLine("Zadej druhe cislo: ");
            b = float.Parse(Console.ReadLine());
            Console.WriteLine("Zadej treti cislo: ");
            c = float.Parse(Console.ReadLine());
            if (a > b) {
                max = a;
                min = b;
            }
            else {
                max = b;
                min = a;
            }
            if (c > max) {
                max = c;
            }
            else if (c < min) {
                min = c;
            }
            Console.WriteLine($"Nejvetsi cislo je:{max}\nNejmensi cislo je: {min}");
        }
    }
}
