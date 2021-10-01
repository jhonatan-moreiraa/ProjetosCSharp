﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {
    class ParametrosNomeados {

        public static void Formatar(int dia, int mes, int ano) {
            Console.WriteLine("{0:D2}/{1:D2}/{2}", dia, mes, ano);

        }

        public static void Executar() {
            Formatar(dia:14, mes:04, ano:1990);
        }
    }
}
