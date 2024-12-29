using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E {
    internal class e13_posloupnost_nelinearnich {
        public static void Mainx() {
            //            13) Je dána posloupnost celých čísel(ne lineární, tedy čísla budou nějak na přeskáčku).
            //            Zjistěte, zda se v dané posloupnosti nějaké číslo opakuje. 
            //            Pozn.: 13b a 13c jsou těžké, je možno přeskočit
            int[] pole = new int[101];
            Random rnd = new Random();
            string vypisDuplicit = "";

            for (int i = 0; i < pole.Length; i++) {
                pole[i] = rnd.Next(1, 51);
                for (int j = 0; j < i; j++) {
                    if (pole[i] == pole[j]) {
                        vypisDuplicit = $"Ano. Jsou ve výpisu duplicity";
                    }
                }
            }
            Console.WriteLine(vypisDuplicit);
            
        }
        public static void Mainx_b() {
            //13 b) až to vyřešíte, vytvořte další program, kde zjistíte, která čísla se opakují.
            //zatím testuji
            int[] pole = new int[101];
            Random rnd = new Random();
            string vypisDuplicit = "";

            for (int i = 0; i < pole.Length; i++) {
                pole[i] = rnd.Next(1, 51);
                for (int j = 0; j < i; j++) {
                    if (pole[i] == pole[j]) {
                        vypisDuplicit += $"Duplicitní hodnota je {pole[j]} na pozici {j} a {i}\n";
                    }
                }
            }
            Console.WriteLine(vypisDuplicit);

        }
    }
    //public static void Mainx_c() {
    //    //13c) přidejte ještě informaci, kolikrát se opakují.
    //}
}
