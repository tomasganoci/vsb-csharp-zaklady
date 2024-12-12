using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace B {

    internal class b14_ {

        public static void Mainx() {
            //            14) Zadejte a, b, c. Program vypočte kořeny kvadratické rovnice a*x ^ 2 + b * x + c = 0.
            //            Pokud si už ze školy nepamatujete, tak hledejte na Wikipedii heslo Diskriminant.
            //            Pozn.: na videu 034.MTS od desáté minuty to doc.Homola vysvětluje.
            //            Tento program je těžší, můžete jej nechat na později.
            //Teorie: Řešením jsou v závislosti na řešení diskriminantu D buď dvě různá čísla(při kladném D), nebo jeden dvojnásobný kořen(D = 0) nebo dvě komplexně sdružená čísla(při D < 0).
            //D = b2 - 4ac.

            //Tedy pro D = 0 bude řešením zdvojený kořen -b / 2a
            //Otestujte na následujících vzorových datech:
            //Dvě reálná řešení budou pro(x - 1)(x - 2) = X2 - 3x + 2, tedy parametry budou 1, -3, 2
            //Zdvojený kořen bude pro(x-2)(x - 2) = X2 - 4x + 4, tedy parametry budou 1, -4, 4
            //A komplexně sdružený kořen bude pro x2 + 2x + 3, tedy parametry 1, 2, 3, řešení pak bude
            //Pokud někdo výše uvedenému nerozumí(ani s pomocí výše uvedeného videa), tak program přeskočte.V kurzu nehraje matematika hlavní roli.


        }
    }
}