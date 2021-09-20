using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturaDeControle {
    class EstruturaWhile {

        public static void Executar() {
            int numero = 1;

            while (numero <= 5) {

                Console.WriteLine(numero);
                numero++;
            }
        }
    }
}
