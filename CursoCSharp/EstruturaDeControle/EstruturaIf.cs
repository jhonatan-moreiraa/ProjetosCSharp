using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturaDeControle {
    class EstruturaIf {

        public static void Executar() {

            Console.Write("Insira a primeira nota: ");
            double recebeNota1 = double.Parse(Console.ReadLine());

            Console.Write("Insira a segunda nota: ");
            double recebeNota2 = double.Parse(Console.ReadLine());

            double media = (recebeNota1 + recebeNota2) / 2;

            if (media >= 6) {
                Console.WriteLine("Parabéns, sua média foi {0} e você está aprovado!", media);
            } else {

                Console.WriteLine("Você foi reprovado!");
            }
        }
    }
}
