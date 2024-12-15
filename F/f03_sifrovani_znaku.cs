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
        

//3)  Napište šifrovací funkci, které se předá písmeno a která vrátí následující písmeno v anglické abecedě.
//Tedy znak, jehož pozice v ASCII tabulce je o jedno vyšší S jedinou výjimkou: pro "z" vrátí "a".
//Poté program zdokonalte tak, aby se funkci předalo i číslo n a funkce pak v ASCII tabulce posouvá o n pozic.
//Tedy například pro n=2 převede: a->c, y->a, z->b
//Moje poznámky: Celý tento příklad byl pro mě složitější. Řešení od učitele je snadnější. Taky mě mohlo nadanout, posunutí zpět řady při "z". Ten "%" by mě nenapadl...

    zadanaHodnota string


    zadanaHodnota = Console.WriteLine(Zadejte znak a já ti ho zašifruji")


    Console.WriteLine("Zadaný znak: " + zadanaHodnota + Chr(10) + 
            "Tvoje šifrovací hodnota je: " + sifrovaniF(zadanaHodnota, 1))

Function sifrovaniF(hodnota string, n byte) string
    prevodASCII byte


    prevodASCII =c(hodnota)


    if prevodASCII >= 97  && prevodASCII <= 122 {
        if prevodASCII + n > 122 {
            sifrovaniF = (prevodASCII + n - 1) - 122 + 97
        } else {
            sifrovaniF = prevodASCII + n
        }
        sifrovaniF = Chr(sifrovaniF)
    } else {
        sifrovaniF = "Šifruji jen malá písmena"
    }
End Function

//Řešení:
//f03) Napište šifrovací funkci, které se předá znak a která vrátí následující znak v anglické abecedě.
//Tedy znak, jehož pozice v ASCII tabulce je o jedno vyšší (pro "z" vrátí "a").

main_reseni()
    zadanyZnak string, sifra string, sifraMalaIVelka string


    zadanyZnak = Console.WriteLine(Zadej znak!")
    sifra = SifrovaciFunkce(zadanyZnak)
    sifraMalaIVelka = SifrovaciFunkceMalaIVelka(zadanyZnak)
    Console.WriteLine("Sifra pro zadany znak " + zadanyZnak + " je znak " + sifra + ".", vbInformation
    Console.WriteLine("Sifra pro zadany znak " + zadanyZnak + " je znak " + sifraMalaIVelka + ".", vbInformation


Function SifrovaciFunkce(znak string) string
    if znak = "z" {                            //Aby mi "z" vracelo "a"!
        SifrovaciFunkce = Chr(Asc(znak) + 1 - 26) //26 je pocet pismen v abecede!
    } else {
        SifrovaciFunkce = Chr(Asc(znak) + 1)
    }
End Function
Function SifrovaciFunkceMalaIVelka(znak string) string   //dokonalejší verze, funguje i pro velká písmena a kontroluje, zda opravdu bylo zadáno písmeno
    if(znak >= "a"  && znak <= "y") ||(znak >= "A"  && znak <= "Y") {
        SifrovaciFunkceMalaIVelka = Chr(Asc(znak) + 1)
    } else {if znak = "z" || znak = "Z" {
        SifrovaciFunkceMalaIVelka = Chr(Asc(znak) + 1 - 26) //26 je pocet pismen v abecede!
    } else {
        SifrovaciFunkceMalaIVelka = "Nezadali jste písmeno - neplatný znak"
    }
End Function

//Poté program zdokonalte tak, aby se funkci předalo i číslo n a funkce pak v ASCII tabulce posouvá o n.

main1_reseni()
    znak string, sifra string, sifra% string
    posun byte


    znak = Console.WriteLine(Zadej znak!")
    posun = Console.WriteLine(Zadej posun!")
    sifra = SifrovaciFunkcePosun(znak, posun)
    Console.WriteLine("Sifra pro zadany znak " + znak + " je znak " + sifra + ".", vbInformation
    sifra% = SifrovaciFunkcePosun%(znak, posun)
    Console.WriteLine("Sifra pro zadany znak " + znak + " je znak " + sifra% + ".", vbInformation


Function SifrovaciFunkcePosun(zadanyZnak string, posunuti byte) string
    if(Asc(zadanyZnak) + posunuti) >c("z") {
        SifrovaciFunkcePosun = Chr(Asc(zadanyZnak) + posunuti - 26)
    } else {
        SifrovaciFunkcePosun = Chr(Asc(zadanyZnak) + posunuti)
    }
End Function

Function SifrovaciFunkcePosun%(zadanyZnak string, posun byte) string
  x byte, vysledek string
  x =c(zadanyZnak) -c("a")
  vysledek = ((x + posun) % 26) +c("a")
  SifrovaciFunkcePosun% = Chr(vysledek)
End Function
//tento program je lepší, funguje i při zadání velkého posunu

    }
}
