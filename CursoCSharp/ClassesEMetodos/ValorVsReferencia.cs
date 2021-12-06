using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {

    public class Dependente {
        public string Nome;
        public int Idade;
    }
    class ValorVsReferencia {

        public static void Executar() {

            int numero = 3;
            int copiaNumero = numero;
            //Console.WriteLine($"{numero} {copiaNumero}");

            Dependente dep = new Dependente();
            dep.Nome = "Beto";
            dep.Idade = 32;

            Dependente copiaDep = dep;
            Console.WriteLine($"{dep.Nome} {copiaDep.Nome}");
            Console.WriteLine($"{dep.Idade} {copiaDep.Idade}");

            copiaDep.Nome = "Renato";
            copiaDep.Idade = 24;

            Console.WriteLine($"{dep.Nome} {copiaDep.Nome}");
            Console.WriteLine($"{dep.Idade} {copiaDep.Idade}");

        }
    }
}
