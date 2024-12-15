using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.FileIO;

namespace C {
    internal class c09_delitelnost_prvocislo {
        

//9)  Těžší příklad, nepovinný: Zadejte z klávesnice celé kladné číslo větší než dvě, program vypíše všechny jeho dělitele, nepočítaje 1 a sebe sama (použij operátor modulo).
//Pokud žádný není, oznámí, že se jedná o prvočíslo. Pro kontrolu u čísla 12 jsou dělitele čísla: 2, 3, 4, 6. A číslo 13 je prvočíslo.
//Pozn.: dělitel nějakého čísla, je takové číslo, kterým je možno dělit beze zbytku. Takže trojka je dělitelem čísla 12, protože se do něj vejde přesně čtyřikrát.
//Zatímco pětka není dělitele čísla 12, protože se tam vejde dvakrát, ale zůstane zbytek 2.
//Nápověda: Je třeba ve smyčce spočítat počet dělitelů (tedy při každém nalezení dělitele zvýšit toto počitadlo o jedničku).
//A po smyčce zjistit, zda je počet nulový: v tom případě se jedná o prvočíslo.
//Moje poznámky: pro "i" jsem vydělil číslo 2, aby nebylo tolik opakování, v řešení je podmínka vyřešena lépe pomoci boolean, já jsem použil neomezené číslo a né jen 100,


    zadaneCislo int
    delitele string
    i int, prvocislo int


    zadaneCislo = Console.WriteLine(Zadejte kladné číslo větší než 2 a já ti vypíšu jeho dělitele nebo, že se jedná o prvočíslo")


    delitele = "Dělitele čísla" + zadaneCislo) + " je" + Chr(10)
    prvocislo = 0
    for i = 2 To zadaneCislo / 2
        if zadaneCislo % i = 0 {
            delitele = delitele + i) + Chr(10)
            prvocislo = prvocislo + 1
        } else {
        }
    Next


    if prvocislo = 0 {
        Console.WriteLine("Jedná se o prvočíslo")
    } else {
        Console.WriteLine(delitele)
    }


//Řešení:
//c09: Zadejte celé číslo (3 až 100), program vypíše všechny jeho dělitele, nepočítaje 1 a sebe sama
//(použij operátor modulo). Pokud žádný není, oznámí, že se jedná o prvočíslo

Sub main_reseni()
  cislo byte, i byte
  s string
  jePrvocislo bool


  jePrvocislo = True
  s = \"


  cislo = Console.WriteLine(Zadej cislo [3-100]", "Delitele cisla")
  for i = 2 To cislo - 1
      if(cislo % i) = 0 {
        s = s + i) + Chr(10)
        jePrvocislo = False
    }
  Next
  if jePrvocislo {
    Console.WriteLine("Je to prvočíslo"
  } else {
    MsgBox s, , "Delitele cisla jsou"
  }



    }
}
