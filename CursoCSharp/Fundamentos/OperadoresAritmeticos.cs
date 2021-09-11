using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class OperadoresAritmeticos {

        public static void Executar() {

            var preco = 1500;
            var imposto = 200;
            var desconto = 0.1;

            double total = preco + imposto;
            double totalComDesconto = total - (total * desconto);

            Console.WriteLine("O valor total com desconto é: {0}", totalComDesconto);
        }
    }
}
