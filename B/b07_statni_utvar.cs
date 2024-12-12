using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.FileIO;

namespace B {

    internal class b07_statni_utvar {

        public static void Mainx() {
            //b7)  Uživatel zadá letopočet (od roku 1600).
            //Program vrátí název státního útvaru, ve kterém jsme se tehdy nacházeli (Rakousko, Rakousko-Uhersko, Československá republika, Protektorát Böhmen und Mähren atd.).
            //Řešte pomocí } else { if.
            //moje poznámky: zadání nebylo úplné, tak jsem ho hledal na wikipedii, mám více podmínek "And",

            int letopocet;

            Console.WriteLine("Zadejte letopočet od roku 1600 do roku 2024 a já ti řeknu ve kterém státním útvaru jsme se nacházeli.");
            letopocet = int.Parse(Console.ReadLine());

            if (letopocet >= 1600 && letopocet < 1804) {
                Console.WriteLine("Nacházeli jsme se ve státním útvaru Habsburské monarchie.");
            }
            else if (letopocet >= 1804 && letopocet < 1867) {
                Console.WriteLine("Nacházeli jsme se ve státáním útvaru Rakouského císařství.");
            }
            else if (letopocet >= 1867 && letopocet < 1918) {
                Console.WriteLine("Nacházeli jsme se ve státáním útvaru Rakousko-Uhersko.");
            }
            else if (letopocet >= 1918 && letopocet < 1939 || letopocet >= 1945 && letopocet < 1960) {
                Console.WriteLine("Nacházeli jsme se ve státáním útvaru Československo.");
            }
            else if (letopocet >= 1939 && letopocet < 1945) {
                Console.WriteLine("Nacházeli jsme se ve státáním útvaru protektorát Čechy a Morava");
            }
            else if (letopocet >= 1960 && letopocet < 1969) {
                Console.WriteLine("Nacházeli jsme se ve státáním útvaru Českolovenská socialistická republika");
            }
            else if (letopocet >= 1969 && letopocet < 1990) {
                Console.WriteLine("Nacházeli jsme se ve státáním útvaru Česká socialistická republika");
            }
            else if (letopocet >= 1990 && letopocet < 1992) {
                Console.WriteLine("Nacházeli jsme se ve státáním útvaru Česká a Slovenská Federativní Republika");
            }
            else if (letopocet >= 1992 && letopocet < 2025) {
                Console.WriteLine("Nacházeli jsme se ve státáním útvaru Česká Republika");
            }
            else {
                Console.WriteLine("Zadal jsi menší letopočet než 1600");
            }
        }

        public static void Mainx_reseni() {
            //Řešení:
            //b07: Uživatel zadá letopočet(od roku 1600). Program vrátí název státního útvaru,
            //ve kterém jsme se tehdy nacházeli(Rakousko, Rakousko-Uhersko, Československá republika,
            //Protektorát Böhmen und Mähren atd.). Řešte pomocí } else { if.
            //    1526-1804 - Habsburska monarchie
            //    1804-1867 - Rakouske cisarstvi
            //    1867-1918 - Rakousko-Uhersko
            //    1918-1939 - Ceskoslovenska republika
            //    1939-1945 - Protektorat Cechy a Morava
            //    1945-1960 - Ceskoslovenska republika
            //    1960-1990 - Ceskoslovenska socialisticka republika
            //    1990-1992 - Ceska a Slovenska federativni republika
            //    1993- ?   - Ceska republika

            int rok;
            Console.WriteLine("Zadej letopocet[od r.1600 do současnosti]:");
            rok = int.Parse(Console.ReadLine());
            if (rok > 2017) {
                Console.WriteLine("BUDOUCNOST");
            }
            else if (rok >= 1993) {
                Console.WriteLine("Statni utvar byl Ceska republika");
            }
            else if (rok > 1990) {
                Console.WriteLine("Ceska a Slovenska federativni republika");
            }
            else if (rok == 1990) {
                Console.WriteLine("Statni utvar byl Ceska a Slovenska federativni republika i Ceskoslovenska socialisticka republika");
            }
            else if (rok > 1960) {
                Console.WriteLine("Statni utvar byl Ceskoslovenska socialisticka republika");
            }
            else if (rok == 1960) {
                Console.WriteLine("Statni utvar byl Ceskoslovenska socialisticka republika i Ceskoslovenska republika");
            }
            else if (rok > 1945) {
                Console.WriteLine("Statni utvar byl Ceskoslovenska republika");
            }
            else if (rok == 1945) {
                Console.WriteLine("Statni utvar byl Ceskoslovenska republika i Protektorat Cechy a Morava");
            }
            else if (rok > 1939) {
                Console.WriteLine("Statni utvar byl Protektorat Cechy a Morava");
            }
            else if (rok == 1939) {
                Console.WriteLine("Statni utvar byl Protektorat Cechy a Morava i Ceskoslovenska republika");
            }
            else if (rok > 1918) {
                Console.WriteLine("Statni utvar byl Ceskoslovenska republika");
            }
            else if (rok == 1918) {
                Console.WriteLine("Statni utvar byl Ceskoslovenska republika i Rakousko-Uhersko");
            }
            else if (rok > 1867) {
                Console.WriteLine("Statni utvar byl Rakousko-Uhersko");
            }
            else if (rok == 1867) {
                Console.WriteLine("Statni utvar byl Rakousko-Uhersko i Rakouske cisarstvi");
            }
            else if (rok > 1804) {
                Console.WriteLine("Statni utvar byl Rakouske cisarstvi");
            }
            else if (rok == 1804) {
                Console.WriteLine("Statni utvar byl Rakouske cisarstvi i Habsburska monarchie");
            }
            else if (rok >= 1600) {
                Console.WriteLine("Statni utvar byl Habsburska monarchie");
            }
            else {
                Console.WriteLine("zadal jsi mensi letopocet nez 1600");
            }
        }
    }
}