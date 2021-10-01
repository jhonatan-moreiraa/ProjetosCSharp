using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {

    class Carro {

        public string Modelo;
        public string Fabricante;
        public int Ano;

        public Carro(string modelo, string fabricante, int ano) {

            Modelo = modelo;
            Fabricante = fabricante;
            Ano = ano;
        }
}


    class Construtores {

        public static void Executar() {

            var carro1 = new Carro("Civic", "Honda", 2014);
            Console.WriteLine($"{ carro1.Modelo} {carro1.Fabricante} {carro1.Ano} ");

            //carro1.Fabricante = "Honda";
            //carro1.Modelo = "Civic";
            //carro1.Ano = 2014;



        }
    }
}
