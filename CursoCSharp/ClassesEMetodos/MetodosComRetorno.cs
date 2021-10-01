using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {

    class Calculadora {

        public int Somar(int a, int b) {


            return a + b;
        }
    }

    class CalculadoraCadeia {
        int memoria;

        public CalculadoraCadeia Somar(int a) {
            memoria += a;
            return this;
        }

        public CalculadoraCadeia Multiplicar(int a) {
            memoria *= a;
            return this;
        }

        public CalculadoraCadeia Limpar() {
            memoria = 0;
            return this;
        }

        public CalculadoraCadeia Imprimir() {
            Console.WriteLine(memoria);
            return this;
        }
    }
    class MetodosComRetorno {

        public static void Executar() {

            //var calculadora = new Calculadora();
            //var resultado = calculadora.Somar(5, 5);
            //Console.WriteLine(resultado);
            //Console.WriteLine(calculadora.Somar(2,5));


            var calculadoraCadeiaInst = new CalculadoraCadeia().Somar(6).Multiplicar(2).Limpar().Imprimir();


        }
    }



}

