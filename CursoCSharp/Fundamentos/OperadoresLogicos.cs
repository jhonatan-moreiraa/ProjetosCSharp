using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class OperadoresLogicos {

        public static void Executar() {

            var executouTrabalho1 = true;
            var executouTrabalho2 = false;

            var comprouTv = executouTrabalho1 && executouTrabalho2;
            Console.WriteLine("Comprou a tv?{0} ", comprouTv);

            var comprouSorvete = executouTrabalho1 || executouTrabalho2;
            Console.WriteLine("Comprou o sorvete? {0}", comprouSorvete);

        }
    }
}
