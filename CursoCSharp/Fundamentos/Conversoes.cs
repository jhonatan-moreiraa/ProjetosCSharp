using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class Conversoes {

        public static void Executar() {
            //int inteiro = 10;
            //double quebrado = inteiro;
            //Console.WriteLine(quebrado);

            //double nota = 9.7;
            //int notaTruncada = (int) nota;
            //Console.WriteLine(notaTruncada);

            Console.Write("Digite sua idade: ");
            String idadeString = Console.ReadLine();
            int idadeInteira = int.Parse(idadeString);
            Console.WriteLine("Idade inserida: {0}", idadeInteira);


        }
    }
}
