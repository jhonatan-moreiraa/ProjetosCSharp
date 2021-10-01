using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {

    public class Produto {
        public string Nome;
        public double Preco;
        public  static double Desconto = 0.1;

        public Produto(string nome, double preco, double desconto) {

            Nome = nome;
            Preco = preco;
            Desconto = desconto;
        }
        

        public double CalcularDesconto() {
            return Preco - Preco * Desconto;
        }
    }
    class AtributosEstaticos {        

        public  static void Executar() {
            var produto1 = new Produto("Carro", 70000, 0.1);
            var produto2 = new Produto("Moto", 70000, 0.4);
            Produto.Desconto = 0.5;          

            Console.WriteLine($"O valor do produto com desconto será: {produto1.CalcularDesconto()}");
            Console.WriteLine($"O valor do produto com desconto será: {produto2.CalcularDesconto()}");


        }
    }
}
