using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B {

    internal class b15_jak_je_venku {

        public static void Mainx() {
            //15) Program se zeptá, jak je venku, nabídne vám: úmorné vedro, zima, déšť, mlha, tma, chumelenice, atd.
            //Podle toho vám navrhne, co máte dělat, např. dobře se obléci, jít na plovárnu atd.
            //Nepoužívejte příkaz IF.

            Console.WriteLine("Jak je venku? Odpověz: \"úmorné vedro\", \"zima\", \"déšť\", \"mlha\", \"tma\", \"chumelenice\"");
            string odpoved = Console.ReadLine();

            switch (odpoved) {
                case "úmorné vedro":
                    Console.WriteLine("Namaž se opalovákem");
                    break;

                case "zima":
                    Console.WriteLine("Pořádně se obleč");
                    break;

                case "déšť":
                    Console.WriteLine("Vem si deštník");
                    break;

                case "mlha":
                    global::System.Console.WriteLine("Vem sebou reflexní prvky");
                    break;

                case "tma":
                    global::System.Console.WriteLine("Nezapomeň čelovku");
                    break;

                case "chumelenice":
                    global::System.Console.WriteLine("Vem si hard-shell");
                    break;

                default:
                    Console.WriteLine("Tuto odpověď neznám");
                    break;
            }
        }
    }
}