using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F2 {

    internal class f2_11_sifrovani_znaku {

        public static void Mainx() {
            //11) Obdoba f1-3 ale pro pole znaků. Tedy funkce má na vstupu pole znaků, které vrátí zašifrované

            static char[] SifrovaciFunkcePosun1(char[] zadanyZnak, int posun) {
                char[] vysledek = new char[zadanyZnak.Length];
                for (int i = 0; i < zadanyZnak.Length; i++) {
                    vysledek[i] = (char)((((zadanyZnak[i] - 'a') + posun) % 26) + 'a');
                }
                return vysledek;
            }

            char[] znakPole = new char[100];
            string znak;

            int zadanyPosun;
            int delkaPole = 0;

            for (int i = 0; i < znakPole.Length; i++) {
                Console.WriteLine("Zadej znak! [Ukonči prazdným zadáním]");
                znak = Console.ReadLine();
                if (znak == "") {
                    break;
                }
                znak = znak.ToLower();
                znakPole[i] = char.Parse(znak);
                delkaPole++;
            }

            Console.WriteLine("Zadej posun!");
            zadanyPosun = int.Parse(Console.ReadLine());

            char[] zmensenyZnakPole = new char[delkaPole];
            Array.Copy(znakPole, zmensenyZnakPole, delkaPole);

            char[] sifra1 = new char[delkaPole];
            sifra1 = SifrovaciFunkcePosun1(zmensenyZnakPole, zadanyPosun);

            for (int i = 0; i < sifra1.Length; i++) {
                Console.WriteLine($"Sifra pro zadany znak {zmensenyZnakPole[i]} je znak {sifra1[i]}.");
            }
        }
    }
}