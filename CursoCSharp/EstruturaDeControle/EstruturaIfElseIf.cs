using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturaDeControle {
    class EstruturaIfElseIf {

        public static void Executar() {

            Console.Write("Digite a sua nota: ");
            double nota = double.Parse(Console.ReadLine());

            if (nota <=5) {

                Console.WriteLine("Reprovado!");
            } 
            else if (nota >= 5.1 && nota <= 5.9) {
                Console.WriteLine("Recuperação");
            }
            else if (nota >=6) {
                Console.WriteLine("Aprovado");
            }

        }
    }
}
