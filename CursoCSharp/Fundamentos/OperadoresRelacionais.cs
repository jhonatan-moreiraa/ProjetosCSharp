using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class OperadoresRelacionais {

        public static void Executar() {
            var nota = 6;
            var notaDeCorte = 7;

            Console.WriteLine("Nota inválida? {0}",nota > 8 );
            Console.WriteLine("Pefeito? {0}",nota == 6 );
            Console.WriteLine("Tem como melhorar? {0}",nota != 6 );
            Console.WriteLine("Passou por média? {0}", nota >= notaDeCorte );


        }
    }
}
