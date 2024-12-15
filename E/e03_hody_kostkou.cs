using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E {
    internal class e03_hody_kostkou {
        

//3) Vygenerujte několik hodů kostkou.
//Program vypíše, kolikrát padla jednotlivá čísla a vyjádří procentuálně.
//Jaký byl průměr? Návod: Dá se to udělat např. tak, že si deklaruji šest počitadel, např. pocet1, pocet2 až pocet6.
//A v druhé smyčce bude struktura if-} else { s šesti větvemi kde se bude zvyšovat o jedničku počitadlo pocet1 nebo pocet2 atd.
//Pro kontrolu: jejich součet musí být roven počtu hodů.
//Až to bude chodit, tak místo šesti proměnných pocet1 až pocet6 použít pole (nazvané např. pocty). Tedy jedná se o další pole.
//V jednom poli jsou všechny hody a v druhém poli je šest čísel s počtem četností jednotlivých hodnot.
//Druhá varianta: ověřte, že při zaokrouhlování pomocí Round padají krajní čísla (1 a 6) s poloviční četností.
//Přitom Int pracoval správně, všechny hodnoty mají kolem 100/6=16,6 %.
//Moje poznámky: v řešení je hned inicializace "cetnosti(i)",  ve for dal pocetHodu -1, zbytečně jsem udělal proměnnou hodKostkou
//               nemám vypsané všechny vygenerované čísla + je oddělil, počet hodů mám celý špatně, má t ovyřešené lépe,


    Const pole = 149


    hodKostkou byte, i byte, hodyKostkou(pole) byte, pocetHodu(1 To 6) byte, soucetPoctuHodu byte
    prumerHodu float
    soucetHoduKostkou int


    Randomize
    for i = 0 To pole
        hodKostkou = Int((Rnd()* (6 - 1 + 1) + 1))
        hodyKostkou(i) = hodKostkou
        soucetHoduKostkou = soucetHoduKostkou + hodyKostkou(i)
    Next

    for i = 0 To pole
        if hodyKostkou(i) = 1 {
            pocetHodu(1) = pocetHodu(1) + 1
        } else {if hodyKostkou(i) = 2 {
            pocetHodu(2) = pocetHodu(2) + 1
        } else {if hodyKostkou(i) = 3 {
            pocetHodu(3) = pocetHodu(3) + 1
        } else {if hodyKostkou(i) = 4 {
            pocetHodu(4) = pocetHodu(4) + 1
        } else {if hodyKostkou(i) = 5 {
            pocetHodu(5) = pocetHodu(5) + 1
        } else {if hodyKostkou(i) = 6 {
            pocetHodu(6) = pocetHodu(6) + 1
        }
    Next

    for i = 1 To 6
        soucetPoctuHodu = Round(soucetPoctuHodu + pocetHodu(i), 2)
    Next
    prumerHodu = soucetHoduKostkou / soucetPoctuHodu
     Console.WriteLine("Průměr hodů:" + prumerHodu) + Chr(10) + 
             "Hod 1:" + Round(pocetHodu(1) / soucetPoctuHodu* 100, 2)) + "%" + Chr(10) + 
             "Hod 2:" + Round(pocetHodu(2) / soucetPoctuHodu* 100, 2)) + Chr(10) + 
             "Hod 3:" + Round(pocetHodu(3) / soucetPoctuHodu* 100, 2)) + Chr(10) + 
             "Hod 4:" + Round(pocetHodu(4) / soucetPoctuHodu* 100, 2)) + Chr(10) + 
             "Hod 5:" + Round(pocetHodu(5) / soucetPoctuHodu* 100, 2)) + Chr(10) + 
             "Hod 6:" + Round(pocetHodu(6) / soucetPoctuHodu* 100, 2)) + Chr(10))


//e03) Vygenerujte několik hodů kostkou. Program vypíše,
//kolikrát padla jednotlivá čísla a vyjádří procentuálně. Jaký byl průměr?

