using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace E {

    internal class e03_hody_kostkou {

        public static void Mainx() {
            //3) Vygenerujte několik hodů kostkou.
            //Program vypíše, kolikrát padla jednotlivá čísla a vyjádří procentuálně.
            //Jaký byl průměr? Návod: Dá se to udělat např. tak, že si deklaruji šest počitadel, např. pocet1, pocet2 až pocet6.
            //A v druhé smyčce bude struktura if-} else { s šesti větvemi kde se bude zvyšovat o jedničku počitadlo pocet1 nebo pocet2 atd.
            //Pro kontrolu: jejich součet musí být roven počtu hodů.
            //Až to bude chodit, tak místo šesti proměnných pocet1 až pocet6 použít pole (nazvané např. pocty). Tedy jedná se o další pole.
            //V jednom poli jsou všechny hody a v druhém poli je šest čísel s počtem četností jednotlivých hodnot.
            //Druhá varianta: ověřte, že při zaokrouhlování pomocí Round padají krajní čísla (1 a 6) s poloviční četností.
            //Přitom Int pracoval správně, všechny hodnoty mají kolem 100/6=16,6 %.
            //Moje poznámky: v řešení je hned inicializace "cetnosti[i]",  ve for dal pocetHodu -1, zbytečně jsem udělal proměnnou hodKostkou
            //               nemám vypsané všechny vygenerované čísla + je oddělil, počet hodů mám celý špatně, má t ovyřešené lépe,

            const byte pole = 149;

            byte[] hodyKostkou = new byte[150], pocetHodu = new byte [7];
            byte hodKostkou, i;
            double soucetPoctuHodu;
            double prumerHodu;
            int soucetHoduKostkou = 0;

            soucetPoctuHodu = 0;
            hodKostkou = 0;
            Random rnd = new Random();

            for (i = 1; i < pole; i++){
                hodKostkou = Convert.ToByte(rnd.Next(1, 7));
            hodyKostkou[i] = hodKostkou;
                soucetHoduKostkou += hodyKostkou[i];
            }

            for (i = 1; i < pole; i++){
                if (hodyKostkou[i] == 1) {
                    pocetHodu[1]++;
                }
                else if (hodyKostkou[i] == 2) {
                    pocetHodu[2]++;
                }
                else if (hodyKostkou[i] == 3) {
                    pocetHodu[3]++;
                }
                else if (hodyKostkou[i] == 4) {
                    pocetHodu[4]++;
                }
                else if (hodyKostkou[i] == 5) {
                    pocetHodu[5]++;
                }
                else if (hodyKostkou[i] == 6) {
                    pocetHodu[6]++;
                }
}{
            for (i = 1; i < 6; i++)
                soucetPoctuHodu = Math.Round(soucetPoctuHodu + pocetHodu[i], 2);
                prumerHodu = soucetHoduKostkou / soucetPoctuHodu;
            }
            Console.WriteLine($"Průměr hodů: {prumerHodu}\n" +
                    $"Hod 1: {Math.Round(pocetHodu[1] / soucetPoctuHodu * 100, 2)}%\n" +
                    $"Hod 2: {Math.Round(pocetHodu[2] / soucetPoctuHodu * 100, 2)}\n" +
                    $"Hod 3: {Math.Round(pocetHodu[3] / soucetPoctuHodu * 100, 2)}\n" +
                    $"Hod 4: {Math.Round(pocetHodu[4] / soucetPoctuHodu * 100, 2)}\n" +
                    $"Hod 5: {Math.Round(pocetHodu[5] / soucetPoctuHodu * 100, 2)}\n" +
                    $"Hod 6: {Math.Round(pocetHodu[6] / soucetPoctuHodu * 100, 2)}\n");
        }

        //        public static void Mainx_reseni() {
        //            //e03) Vygenerujte několik hodů kostkou. Program vypíše,
        //            //kolikrát padla jednotlivá čísla a vyjádří procentuálně. Jaký byl průměr?

        //            main_reseni()
        //    Const pocetHodu int = 200:
        //    hody(pocetHodu - 1), cetnosti[6] int  //pozor, cetnosti zde má 7 buněk
        //    hod, sumaHodu, i int
        //    s1, s2 string
        //    s1 = "";: s2 = "";: sumaHodu = 0
        //    for i = 1 To 6
        //        cetnosti[i] = 0            //inicializace, nultá buňka se nevyužívá
        //    Next

        //    for i = 0 To pocetHodu - 1
        //        //hody[i] = Rnd() * 5 + 1        //toto zdánlivě funguje.Je ale špatně ukládat náhodné číslo typu double do proměnné typu int
        //        //hody[i] = Round(Rnd() * 5) + 1 //zdánlivě funguje.Ale padá jedniček a šestek jen polovina toho, co ostatních
        //        //výsledkem Rnd() * 6 jsou čísla od 0 do 5,99999. Po odřezání desetinné části funkcí Int dostaneme celá čísla v rozsahu 0 až 5. Proto musíme ještě přičíst 1
        //        hody[i] = Int(Rnd() * 6) + 1
        //        sumaHodu = sumaHodu + hody[i]

        //        if i % 20 = 0 {
        //                        s1 = s1 + vbCrLf + hody[i])  //odřádkuje se po každém 20. čísle
        //        } else {                                     //v ostatních případech se čísla oddělí jen mezerou
        //            s1 = private s1 hody[i])     //místo " " lze i Chr(32), ale je to hůře srozumitelné
        //        }

        //    Next
        //    for i = 0 To pocetHodu - 1
        //        hod = hody[i]
        //        cetnosti(hod) = cetnosti(hod) + 1  //Toto není úplně košer, protože nultá buňka pole se nevyužívá. Lepší (ale méně pochopitelné) by bylo ukládat do cetnosti(hod - 1)
        //    Next
        //    for i = 1 To 6
        //        s2 = s2\n"Cislo  i)padlo  cetnosti[i])krat  Chr(9) + cetnosti[i] / pocetHodu * 100) + "%"
        //    Next
        //    Console.WriteLine($"s1 + vbCrLf + "Statistiky hodů: s2\n"Průměrný hod má hodnotu: Chr(9) + sumaHodu / pocetHodu)
        //        }

        //public static void Mainx_reseni2() {
        //    //Méně vhodné řešení, místo pole cetnosti jsou zde samostatné proměnné pro počty, kolikrát padly jednotlivé hodnoty (tedy jednicek, dvojek atd)
        //    StatistikapocetHodu()
        //    hody(1000) byte
        //    i, soucet, jednicek, dvojek, trojek, ctyrek, petek, sestek, pocetHodu int
        //    Prumer float
        //    jednicek = 0: dvojek = 0: trojek = 0: ctyrek = 0: petek = 0: sestek = 0: soucet = 0

        //    pocetHodu = Console.ReadLine(); Console.WriteLine("kolikrat mam hodit kostkou?")
        //    for i = 0 To pocetHodu - 1
        //        //hody[i] = (Rnd() * 5) + 1      //je to špatně po formální stránce, ale hlavně padá jedniček a šestek jen polovina toho, co ostatních
        //        hody[i] = Int(Rnd() * 6) + 1
        //    Next i

        //    for i = 0 To pocetHodu - 1
        //        if hody[i] = 1 {
        //            jednicek = jednicek + 1
        //        }
        //        else {
        //            if hody[i] = 2 {
        //                dvojek = dvojek + 1
        //        }
        //            else {
        //                if hody[i] = 3 {
        //                    trojek = trojek + 1
        //        }
        //                else {
        //                    if hody[i] = 4 {
        //                        ctyrek = ctyrek + 1
        //        }
        //                    else {
        //                        if hody[i] = 5 {
        //                            petek = petek + 1
        //        }
        //                        else {
        //                            if hody[i] = 6 {
        //                                sestek = sestek + 1
        //        }
        //                            soucet = soucet + hody[i]
        //    Next i

        //    Prumer = Round(soucet / pocetHodu, 2)  //zaokrouhlení na 2 desetinná místa
        //    //Console.WriteLine("Statistika hozenych hodnot:\n1:  str(jednicek) + "x =  str(Round(jednicek / pocetHodu * 100, 2)) + "%\n2:  str(dvojek) + "x =  str(Round(dvojek / pocetHodu * 100, 2)) + "%\n3:  str(trojek) + "x =  str(Round(trojek / pocetHodu * 100, 2)) + "%\n4:  str(ctyrek) + "x =  str(Round(ctyrek / pocetHodu * 100, 2)) + "%\n5:  str(petek) + "x =  str(Round(petek / pocetHodu * 100, 2)) + "%\n6:  str(sestek) + "x =  str(Round(sestek / pocetHodu * 100, 2)) + "%\nPrumerna hozena hodnota je str(Prumer)   příliš dlouhé, špatně se v tom hledá chyba
        //    Console.WriteLine("Statistika hozenych hodnot:"\n
        //    "1:  jednicek) + "x = Round(jednicek / pocetHodu * 100, 2)) + "%"\n
        //    "2:  dvojek) + "x = Round(dvojek / pocetHodu * 100, 2)) +"%"\n
        //    "3:  trojek) + "x =  Round(trojek / pocetHodu* 100, 2)) + "%"\n
        //    "4:  ctyrek) + "x =  Round(ctyrek / pocetHodu* 100, 2)) + "%"\n
        //    "5:  petek) + "x =  Round(petek / pocetHodu* 100, 2)) + "%"\n
        //    "6:  sestek) + "x =  Round(sestek / pocetHodu* 100, 2)) + "%\nPrumerna hozena hodnota je Prumer)
        //}
    }
}