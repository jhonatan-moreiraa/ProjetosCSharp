using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class OperadoresAtribuicao {

        public static void Executar() {
            var num1 = 8;
            num1 /= 2;
            Console.WriteLine(num1);

            int a = 1;
            int b = a;
            b++;
            Console.WriteLine(b);


        }
    }
}
