using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturaDeControle {
    class EstruturaForEach {

        public static void Executar() {

            //String palavra = "Opa!";

            //foreach (var letra in palavra) {

            //    Console.WriteLine(letra);
            //}

            var alunos = new string[] { "Jhonatan", "Patrycia" };

            foreach (var aluno in alunos  ) {

                Console.WriteLine(aluno);
            }
        }
    }
}
