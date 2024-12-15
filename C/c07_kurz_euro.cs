using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.FileIO;
using static System.Net.Mime.MediaTypeNames;

namespace C {
    internal class c07_kurz_euro {
        

//7)  Nasimulujte minutu po minutě kurz koruny k euru prvních dvacet minut po opuštění kurzového závazku ČNB. Bude oscilovat mezi 26 (včetně) a 28 (ne včetně) Kč/Euro.
//V MsgBoxu je vypište (pomocí %)  tak, že budou vždy po pěti na řádku (oddělené tabulátorem či čárkou nebo mezerou).
//Vypište s dvěma desetinnými čísly.
//Moje poznámky: Udělal jsem jinak podmínku. V řešení je to uděláno elegantněji. Doplnil jsem oproti řešení každou minutu a tím se to moc dobře nevleze na šířku msgBoxu.


    minuta string
    kurzEura float, min float, max float
    i byte


    min = 26
    max = 28
    
    minuta = \"
    for i = 1 To 20
        kurzEura = Round(Rnd()* (max - min) + min, 2) //zaokrouhleno na 2 místa, odebráno ze vzorce +1,
        if i % 5 {
            minuta = minuta + i) + " min:" + kurzEura) + " "
        } else {
            minuta = minuta + i) + " min:" + kurzEura) + Chr(10)
        }
    Next
    Console.WriteLine(minuta)


//Řešení:
//c07: Použití modulo (tedy operátor %): Nasimulujte minutu po minutě kurz koruny k euru prvních dvacet minut
//po opuštění kurzového závazku ČNB. Bude oscilovat mezi 26 (včetně) a 28 (ne včetně) Kč/Euro.
//V MsgBoxu je vypište tak, že budou vždy po pěti na řádku (oddělené tabulátorem).

Sub main_reseni()
  i byte
  nah float
  s string
  s = \"
 
  for i = 1 To 20
    nah = Round(Rnd()* 2 + 26, 2)
    s = s + nah) + Chr(9)
    if i % 5 = 0 { s = s + Chr(10)
  Next
  MsgBox s


 //7b) Pokud je příklad 7) moc těžký, tak zkuste nejprve jednodušší úkol: Ve smyčce for jdoucí od 1 do 20 vypisujte počitadlo (tedy postupně 1 až 20).
 //Ale ne všechna čísla na jednom řádku nebo všechna čísla pod sebou, nýbrž takto:
//1 2 3 4 5
//6 7 8 9 10
//11 12 13 14 15
//16 17 18 19 20
//Odřádkování řešte pomocí operátoru %. Tedy zeptáte se, zda je právě pořadí čísla dělitelné pěti. A pokud ano, tak odřádkujete.
//Moje poznámky: udělal jsem kód v podmínce, zatímco v řešení je v podmínce pouze nový řádek. Doplnil jsem chr(9) a upravil jsem podmínku

 Sub main_7b()
    i byte
    cislo string


    cislo = \"
    for i = 1 To 20
        cislo = cislo + i) + Chr(9)
            if i % 5 = 0 {
                cislo = cislo + Chr(10)
            }
    Next
    Console.WriteLine(cislo)
 
 
//Řešení:
//7b) Pokud je příklad 7) moc těžký, tak zkuste nejprve jednodušší úkol: Ve smyčce for jdoucí od 1 do 20
//vypisujte počitadlo (tedy postupně 1 až 20). Ale ne všechna čísla na jednom řádku nebo všechna čísla pod sebou, nýbrž takto:

Sub main_7b_reseni()
  i byte
  nah float
  s string
  s = \"
 
  for i = 1 To 20
    s = s + i) + Chr(9)
    if i % 5 = 0 { s = s + Chr(10)
  Next
  MsgBox s



    }
}
