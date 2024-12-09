using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A {

    internal class a13_trojuhelnik {

        public static void Mainx() {
            //13) Zadejte délku odvěsen pravoúhlého trojúhelníka.Program pomocí Pythagorovy věty vypočte délku přepony.
            //    Pro kontrolu: zadáte - li odvěsny o délce 3 a 4, pak výsledek je 5(přesněji 5, 0, protože výsledek odmocniny se musí ukládat do desetinného typu )

            double odvesnaA, odvesnaB, prepona;

            Console.WriteLine("Zadejte délku odvěsen pravoúhlého trojúhelníka.Program pomocí Pythagorovy věty vypočte délku přepony.\r\n" +
                              "Pro kontrolu: zadáte - li odvěsny o délce 3 a 4, pak výsledek je 5(přesněji 5, 0, protože výsledek odmocniny se musí ukládat do desetinného typu )");
            Console.WriteLine("Zadejte odvěsny a já ti spočítám přeponu");
            Console.WriteLine("Zadejte délku v odvěsny A");
            odvesnaA = double.Parse(Console.ReadLine());
            Console.WriteLine("Zadejte délku odvěsny B");
            odvesnaB = double.Parse(Console.ReadLine());

            prepona = Math.Sqrt(Math.Pow(odvesnaA, 2) + Math.Pow(odvesnaB, 2));
            Console.WriteLine($"Délka přepony je {prepona:f}");
        }
    }
}