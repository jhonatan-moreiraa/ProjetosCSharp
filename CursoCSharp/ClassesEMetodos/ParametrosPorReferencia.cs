﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {
    class ParametrosPorReferencia {

        public static void AlterarRef(ref int numero) {

            numero += 1000;
        }

        public static void AlterarOut(out int numero) {
            numero = 0;
            numero += 10;
        }

        public static void Executar() {
            int a = 3;

            AlterarRef(ref a);
            Console.WriteLine(a);

            int b;
            AlterarOut(out b);
            Console.WriteLine(b);
            

        }
    }
}
