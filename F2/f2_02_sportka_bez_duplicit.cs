using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F2 {

    internal class f2_02_sportka_bez_duplicit {

        public static void Mainx() {
            //2) Stroj na losování Sazky se porouchal.
            //Tahal sice z osudí čísla 1 až 49, ale některá opakovaně.
            //Vytvořte funkci, které se předá pole takovýchto čísel, funkce pole vrátí očištěné od druhých a dalších výskytů opakujících se čísel(pro jednoduchost stačí, aby na jejich místě dosadila nulu).
            //Nevadí, že tedy může být ve výsledku méně čísel než požadovaných pět.
            static int[] SportkaBezDuplicit(int[] poleVylosovanychCisel) {
                int cislo = 0;
                for (int i = 0; i < poleVylosovanychCisel.Length; i++) {
                    for (int j = 0; j < poleVylosovanychCisel.Length; j++) {
                        if (i != j & poleVylosovanychCisel[i] == poleVylosovanychCisel[j]) {
                            poleVylosovanychCisel[i] = 0;
                        }
                    }
                }
                return poleVylosovanychCisel;
            }
            Random rnd = new Random();
            int[] vylosovanaCisla = new int[5];
            for (int i = 0; i < 5; i++) {
                vylosovanaCisla[i] = rnd.Next(1, 50);
            }
            int[] vylosovanaCislaBezDuplicit = new int[5];
            vylosovanaCislaBezDuplicit = SportkaBezDuplicit(vylosovanaCisla);

            foreach (int i in vylosovanaCislaBezDuplicit) {
                Console.WriteLine($"Vylosované číslo {i}");
            }
        }

        public static void Mainx_reseni() {
            int[] pole = new int[6];
            Random r = new Random();
            for (int i = 0; i < pole.Length; i++) {
                pole[i] = r.Next(1, 50);
            }
            Console.WriteLine("Tazena cisla {0} ", sportka(pole));
        }

        private static string sportka(int[] poleF) {
            Random r = new Random();
            int cislo = 0, n = 0;
            string tazena = "";
            bool m = false;
            //jeho ukolem je vygenorovat cislo(to vlastně děla funkce (generator)) a zjistit, zda-li se v poli cisel jiz toto cislo nevyskytuje, pokud ne, pak o priradi
            do {
                cislo = generator();            //volam funkci, aby vygenerovala cislo od 1 do 49
                foreach (int c in poleF)        //pro kazde cislo v poliF
                {
                    if (cislo != c)             //kdyz je vygenerovane cislo ruzne od cisla v poliF
                    {
                        m = true;
                    }
                    else {
                        m = false;              //ale kdyz tam najde shodne cislo, pak vyskoci z foreach a cely cyklus se opakuje, dokud neni vse true
                        break;
                    }
                }
            } while (m != true);                //provadej cyklus, dokud neni vse true
                                                //jeho ukolem je opakovat cyklus, dokud neni i=5, protoze prave tolik cisel chci vypsat
            do {
                for (int i = 0; i < poleF.Length - 1; i++)  //jeho ukolem je krokovat v polif znaky i,, tedy dvojty cyklus for na odhaleni opakujicich se znaku
                {
                    n++;            //pocitadlo
                    for (int j = i; j < poleF.Length - 1; j++)  // i a j jsou smycky, ktere prohlednou cele pole
                    {
                        if (poleF[i] == poleF[j + 1]) {
                            poleF[i] = cislo;               //kdyz najde shodu, zaplni ji vygenerovanym cislem z predchazejici smycky a opravi jej v polif
                        }
                    }
                    tazena = tazena + " " + poleF[i];       //zapise overene cislo do stringu
                                                            //tady je potreba provest znovu generaci nahodnoneho cislo, ktere se v poli nevyskytuje, protoze jinak by mi zusto furt jen jedlo cislo a sportka by pak byla na nic
                    do                                      //pokud neni vygenerovane cislo v poli cisel pak pokracuje
                    {
                        cislo = generator();
                        foreach (int c in poleF) {
                            if (cislo != c) {
                                m = true;
                            }
                            else {
                                m = false;
                                break;
                            }
                        }
                    } while (m != true);
                }
            } while (n != 5);                   //dokud neni pocitadlo rovno 5
            return tazena;
        }

        private static int generator()                  //klasicka funkce na generovani nahodnych cisel
        {
            Random r = new Random();
            int cislo = 0;
            cislo = r.Next(1, 50);
            return cislo;
        }
    }
}