using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace F2 {

    internal class f2_03_subrutina {

        public static void Mainx() {
            //3) Cvičení na subrutinu: Napište subrutinu, která vytiskne řádek obsahující N znaků Z.
            //Údaje N a Z jsou vstupními parametry subrutiny.
            //Pozn.: toto nelze provést jako funkci!
            //Pozn.: použití MsgB ox v subrutině či funkci je výjimečné, nepoužívejte tento postup v jiných programech.
            //nechápu co se po mě chce. Nechápu tento úkol. Snad je to srpávně podle zadání...

            static void TiskRadku(int N, char Z) {
                char[] poleZnaku = new char[N];
                string vypis = "";
                for (int i = 0; i < N; i++) {
                    poleZnaku[i] = Z;
                    vypis += poleZnaku[i];
                }
                Console.WriteLine(vypis);
            }
            int pocetZnaku = 0;
            char znak = 'A';
            Console.WriteLine("Zadáte znak a počet znaků a já ti to vypíšu");
            Console.WriteLine("Zadejte znak");
            znak = char.Parse(Console.ReadLine());
            Console.WriteLine("Zadejte počet");
            pocetZnaku = int.Parse(Console.ReadLine());

            TiskRadku(pocetZnaku, znak);
        }
    }
}