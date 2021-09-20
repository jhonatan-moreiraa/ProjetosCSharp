using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {
    class Membros {

        public static void Executar() {

            Pessoa fulano = new Pessoa();

            fulano.Nome = "Patrycia";
            fulano.Idade = "30";

            //Console.WriteLine(fulano.Apresentar());

            var apresentarFulano = fulano.Apresentar();
            Console.WriteLine(apresentarFulano);


            //fulano.ApresentarNoConsole();
            //Console.WriteLine("Sua nota foi: "+ fulano.CalcularNota(1,2));

            
            
            

        }
    }
}
