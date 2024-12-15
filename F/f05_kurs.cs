using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.FileIO;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace F {
    internal class f05_kurs {
        

//5) Sestavte funkci Kurs, která má dva parametry: prvním je číslo ve významu korun, druhým je tříznakový řetězec ve významu kódu měny ("EUR", "USD", "GBP"), na kterou se tyto koruny mají vyměnit.
//Výsledkem volání funkce je částka v dané měně, rovnající se danému počtu korun (nebo hodnota -1, jestliže jde o měnu, pro kterou není kurs znám).
//Kurz bude ve funkci zadán "natvrdo", např. 27,35 pro euro. Tedy volat se tedy měla např. takto
//MsgBox kurs(273.5, "EUR")
//Vypsat by měla 10,0. Tedy že 273,5 Kč je 10 Euro.
//(program Doc. Homoly)
//Moje poznámky: víceméně stejné, jen jsem nedal podnímku, pokud bude výsledek -1, tak to vypíše chybu.

Function kurs(hodnota float, menaP string) float
    if menaP = "EUR" {
        kurs = hodnota / 27.35
    } else {if menaP = "USD" {
        kurs = hodnota / 20.1
    } else {if menaP = "GBP" {
        kurs = hodnota / 31.75
    } else {
        kurs = -1
    }
End Function


    koruny float
    mena string


    koruny = Console.WriteLine(Zadejte počet korun")
    mena = Console.WriteLine(Zadejte měnu: EUR, USD, GBP")


    Console.WriteLine("Počet korun:" + koruny) + Chr(10) + 
            "Zvolená měna: " + mena + Chr(10) + 
            "Přepočet:" + Round(kurs(koruny, mena), 2)))
    


//Řešení:
//Sestavte funkci Kurs, která má dva parametry: prvním je číslo ve významu korun, druhým je tříznakový řetězec ve významu kódu měny ("EUR", "USD", "GBP"), na kterou se tyto koruny mají vyměnit.
//Výsledkem volání funkce je částka v dané měně, rovnající se danému počtu korun (nebo hodnota -1, jestliže jde o měnu, pro kterou není kurs znám). (program Doc. Homoly)

main_reseni()
    kc int, castka float
    kodMeny string


    kc = Console.WriteLine(Zadej částku v Kč!")
    kodMeny = Console.WriteLine(Zadej kod meny! (EUR/USD/GBP)")
    castka = Round(prevodNaCiziMenu(kc, kodMeny), 2)
    if castka = -1 {
        Console.WriteLine("neznámá měna"
    } else {
        MsgBox kc) + ",- Kč =" + castka) + " " + kodMeny
    }


Function prevodNaCiziMenu(castkaVKc int, kodMeny string) float
    if kodMeny = "EUR" {
        prevodNaCiziMenu = castkaVKc / 26.23
    } else {if kodMeny = "USD" {
        prevodNaCiziMenu = castkaVKc / 18.71
    } else {if kodMeny = "GBP" {
        prevodNaCiziMenu = castkaVKc / 31.28
    } else {
        prevodNaCiziMenu = -1
    }
End Function



    }
}
