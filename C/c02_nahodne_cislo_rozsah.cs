using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.FileIO;
using static System.Net.Mime.MediaTypeNames;

namespace C {

    internal class c02_nahodne_cislo_rozsah {

        public static void Mainx() {
            //2)  Program vygeneruje deset náhodných celých čísel (např. od -90 do 100). Zjistěte, kolik z nich je v určitém intervalu (např. od 10 do 50)
            //S algoritmizací tohoto programu si někteří účastníci nevědí rady. Pokud je to i váš případ, tak příklad zkuste nejprve vyřešit bez počítače.
            //Vezměte deset malých papírků na poznámky a napište na ně náhodně čísla od -90 do +100.
            //Nachystejte si i papír, který nadepíšete např. pocetCiselVIntervalu.
            //Potom vezměte první papírek, přečtěte jej,  a pokud je v rozsahu mezi 10 a 50, pak na papír nadepsaný pocetCiselVIntervalu napíšete čárku.
            //Toto proveďte 10x (tedy na jiný papír, nazvaný index, si děláte čárky a až jich bude 10, tak skončíte).
            //Poté slavnostně oznamte, kolik máte čárek na papíru pocetCiselVIntervalu. A pak to zkuste zapsat ve Visual Basicu.
            //Vlastně stačí následující popis převést do angličtiny:
            //Následující činnost proveď 10x (tedy zvyšuj při každém průchodu hodnotu proměnné index od 1 do 10):
            //    načtěte do proměnné (papírku) náhodné číslo v rozsahu <-90, 100>
            //    pokud je proměnná v rozsahu mezi 10 a 50, pak zvýšíte hodnotu proměnné pocetCiselVIntervalu o jedničku
            //konec opakované činnosti
            //oznamte hodnotu proměnné pocetCiselVIntervalu
            //Moje poznámky: nedoplnil jsem, jaké čísla byli v rozsahu, vzal jsem to hodně stručně, doplnil jsem vygenerované čísla (vygenerovaneCisla) a jeké čísla byli v rozsahu (cislaVRozsahu)

            double nahodneCislo;

            int min = -90;
            int max = 100;
            int pocetCiselVIntervalu = 0;
            string vygenerovaneCisla = "";
            string cislaVRozsahu = "";

            Random random = new Random();

            for (int i = 1; i <= 10; i++) {
                nahodneCislo = random.Next(min, max + 1);
                vygenerovaneCisla += $"{nahodneCislo}, ";
                if (nahodneCislo >= 10 && nahodneCislo <= 50) {
                    pocetCiselVIntervalu = pocetCiselVIntervalu + 1;
                    cislaVRozsahu += $"{nahodneCislo}, ";
                }
            }
            Console.WriteLine($"Rozmezí čísel: {min} -> {max}\n" +
                $"Vygenerovaná čísla: {vygenerovaneCisla}\n" +
                $"Čísla v rozmezí 10-50: {cislaVRozsahu}\n" +
                $"Počet čísel v rozmezí 10-50: {pocetCiselVIntervalu}");
        }

        public static void Mainx_reseni() {
            //Řešení:
            //c02) Program vygeneruje deset celých čísel (např. od -90 do 100).
            //Zjistěte, kolik z nich je v určitém intervalu (např. od 10 do 50)

            int i; /*rozsah;*/
            float nah;
            string s, e;
            Random random = new Random();

            s = "cislo v intervalu 10 az 50?";      // záhlaví
            //rozsah = 100 - (-90) + 1;
            for (i = 1; i < 10; i++) {
                e = "";
                nah = random.Next(-90, 100 + 1);
                if (nah >= 10 && nah <= 50) {
                    e = "ano"; // závorky by být použity nemusely, v jazycích rodiny C jsou ale povinno
                    s += $"\n {i} cislo je {nah}) (                ) {e}";
                }
            }

            Console.WriteLine(s);

            //      }
            //      public static void Mainx_reseni2() {
            //          Sub main_reseni2()         // další varianta
            //i byte, pocetVIntervalu byte, rozsah byte
            //nah float
            //s string
            //vIntervalu string  // výstupní text čísla jen v intervalu

            //pocetVIntervalu = 0
            //s = "Padla tato náhodná čísla: "
            //rozsah = 100 - (-90) + 1
            //vIntervalu = "V intervalu od 10 do 50 byla tato čísla: "
            //for i = 1 To 10
            //  nah = Int(Rnd() * rozsah) - 90
            //  if (nah >= 10 && nah <= 50) {
            //                  vIntervalu = vIntervalu + nah) +", "
            //    pocetVIntervalu = pocetVIntervalu + 1
            //  }
            //      s = s + nah) + ", "
            //Next
            //Console.WriteLine($"s + \n + vIntervalu + \n + "Tedy v intervalu 10..50 bylo celkem " + pocetVIntervalu) + " čísel"

            //      }

            //Špatné řešení.
            //
            //    nahodneCislo string
            //    max int, min int
            //    i byte, pocetCiselVIntervalu byte
            //
            //    min = -90
            //    max = 100
            //    nahodneCislo = "";
            //
            //    for i = 1 To 20
            //        nahodneCislo = nahodneCislo + "Index:" + i) + \n + "Náhodné číslo: " + Int(Rnd() * (max - min + 1) + min)) + \n
            //    Next i
            //    Console.WriteLine($"("Hodnoty min:" + min) + \n + "Hodnoty max:" + max) + \n + "Vzorec: Int(Rnd() * (max - min + 1) + min))" + \n + \n + nahodneCislo)
            //
        }
    }
}