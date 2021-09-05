using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class VariaveisEConstantes {

        public static void Executar(){

            double raio = 4.5;
            const double PI = 3.14;
            double area = PI * raio * raio;

            Console.WriteLine(area);
            Console.WriteLine("A área da circunferência é " + area);

            bool estaChovendo = true;
            Console.WriteLine("Está chovendo? " +estaChovendo);

            int valor = int.MinValue;
            Console.WriteLine("Menor valor de int é: " + valor );

            long valorLong = long.MaxValue;
            Console.WriteLine("O maior valor que long suporta é: " + valorLong);

            float valorQuebrado = 122.00f;
            Console.WriteLine("Esse é um número float" + valorQuebrado);

            double numeroReal = 10000.00;
            Console.WriteLine("Esse é um número real: " + numeroReal);

            char letra = 'a';
            Console.WriteLine(letra);

            String cadeiaDeLetras = "Variável usada para caracteres";
            Console.WriteLine(cadeiaDeLetras);

        }

    }
}
