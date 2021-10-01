using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {
    class MetodosEstaticos {

        public class CalculadoraEstatica {

            public int Somar(int a, int b) {

                return a + b;
            }

            public static int Multiplicar(int a, int b) {


                return a * b;
            }
        }

        public static void Executar() {

            //Primeira forma sem método estático
            var calcInstanc = new CalculadoraEstatica();
            calcInstanc.Somar(1, 4);
            


            //Segunda forma com método estático
           var calculo = CalculadoraEstatica.Multiplicar(4, 5);
            
            calculo.Equals(20);

        }
    }
}
