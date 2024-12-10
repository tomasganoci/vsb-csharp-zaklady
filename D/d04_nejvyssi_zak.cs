using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.FileIO;

namespace D {
    internal class d04_nejvyssi_zak {
        

//4) Varianta na b5): Program postupně čte nejprve jméno a pak výšku žáka. Prázdné jméno načítání ukončuje.
//Poté zobrazí jméno a výšku nejvyššího žáka. Když jsou nejvyšší dva a více stejně vysocí, napíše jen jednoho.
//Bude zdokonaleno později v sekci e) v BasicCv_těžší
//Moje poznámky: neočetřil jsem situaci, kdy při prvním zadáni se nezadá jméno žáka a tím se program ukončí bez výsledku,
//                vstupy v řešení se udělali na začátku,

    jmeno string, zaci string, nejvyssiZak string
    vyska float, nejvyssi float


    zaci = \"
    Do
        jmeno = Console.WriteLine(Zadejte jméno žáka. Prazné pole program ukončuje.")
        if jmeno<> \" {
            vyska = Console.WriteLine(Zadejte výšku v cm a já ti řeknu, kdo je nejvyšší")
            zaci = zaci + "Jméno žáka: " + jmeno + " , Výška:" + vyska) + " cm" + Chr(10)
        }
        if vyska > nejvyssi {
            nejvyssi = vyska
            nejvyssiZak = "Nejvyšším žákem je " + jmeno + " s výškou" + nejvyssi) + " cm"
        }
    Loop Until jmeno = \"
    MsgBox (zaci + Chr(10) + nejvyssiZak)
    


//Řešení:

//d04: Varianta na B5: Program postupně čte nejprve jméno a pak výšku žáka.
//Prázdné jméno načítání ukončuje. Poté zobrazí jméno a výšku nejvyššího žáka.
//------ když nejvyšší jsou 2 a více, tak stačí, když napíše jen jednoho -------

Sub main_reseni()
  jmeno string, jmenoMax string
  vyska byte, vyskaMax byte
  zadanAsponJedenZak bool


  jmeno = Console.WriteLine(Zadej jméno žáka:")
  vyska = Console.WriteLine(Zadej výšku žáka [cm]:")
  jmenoMax = jmeno
  vyskaMax = vyska
  if jmeno = \" {
    zadanAsponJedenZak = False
  } else {
    zadanAsponJedenZak = True
  }


  Do Until jmeno = \"                    //Ukázka případu, kdy je vhodné dát podmínku na začátek cyklu
    jmeno = Console.WriteLine(Zadej jmeno zaka:")
    if jmeno<> \" {
      vyska = Console.WriteLine(Zadej vysku zaka [cm]:")
      if vyska > vyskaMax {
        vyskaMax = vyska
        jmenoMax = jmeno
      }
    }
  Loop
  if zadanAsponJedenZak = True {
    Console.WriteLine("Nejvyšší je " + jmenoMax + " s výškou " + vyskaMax) + " cm"
  } else {
    Console.WriteLine("Nebyl zadán žádný žák"
  }


    }
}
