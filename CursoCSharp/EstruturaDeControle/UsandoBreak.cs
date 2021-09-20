using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturaDeControle {
    class UsandoBreak {

        public static void Executar() {

            Random random = new Random();
            int numero = random.Next(1, 10);
            Console.WriteLine("O número que queremos é o {0} !", numero);

            for (int i = 1; i <= 11; i++) {

                Console.Write("O {0} é o número que queremos? ", i);

                if (numero == i) {
                    Console.WriteLine("Sim");
                    break;
                } else {

                    Console.WriteLine("Não");
                }
            }

        }
    }
}
