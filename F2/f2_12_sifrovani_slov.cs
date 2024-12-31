using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F2 {

    internal class f2_12_sifrovani_slov {

        public static void Mainx() {
            //12) ještě zbývá procvičit funkci, která má na vstupu pole stringů.
            //Takže naprogramujte variantu na f2 - 11, ale funkci se bude předávat několik stringů(tedy několik slov).
            //Funkce slova vrátí zašifrovaná.

            static string[] SifrovaniSlova(string[] zadaneSlova, int posun) {
                string spojeniZnaku = "";
                char znak = 'a';
                string[] vysledek = new string[zadaneSlova.Length];
                for (int i = 0; i < zadaneSlova.Length; i++) {
                    for (int j = 0; j < zadaneSlova[i].Length; j++) {
                        znak = char.Parse(zadaneSlova[i].Substring(j, 1));

                        spojeniZnaku += (char)((((znak - 'a') + posun) % 26) + 'a');
                    }
                    vysledek[i] = spojeniZnaku;
                    spojeniZnaku = "";
                }

                return vysledek;
            }

            string[] slovaPole = new string[100];
            string slovo;

            int zadanyPosun;
            int delkaPole = 0;

            for (int i = 0; i < slovaPole.Length; i++) {
                Console.WriteLine("Zadej slovo! [Ukonči prazdným zadáním]");
                slovo = Console.ReadLine();
                if (slovo == "") {
                    break;
                }
                slovo = slovo.ToLower();
                slovaPole[i] = slovo;
                delkaPole++;
            }

            Console.WriteLine("Zadej posun!");
            zadanyPosun = int.Parse(Console.ReadLine());

            string[] zmensenySlovaPole = new string[delkaPole];
            Array.Copy(slovaPole, zmensenySlovaPole, delkaPole);

            string[] sifra1 = new string[delkaPole];
            sifra1 = SifrovaniSlova(zmensenySlovaPole, zadanyPosun);
            Console.WriteLine();
            for (int i = 0; i < sifra1.Length; i++) {
                Console.WriteLine($"Sifra pro zadany znak {zmensenySlovaPole[i]} je znak {sifra1[i]}.");
            }
        }
    }
}