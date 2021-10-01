using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {

    public class CarroOpcional {
        string nome;
        public string Nome { get => "Opcional: " + nome; set => nome = value; }
        double desconto = 0.1;
        public double Preco {get;set;}

        public CarroOpcional(string nome, double preco) {
            this.nome = nome;
            Preco = preco;
        }

        public CarroOpcional() {

        }

        public double PrecoComDesconto {

            get => Preco - (Preco * desconto);
        }   

        

    }

    class Props {

        public static void Executar() {
            var carro1 = new CarroOpcional();
            carro1.Nome = "Ar condicionado";
            CarroOpcional carro2 = new CarroOpcional("Vidro elétrico", 2500);

            Console.WriteLine(carro1.Nome);
            Console.WriteLine(carro2.PrecoComDesconto);
            Console.WriteLine(carro2.Nome);
           
            


        }
    }
}

