using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.FileIO;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace F {

    internal class f06_den_v_tydnu {
        ////6) Funkce, které se předá číslo 1 až 7 a vrací slovně den v týdnu. Vytvořte variantu s } else { if i se Select Case.
        ////Moje poznámyk: byla potřeba udělat proměnnou "pom" v řešení?, ještě dal podmínku při chybě přímo do main(),
        //Function denSelect(hodnota byte) string
        //    Select Case hodnota
        //        Case 1
        //            denSelect = "Pondělí"
        //        Case 2
        //            denSelect = "Úterý"
        //        Case 3
        //            denSelect = "Středa"
        //        Case 4
        //            denSelect = "Čtvrtek"
        //        Case 5
        //            denSelect = "Pátek"
        //        Case 6
        //            denSelect = "Sobota"
        //        Case 7
        //            denSelect = "Neděle"
        //    End Select
        //End Function
        //Function den(hodnota byte) string
        //    if hodnota = 1 {
        //        den = "Pondělí"
        //    } else {if hodnota = 2 {
        //        den = "Úterý"
        //    } else {if hodnota = 3 {
        //        den = "Středa"
        //    } else {if hodnota = 4 {
        //        den = "Čtvrtek"
        //    } else {if hodnota = 5 {
        //        den = "Pátek"
        //    } else {if hodnota = 6 {
        //        den = "Sobota"
        //    } else {if hodnota = 7 {
        //        den = "Neděle"
        //    } else {
        //        den = "Chyba! Zadejte číslo od 1-7."
        //    }
        //End Function

        //    DenVtydnu byte

        //    DenVtydnu = Console.ReadLine();Console.WriteLine("Zadejte den v týdnu jako pořadí. Od 1-7. A já ti vypíšu, jaký je den")

        //    Console.WriteLine("Zadané pořadí: DenVtydnu)\n
        //            "Den(Select):  denSelect(DenVtydnu)\n
        //            "Den:  den(DenVtydnu))

        public static void Mainx() {
            //Řešení:
            //f6: Funkce, které se předá číslo 1 až 7 a vrací slovně den v týdnu. Vytvořte variantu s } else { if i se Select case.

            int cisloDne;

            Console.WriteLine("Zadej cislo dne (1-7)");
            cisloDne = int.Parse(Console.ReadLine());
            if (cisloDne < 1 || cisloDne > 7) {
                Console.WriteLine($"Špatně zadane cislo");
            }
            else {
                Console.WriteLine($"{DenVtydnu(cisloDne)}\n{DenVtydnuif(cisloDne)}");
            }

            static string DenVtydnu(int den) {
                switch (den) {
                    case 1: return "Pondeli";
                    case 2: return "Utery";
                    case 3: return "Streda";
                    case 4: return "Ctvrtek";
                    case 5: return "Patek";
                    case 6: return "Sobota";
                    case 7: return "Nedele";
                    default:
                        return "Neznám";
                }
            }

            static string DenVtydnuif(int i) {
                string pom = "";

                if (i == 1) {
                    pom = "pondeli";
                }
                else if (i == 2) {
                    pom = "utery";
                }
                else if (i == 3) {
                    pom = "streda";
                }
                else if (i == 4) {
                    pom = "ctvrtek";
                }
                else if (i == 5) {
                    pom = "patek";
                }
                else if (i == 6) {
                    pom = "sobota";
                }
                else if (i == 7) {
                    pom = "nedele";
                }
                return pom;
            }
        }
    }
}