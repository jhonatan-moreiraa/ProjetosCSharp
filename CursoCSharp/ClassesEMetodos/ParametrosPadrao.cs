using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {
    class ParametrosPadrao {

        public static int Somar(int a = 1, int b = 2) {

            return a + b;
        }

        public static void Executar() {

            Console.WriteLine(Somar(b:5));
            Console.WriteLine(Somar(b:5));
        }
    }
}