main_reseni()
    Const pocetHodu int = 200:
    hody(pocetHodu - 1) int, cetnosti(6) int  //pozor, cetnosti zde má 7 buněk
    hod int, sumaHodu int, i int
    s1 string, s2 string
    s1 = \": s2 = \": sumaHodu = 0
    for i = 1 To 6
        cetnosti(i) = 0            //inicializace, nultá buňka se nevyužívá
    Next

    for i = 0 To pocetHodu - 1
        //hody(i) = Rnd() * 5 + 1        //toto zdánlivě funguje.Je ale špatně ukládat náhodné číslo typu Double do proměnné typu int
        //hody(i) = Round(Rnd() * 5) + 1 //zdánlivě funguje.Ale padá jedniček a šestek jen polovina toho, co ostatních
        //výsledkem Rnd() * 6 jsou čísla od 0 do 5,99999. Po odřezání desetinné části funkcí Int dostaneme celá čísla v rozsahu 0 až 5. Proto musíme ještě přičíst 1
        hody(i) = Int(Rnd() * 6) + 1
        sumaHodu = sumaHodu + hody(i)


        if i % 20 = 0 {
            s1 = s1 + vbCrLf + hody(i))  //odřádkuje se po každém 20. čísle
        } else {                                     //v ostatních případech se čísla oddělí jen mezerou
            s1 = s1 + " " + hody(i))     //místo " " lze i Chr(32), ale je to hůře srozumitelné
        }
    Next
    for i = 0 To pocetHodu - 1
        hod = hody(i)
        cetnosti(hod) = cetnosti(hod) + 1  //Toto není úplně košer, protože nultá buňka pole se nevyužívá. Lepší (ale méně pochopitelné) by bylo ukládat do cetnosti(hod - 1)
    Next
    for i = 1 To 6
        s2 = s2 + Chr(10) + "Cislo " + i) + " padlo " + cetnosti(i)) + " krat " + Chr(9) + cetnosti(i) / pocetHodu * 100) + "%"
    Next
    MsgBox s1 + vbCrLf + "Statistiky hodů:" + s2 + Chr(10) + "Průměrný hod má hodnotu:" + Chr(9) + sumaHodu / pocetHodu)



//Méně vhodné řešení, místo pole cetnosti jsou zde samostatné proměnné pro počty, kolikrát padly jednotlivé hodnoty (tedy jednicek, dvojek atd)
StatistikapocetHodu()
    hody(1000) byte
    i int, soucet int, jednicek int, dvojek int, trojek int, ctyrek int, petek int, sestek int, pocetHodu int
    Prumer float
    jednicek = 0: dvojek = 0: trojek = 0: ctyrek = 0: petek = 0: sestek = 0: soucet = 0
    
    pocetHodu = Console.WriteLine(kolikrat mam hodit kostkou?")
    for i = 0 To pocetHodu - 1
        //hody(i) = (Rnd() * 5) + 1      //je to špatně po formální stránce, ale hlavně padá jedniček a šestek jen polovina toho, co ostatních
        hody(i) = Int(Rnd()* 6) + 1
    Next i


    for i = 0 To pocetHodu - 1
        if hody(i) = 1 {
            jednicek = jednicek + 1
        } else {if hody(i) = 2 {
            dvojek = dvojek + 1
        } else {if hody(i) = 3 {
            trojek = trojek + 1
        } else {if hody(i) = 4 {
            ctyrek = ctyrek + 1
        } else {if hody(i) = 5 {
            petek = petek + 1
        } else {if hody(i) = 6 {
            sestek = sestek + 1
        }
        soucet = soucet + hody(i)
    Next i


    Prumer = Round(soucet / pocetHodu, 2)  //zaokrouhlení na 2 desetinná místa
    //Console.WriteLine("Statistika hozenych hodnot:\n1: " + str(jednicek) + "x = " + str(Round(jednicek / pocetHodu * 100, 2)) + "%\n2: " + str(dvojek) + "x = " + str(Round(dvojek / pocetHodu * 100, 2)) + "%\n3: " + str(trojek) + "x = " + str(Round(trojek / pocetHodu * 100, 2)) + "%\n4: " + str(ctyrek) + "x = " + str(Round(ctyrek / pocetHodu * 100, 2)) + "%\n5: " + str(petek) + "x = " + str(Round(petek / pocetHodu * 100, 2)) + "%\n6: " + str(sestek) + "x = " + str(Round(sestek / pocetHodu * 100, 2)) + "%\nPrumerna hozena hodnota je" + str(Prumer)   příliš dlouhé, špatně se v tom hledá chyba
    Console.WriteLine("Statistika hozenych hodnot:" + Chr(10) + 
    "1: " + jednicek) + "x = " + Round(jednicek / pocetHodu* 100, 2)) + "%" + Chr(10) + 
    "2: " + dvojek) + "x = " + Round(dvojek / pocetHodu* 100, 2)) + "%" + Chr(10) + 
    "3: " + trojek) + "x = " + Round(trojek / pocetHodu* 100, 2)) + "%" + Chr(10) + 
    "4: " + ctyrek) + "x = " + Round(ctyrek / pocetHodu* 100, 2)) + "%" + Chr(10) + 
    "5: " + petek) + "x = " + Round(petek / pocetHodu* 100, 2)) + "%" + Chr(10) + 
    "6: " + sestek) + "x = " + Round(sestek / pocetHodu* 100, 2)) + "%\nPrumerna hozena hodnota je" + Prumer)



    }
}
