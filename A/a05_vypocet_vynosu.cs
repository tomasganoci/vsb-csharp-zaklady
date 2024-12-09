using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.FileIO;

namespace A {

    internal class a05_vypocet_vynosu {

        public static void Mainx() {
            //a5)Zadejte částku peněz, které jsou uloženy v bance, roční úrok a délku uložení (počet roků).
            //Vypočítejte, kolik bude v bance po uplynutí uvedené doby.
            //Nepočítejte úroky z úroků. Modelový příklad: 1000 Kč na 2 roky s úrokem 1 % ročně = 1020 Kč

            float rocniUrok, nasporenaCastka, vynosZaRok, vynosCelkem;
            byte pocetRoku;

            Console.WriteLine("Zadej cílovou naspořenou částku");
            nasporenaCastka = long.Parse(Console.ReadLine());
            rocniUrok = 1;
            Console.WriteLine("Zadejte, kolik let chcete spořít");
            pocetRoku = byte.Parse(Console.ReadLine());

            vynosZaRok = nasporenaCastka / 100 * rocniUrok;
            vynosCelkem = nasporenaCastka + pocetRoku * vynosZaRok;

            Console.WriteLine($"Částku {vynosCelkem:c} by jste měl naspořit.");
        }

        public static void Mainx_reseni() {
            //Řešení:
            //a05: Zadejte částku peněz, které jsou uloženy v bance,úrok a
            //    délku uložení. Vypočítejte, kolik bude v bance po uplynutí uvedené doby.
            //    Nepočítejte úroky z úroků.

            float castka, urok;
            byte pocetRoku;
            Console.WriteLine("zadej částku v bance (kc): ");
            castka = float.Parse(Console.ReadLine());
            Console.WriteLine("zadej urok sporeni (%): ");
            urok = float.Parse(Console.ReadLine());
            Console.WriteLine("zadej delku sporeni (v rocích): ");
            pocetRoku = byte.Parse(Console.ReadLine());
            Console.WriteLine($"Vase castka po konci sporeni:  {castka * urok / 100 * pocetRoku + castka:c}");
        }
    }
}