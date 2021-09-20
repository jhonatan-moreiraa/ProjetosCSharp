using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {
    class Pessoa {

        public string Nome;
        public string Idade;
        public string Nota;


        public string Apresentar() {

            return string.Format($"Olá! meu nome é {Nome} e tenho {Idade} anos! ");
        }

        public void ApresentarNoConsole() {

            Console.WriteLine(Apresentar());
        }

        public double CalcularNota(double num1, double num2) {
            double soma;
            return  soma = num1 + num2;
            
        }

        
    }
}
