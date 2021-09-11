using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class NotacaoPonto {

        public static void Executar() {

            String nomeProduto = "notebook";
            double preco = 3000;

            var nome = "Olá Jhonatan".ToUpper();
            Console.WriteLine(nome.Replace("JHONATAN", "Marcello"));

            Console.WriteLine( nome.Length);
            Console.WriteLine( nome.ToUpper());

            Console.WriteLine("O nome do produto é {0} e custa R${1}", nomeProduto, preco);
           

        }
    }
}
