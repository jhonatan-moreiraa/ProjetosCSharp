using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class Interpolacao {

        public static void Executar() {
            String nome = "notebook";
            String marca = "Dell";
            double preco = 5000.00;
            Console.WriteLine("O " + nome + " da " + marca + " custa o valor de " + preco);
            Console.WriteLine("O {0} da marca {1} custa o valor de {2}.", nome, marca, preco);
            Console.WriteLine($"A marca {marca} é a mais top!");
            Console.WriteLine($"1+1 = {1 + 1}");

        }
    }
}
