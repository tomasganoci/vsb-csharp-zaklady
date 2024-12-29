using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.FileIO;
using Microsoft.VisualBasic;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace F {

    internal class f03_sifrovani_znaku {
        ////3)  Napište šifrovací funkci, které se předá písmeno a která vrátí následující písmeno v anglické abecedě.
        ////Tedy znak, jehož pozice v ASCII tabulce je o jedno vyšší S jedinou výjimkou: pro "z" vrátí "a".
        ////Poté program zdokonalte tak, aby se funkci předalo i číslo n a funkce pak v ASCII tabulce posouvá o n pozic.
        ////Tedy například pro n=2 převede: a->c, y->a, z->b
        ////Moje poznámky: Celý tento příklad byl pro mě složitější. Řešení od učitele je snadnější. Taky mě mohlo nadanout, posunutí zpět řady při "z". Ten "%" by mě nenapadl...

        //    zadanaHodnota string

        //    zadanaHodnota = Console.ReadLine();Console.WriteLine("Zadejte znak a já ti ho zašifruji")

        //    Console.WriteLine("Zadaný znak:  zadanaHodnota\n
        //            "Tvoje šifrovací hodnota je:  sifrovaniF(zadanaHodnota, 1))

        //Function sifrovaniF(hodnota, n byte) string
        //    prevodASCII byte

        //    prevodASCII =c(hodnota)

        //    if prevodASCII >= 97  && prevodASCII <= 122 {
        //        if prevodASCII + n > 122 {
        //            sifrovaniF = (prevodASCII + n - 1) - 122 + 97
        //        } else {
        //            sifrovaniF = prevodASCII + n
        //        }
        //        sifrovaniF = Chr(sifrovaniF)
        //    } else {
        //        sifrovaniF = "Šifruji jen malá písmena"
        //    }
        //End Function

        //tento program je lepší, funguje i při zadání velkého posunu
        ////Řešení:
        ////f03) Napište šifrovací funkci, které se předá znak a která vrátí následující znak v anglické abecedě.
        ////Tedy znak, jehož pozice v ASCII tabulce je o jedno vyšší (pro "z" vrátí "a").

        //main_reseni()
        //    zadanyZnak, sifra, sifraMalaIVelka string

        //    zadanyZnak = Console.ReadLine();Console.WriteLine("Zadej znak!")
        //    sifra = SifrovaciFunkce(zadanyZnak)
        //    sifraMalaIVelka = SifrovaciFunkceMalaIVelka(zadanyZnak)
        //    Console.WriteLine("Sifra pro zadany znak  zadanyZnakje znak  sifra + ".", vbInformation
        //    Console.WriteLine("Sifra pro zadany znak  zadanyZnakje znak  sifraMalaIVelka + ".", vbInformation

        //Function SifrovaciFunkce(znak string) string
        //    if znak = "z" {                            //Aby mi "z" vracelo "a"!
        //        SifrovaciFunkce = Chr(Asc(znak) + 1 - 26) //26 je pocet pismen v abecede!
        //    } else {
        //        SifrovaciFunkce = Chr(Asc(znak) + 1)
        //    }
        //End Function
        //Function SifrovaciFunkceMalaIVelka(znak string) string   //dokonalejší verze, funguje i pro velká písmena a kontroluje, zda opravdu bylo zadáno písmeno
        //    if(znak >= "a"  && znak <= "y") ||(znak >= "A"  && znak <= "Y") {
        //        SifrovaciFunkceMalaIVelka = Chr(Asc(znak) + 1)
        //    } else {if znak = "z" || znak = "Z" {
        //        SifrovaciFunkceMalaIVelka = Chr(Asc(znak) + 1 - 26) //26 je pocet pismen v abecede!
        //    } else {
        //        SifrovaciFunkceMalaIVelka = "Nezadali jste písmeno - neplatný znak"
        //    }
        //End Function

        //Poté program zdokonalte tak, aby se funkci předalo i číslo n a funkce pak v ASCII tabulce posouvá o n.

        public static void Mainx() {
            char znak, sifra, sifra1;
            int posun;

            Console.WriteLine("Zadej znak!");
            znak = char.Parse(Console.ReadLine());
            Console.WriteLine("Zadej posun!");
            posun = int.Parse(Console.ReadLine());
            sifra = SifrovaciFunkcePosun(znak, posun);
            Console.WriteLine($"Sifra pro zadany znak {znak} je znak {sifra}.");

            sifra1 = SifrovaciFunkcePosun1(znak, posun);

            Console.WriteLine($"Sifra pro zadany znak {znak} je znak {sifra1}.");

            static char SifrovaciFunkcePosun(char zadanyZnak, int posunuti) {
                if (zadanyZnak + posunuti > 'z') {
                    return (char)(zadanyZnak + posunuti - 26);
                }
                else {
                    return (char)(zadanyZnak + posunuti);
                }
            }

            static char SifrovaciFunkcePosun1(char zadanyZnak, int posun) {
                char vysledek;
                int x;
                x = zadanyZnak - 'a';
                vysledek = (char)(((x + posun) % 26) + 'a');
                return vysledek;
            }
        }
    }
}