using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturaDeControle {
    class EstruturaDoWhile {

        public static void Executar() {

            String entrada;
            do {
                Console.WriteLine("Olá!");
                Console.WriteLine("Deseja continuar? (S/N)");
                entrada = Console.ReadLine();
            } while (entrada.ToLower() == "s");
        }
    }
}
