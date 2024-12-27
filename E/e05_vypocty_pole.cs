using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.FileIO;
using static System.Net.Mime.MediaTypeNames;

namespace E {

    internal class e05_vypocty_pole {
        ////5) Zadejte v jednom cyklu řadu čísel.
        ////V dalších cyklech program poté spočítá jejich součet, průměr, maximum, minimum.
        ////Pak se program ještě zeptá, zda chcete zobrazit součet druhých mocnin.
        ////Moje poznámky: chtěl jsem při zadání řešit "zadanéČíslo" randomem, abych to nemusel vypisovat,
        ////vkládat poslední index,

        //    Const pole = 99

        //    zadanaCisla, i, cislaPole(pole), pocetCisel, minCislo, maxCislo byte
        //    soucetCisel int
        //    prumerCisel float
        //    odpovedMocnina string
        //    soucetMocnin long

        //    Randomize
        //    for i = 0 To pole
        //        zadanaCisla = Int(Rnd()* (100 - 1 + 1) + 1)
        //        cislaPole[i] = zadanaCisla
        //        pocetCisel = pocetCisel + 1
        //    Next

        //    minCislo = cislaPole[0]
        //    maxCislo = cislaPole[0]

        //    for i = 0 To pole
        //        soucetCisel = soucetCisel + cislaPole[i]
        //        soucetMocnin = soucetMocnin + cislaPole[i] ^ 2
        //        if cislaPole[i] < minCislo {
        //            minCislo = cislaPole[i]
        //        } else {if cislaPole[i] > maxCislo {
        //            maxCislo = cislaPole[i]
        //        }
        //    Next

        //    prumerCisel = soucetCisel / pocetCisel

        //    Console.WriteLine("Součet: soucetCisel)\n
        //            "Průměr: prumerCisel)\n
        //            "Min: minCislo)\n
        //            "Max: maxCislo)\n)

        //    odpovedMocnina = Console.ReadLine();Console.WriteLine("Chcete zobrazit součet druhých mocnin? (A/N)")
        //    if odpovedMocnina = "A" {
        //        Console.WriteLine("Součet druhých mocnin: soucetMocnin))
        //    } else {
        //        Console.WriteLine("Ok, pro dnešek končím")
        //    }

        //Řešení:
        //e5: Zadejte v jednom cyklu řadu čísel. V dalším cyklu program poté spočítá jejich součet, průměr, maximum, minimum.
        //Pak se program ještě zeptá, zda chcete zobrazit součet druhých mocnin.
        public static void Mainx() {
            int[] cisla = new int[101];
            int zadaneCislo, soucet, max, min, pocetNe0, soucetMocnin, i, poslIndex; //poslIndex: index poslední buňky pole s platným číslem
            string s, volba;
            soucet = 0;
            soucetMocnin = 0;
            i = 0;
            s = "";

            do {
                Console.WriteLine("Zadej zadaneCislo, zadavani ukoncis cislem 0");
                zadaneCislo = int.Parse(Console.ReadLine());
                if (zadaneCislo != 0) {
                    s += $"\n{zadaneCislo}";
                    cisla[i] = zadaneCislo;
                    i++;
                }
            }
            while (zadaneCislo != 0);

            poslIndex = i;   //Tím se kompenzuje i++; za posledním číslerm
            max = cisla[0];
            min = cisla[0];

            for (i = 0; i < poslIndex; i++) {
                soucet += cisla[i];

                if (cisla[i] > max) {
                    max = cisla[i];
                }

                if (cisla[i] < min) {
                    min = cisla[i];
                }
                soucetMocnin += (int)Math.Pow(cisla[i], 2);
            }

            s += $"\nSoučet: {soucet}\nMaximum: {max}\nMinimum: {min}";
            Console.WriteLine($"Chcete zobrazit i součet druhých mocnin? (a/n)");
            volba = Console.ReadLine();
            if (volba == "a") {
                Console.WriteLine($"{s}\nSoučet 2.mocnin: {soucetMocnin}");
            }
            else {
                Console.WriteLine($"{s}");
            }
        }
    }
}