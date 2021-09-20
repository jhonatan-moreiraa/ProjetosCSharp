using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturaDeControle {
    class EstruturaSwitch {

        public static void Executar() {

            Console.Write("Avalie meu atendimento com 1 ou 2: ");
            int nota = int.Parse(Console.ReadLine());

            switch (nota) {

                case 1:
                    Console.WriteLine("Ruim");
                    break;
                case 2:
                    Console.WriteLine("Bom");
                    break;
                default:
                    Console.WriteLine("Inválido");
                    break;
            }

        }
    }
}
