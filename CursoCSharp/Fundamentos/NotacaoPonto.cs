using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class NotacaoPonto {

        public static void Executar() {

            var nome = "Olá Jhonatan".ToUpper();
            Console.WriteLine(nome.Replace("JHONATAN", "Marcello"));

            Console.WriteLine( nome.Length);
            Console.WriteLine( nome.ToUpper());
           

        }
    }
}
