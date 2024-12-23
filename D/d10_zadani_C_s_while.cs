using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D {
    internal class d10_zadani_C_s_while {
        

//10) Vyzkoušejte všechny příklady c) s použitím  WHILE.




//1)  Vypište tabulku x funkce sinus(x) pro x od 0 do 2*PI s krokem 0,1. Výpis bude vypadat např. takto:
//Sin(0, 0) = 0
//sin(0,1) = 0,0998
//atd.
//Nevadí, když místo 0,0998 bude ,0998
//Moje poznámky: špatně jsem pochopil zadání a tak jsem nedal do 2* PI ale do 2. asi "krok" je lepší na pochopení, protože se liší od "index",

main_C01()
    sinus string
    krok float
    Const pi = 3.14159


    sinus = "";
    krok = 0
    do {
        sinus = sinus + "Sin ( Round((krok), 1))) =  Round(Sin(krok), 4))\n
        krok = krok + 0.1
    }  while ( krok <= 2.1
    Console.WriteLine("sinus)


//2)  Program vygeneruje deset náhodných celých čísel (např. od -90 do 100). Zjistěte, kolik z nich je v určitém intervalu (např. od 10 do 50)
//S algoritmizací tohoto programu si někteří účastníci nevědí rady. Pokud je to i váš případ, tak příklad zkuste nejprve vyřešit bez počítače.
//Vezměte deset malých papírků na poznámky a napište na ně náhodně čísla od -90 do +100.
//Nachystejte si i papír, který nadepíšete např. pocetCiselVIntervalu.
//Potom vezměte první papírek, přečtěte jej,  a pokud je v rozsahu mezi 10 a 50, pak na papír nadepsaný pocetCiselVIntervalu napíšete čárku.
//Toto proveďte 10x (tedy na jiný papír, nazvaný index, si děláte čárky a až jich bude 10, tak skončíte).
//Poté slavnostně oznamte, kolik máte čárek na papíru pocetCiselVIntervalu. A pak to zkuste zapsat ve Visual Basicu.
//Vlastně stačí následující popis převést do angličtiny:
//Následující činnost proveď 10x (tedy zvyšuj při každém průchodu hodnotu proměnné index od 1 do 10):
//    načtěte do proměnné (papírku) náhodné číslo v rozsahu <-90, 100>
//    pokud je proměnná v rozsahu mezi 10 a 50, pak zvýšíte hodnotu proměnné pocetCiselVIntervalu o jedničku
//konec opakované činnosti
//oznamte hodnotu proměnné pocetCiselVIntervalu
//Moje poznámky: nedoplnil jsem, jaké čísla byli v rozsahu, vzal jsem to hodně stručně, doplnil jsem vygenerované čísla (vygenerovaneCisla) a jeké čísla byli v rozsahu (cislaVRozsahu)

main_C02()
    nahodneCislo float
    min, max int
    i, pocetCiselVIntervalu byte
    vygenerovaneCisla, cislaVRozsahu string


    min = -90
    max = 100
    
    pocetCiselVIntervalu = 0
    i = 1
    do {
    nahodneCislo = Int(Rnd() * (max - min + 1) + min)
        vygenerovaneCisla = vygenerovaneCisla + nahodneCislo) + ", "
            if nahodneCislo >= 10  && nahodneCislo <= 50 {
                pocetCiselVIntervalu = pocetCiselVIntervalu + 1
                cislaVRozsahu = cislaVRozsahu + nahodneCislo) + ", "
            }
            i = i + 1
    }  while ( i <= 10
    Console.WriteLine("Rozmezí čísel:  min)-> max)\n
            "Vzorec: Int(Rnd() * (max - min + 1) + min)"\n
            Chr(10) + 
            "Vygenerovaná čísla:  vygenerovaneCisla\n
            "Čísla v rozmezí 10-50:  cislaVRozsahu\n
            "Počet čísel v rozmezí 10-50:  pocetCiselVIntervalu))


//3)  Vytvořte program, který táhne 5 čísel Sportky (čísla 1 až 49). Čísla se (na rozdíl od Sportky) mohou opakovat.
//Moje poznámky: dává rozsah už do proměnné, já dávám celý vzorec do smyčky,

main_C03()
    cisloSportky string
    i byte
    min, max int


    min = 1
    max = 49
    
    cisloSportky = "";
    i = 0
    do {
    cisloSportky = cisloSportky + Int(Rnd() * (max - min + 1) + min)) + ","
    i = i + 1
    }  while ( i <= 4
    Console.WriteLine("Rozsah:  min)-> max)\n
            "Tažených čísel: i)\n
            "Vzorec: Int(Rnd() * (max - min + 1) + min))"\n
            Chr(10) + 
            "Dnešní čísla ve sportce jsou: cisloSportky)


//4)  Vypište klesající posloupnost čísel od 8 do -8.  Varianta: vypište stejnou posloupnost, ale pouze každé druhé (sudé) číslo. (Nepoužívejte if.)
//Moje poznámky: jen jsem doplnil nadpis okna,

main_C04()
    i, min, max int
    klesajiciCislo, klesajiciSudeCislo string


    min = -8
    max = 8
    
    klesajiciCislo = "";
    i = 8
    do {
        klesajiciCislo = klesajiciCislo + i) + ", "
        i = i - 1
    }  while ( i >= -8
    
    klesajiciSudeCislo = "";
    i = 8
    do {
        klesajiciSudeCislo = klesajiciSudeCislo + i) + ", "
        i = i - 2
    }  while ( i >= -8
    
    Console.WriteLine("klesajiciCislo\n
            Chr(10) + 
            klesajiciSudeCislo), , "Posloupnost 8 až -8"




//5)  Vygenerujte 20 celých náhodných celých čísel v rozsahu 10..50. Zjistěte, o kolik se jejich střední hodnota (průměr) liší od středu intervalu, tedy od 30.
//Moje poznámky: doplněná větší mezera mezi čísly, doplněn v msgboxu index, v řešní je pouze průměr rozdílu v intervalu, já ho doplnil ke každému číslu, ještě doplním průměr rozdílu celkově

main_C05()
    nahodneCisloRetezec string
    min, max, prumerMinMax, nahodneCislo, scitaniRozdilu, rozdil int
    i, delitelPrumeru byte


    min = 10
    max = 50
    prumerMinMax = (min + max) / 2
    
    nahodneCisloRetezec = "";
    i = 1
    do {
        nahodneCislo = Rnd() * (max - min + 1) + min
        rozdil = prumerMinMax - nahodneCislo
        nahodneCisloRetezec = nahodneCisloRetezec + i)číslo: nahodneCislo)           Rozdíl: rozdil)\n
        scitaniRozdilu = scitaniRozdilu + rozdil
        delitelPrumeru = delitelPrumeru + 1
        i = i + 1
    }  while ( i <= 20
    
    Console.WriteLine("Rozsah: min) + "-> max)\n
            "Průměr rozsahu: prumerMinMax)\n
            Chr(10) + 
            nahodneCisloRetezec\n
            "Průměr od středu rozdílu:  scitaniRozdilu / delitelPrumeru))


//6)  Zadejte, kolik je tříd ve škole. Potom postupně zadávejte, kolik je v každé třídě žáků. Program spočítá, kolik je žáků v celé škole a průměrný počet žáků ve třídě. (obdoba d1)
//Moje poznámky: zase jsem nedoplnil jaká čísla byli zadané, v průměru jsem nepoužil zaokrouhlení,
main_C06()
    pocetTrid, pocetZaku, soucetZaku, prumerZaku int
    zakuVeTride string
    i byte

    pocetTrid = Console.ReadLine();Console.WriteLine("Zadejte počet tříd ve škole a já ti vypíšu, jaký je průměrný počet žáků na třídu.")


    soucetZaku = 0
    i = 1
    do {
        pocetZaku = Console.ReadLine();Console.WriteLine("Zadej pocet žáků ve třídě číslo i))
        soucetZaku = soucetZaku + pocetZaku
        zakuVeTride = zakuVeTride + i)třída " a žáku pocetZaku)\n
        i = i + 1
    }  while ( i <= pocetTrid

    Console.WriteLine("Ve škole je pocetTrid)tříd"\n
            zakuVeTride\n
            "Celkový počet žáků ve škole: soucetZaku)\n
            "Průměrný počet žáků ve třídách: Round(soucetZaku / pocetTrid, 2)))


//7)  Nasimulujte minutu po minutě kurz koruny k euru prvních dvacet minut po opuštění kurzového závazku ČNB. Bude oscilovat mezi 26 (včetně) a 28 (ne včetně) Kč/Euro.
//V MsgBoxu je vypište (pomocí %)  tak, že budou vždy po pěti na řádku (oddělené tabulátorem či čárkou nebo mezerou).
//Vypište s dvěma desetinnými čísly.
//Moje poznámky: Udělal jsem jinak podmínku. V řešení je to uděláno elegantněji. Doplnil jsem oproti řešení každou minutu a tím se to moc dobře nevleze na šířku msgBoxu.

main_C07()
    minuta string
    kurzEura, min, max float
    i byte


    min = 26
    max = 28
    
    minuta = "";
    i = 1
    do {
        kurzEura = Round(Rnd() * (max - min) + min, 2) //zaokrouhleno na 2 místa, odebráno ze vzorce +1,
        if i % 5 {
            minuta = minuta + i)min: kurzEura)"
        } else {
            minuta = minuta + i)min: kurzEura)\n
        }
        i = i + 1
    }  while ( i <= 20
    Console.WriteLine("minuta)



//8)  Zadej celé kladné číslo a pak program vypíše součet celých čísel od jedné do udaného čísla
//nepochopil jsem zadání, tak jsem to programoval špatně.

main_C08()
    zadaneCislo, i, soucetCisel int


    zadaneCislo = Console.ReadLine();Console.WriteLine("Zadejte kladné číslo, a já ti vypíšu součet celých čísel do zadaného čísla")
    soucetCisel = 0
    
    i = 1
    do {
        soucetCisel = soucetCisel + i
        i = i + 1
    }  while ( i <= zadaneCislo
    Console.WriteLine("Celkový součet zadaných čísel je: soucetCisel))


//9)  Těžší příklad, nepovinný: Zadejte z klávesnice celé kladné číslo větší než dvě, program vypíše všechny jeho dělitele, nepočítaje 1 a sebe sama (použij operátor modulo).
//Pokud žádný není, oznámí, že se jedná o prvočíslo. Pro kontrolu u čísla 12 jsou dělitele čísla: 2, 3, 4, 6. A číslo 13 je prvočíslo.
//Pozn.: dělitel nějakého čísla, je takové číslo, kterým je možno dělit beze zbytku. Takže trojka je dělitelem čísla 12, protože se do něj vejde přesně čtyřikrát.
//Zatímco pětka není dělitele čísla 12, protože se tam vejde dvakrát, ale zůstane zbytek 2.
//Nápověda: Je třeba ve smyčce spočítat počet dělitelů (tedy při každém nalezení dělitele zvýšit toto počitadlo o jedničku).
//A po smyčce zjistit, zda je počet nulový: v tom případě se jedná o prvočíslo.
//Moje poznámky: pro "i" jsem vydělil číslo 2, aby nebylo tolik opakování, v řešení je podmínka vyřešena lépe pomoci boolean, já jsem použil neomezené číslo a né jen 100,

main_C09()
    zadaneCislo int
    delitele string
    i, prvocislo int


    zadaneCislo = Console.ReadLine();Console.WriteLine("Zadejte kladné číslo větší než 2 a já ti vypíšu jeho dělitele nebo, že se jedná o prvočíslo")


    delitele = "Dělitele čísla zadaneCislo)je"\n
    prvocislo = 0
    i = 2
    do {
        if zadaneCislo % i = 0 {
            delitele = delitele + i)\n
            prvocislo = prvocislo + 1
        }
    i = i + 1
    }  while ( i <= zadaneCislo / 2
    
    if prvocislo = 0 {
        Console.WriteLine("Jedná se o prvočíslo")
    } else {
        Console.WriteLine("delitele)
    }

//10) Vytvořte program pro zkoušení malé násobilky. Program zadává náhodně násobení čísel od 1 do 10, např. 5*6=, 8*4= atd.
//Uživatel napíše výsledek. Pokud to je špatně, napíše počítač správný výsledek. Celkem 10 příkladů, nakonec se zobrazí počet chyb.
//Moje poznámky: v řeření je funkce "Randomize", neměl jsem přidaný "počet správných" výsledků
main_C10()
    pocetChyb, min, max, vysledekZadani, vysledek, pocetPrikladu int
    cislo1, cislo2 float
    i byte


    min = 1
    max = 10
    pocetPrikladu = 10
    
    pocetChyb = 0
    
    i = 1
    do {
        cislo1 = Int(Rnd() * (max - min + 1) + min)
        cislo2 = Int(Rnd()* (max - min + 1) + min)
        vysledekZadani = Console.ReadLine();Console.WriteLine("Příklad i)/ pocetPrikladu)\n
                                  "Příklad: cislo1)* cislo2)=")
        vysledek = cislo1* cislo2
        if(vysledekZadani = vysledek) {
            Console.WriteLine("Vygenerovan čísla: cislo1) + ",  cislo2)\n
            "Výsledek cislo1 * cislo2: vysledek)\n
            "Příklad číslo: i)\n
            Chr(10) + 
            "Tvůj výsledek je správný!!!")
        } else {
            pocetChyb = pocetChyb + 1
            Console.WriteLine("Vygenerovan čísla: cislo1) + ",  cislo2)\n
            "Výsledek cislo1 * cislo2: vysledek)\n
            "Příklad číslo: i)\n
            "Počet chyb: pocetChyb)\n
            Chr(10) + 
            "Tvůj výsledek vysledekZadani)je špatný!!!\nSprávný výsledek je vysledek))
        }
    i = i + 1
    }  while ( i <= pocetPrikladu
    Console.WriteLine("Rozsah: min) + "->  max)\n
            "Počet příkladů: i - 1)\n
            Chr(10) + 
            "Počet chyb: pocetChyb))


//11) Tabulka ASCII: zobrazit v  MsgBoxu v levém sloupci čísla např. 65 až 100 a v pravém příslušný znak.
//Moje poznámky: nemám "hlavičku", zapomněl jsem inicializaci asci,
main_C11()
    asci string
    i byte


    asci = "ASCII     znak"\n


    i = 65
    do {
        asci = asci + i)            Chr(i)\n
        i = i + 1
    }  while ( i <= 100
    Console.WriteLine("asci)


//Řešení:

//Vyzkoušejte všechny příklady c) s použitím  WHILE.

//01 Vypište tabulku funkce sinus od 0 do 2*PI s krokem 0,1.
//Aby bylo možno výsledek zkontrolovat, tak program musí mít jen jeden MsgBox,
//ve kterém budou všechna zadaná (či generovaná) čísla a poté výsledek.
main_reseni()
  krok float
  s string
  Const pi = 3.14159


  s = "";: krok = 0
  //for krok = 0 To 2 * PI Step 0.1
  do {
      s = s + "sin  Round(krok, 2)) + Chr(9) + "je  Round(Sin(krok), 4))\n
      krok = krok + 0.1                             //toto přidáno
  }  while ( krok <= 2 * pi
  Console.WriteLine($"s                                          //Nevypise se to cele


//Program vygeneruje deset celých čísel (např. od -100 do 100).
//Zjistěte, kolik z nich je v určitém intervalu (např. od 10 do 50)
main1_reseni()
  i, rozsah int
  nah float
  s, e string


  s = "                     cislo         v intervalu 10 az 50?"      // záhlaví
  i = 1
  
  rozsah = 100 - (-90) + 1
  //for i = 1 To 10
  do {
    e = "";
    nah = Int(Rnd()* rozsah) - 90
    if(nah >= 10 && nah <= 50) { e = "ano" // závorky by být použity nemusely, v jazycích rodiny C jsou ale povinno
    s = s\ni)cislo je         nah) + ("                ") + e
    i = i + 1                                     //toto přidáno
  }  while ( i <= 10
  
  Console.WriteLine($"s

//a tak dále...


    }
}
