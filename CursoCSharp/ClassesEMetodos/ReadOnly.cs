using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {
    class ReadOnly {

        public class Cliente {

            public string Nome;
            readonly public DateTime Nascimento;

            public Cliente(string nome, DateTime nascimento) {
                Nome = nome;
                Nascimento = nascimento;
                Nascimento = new DateTime(1992, 04, 14);
            }

            public Cliente() {

            }

            public string GetDataNascimento() {
                return String.Format("{0}/{1}/{2}", Nascimento.Year, Nascimento.Month, Nascimento.Day);

            }
        }

        public static void Executar() {

            var cliente1 = new Cliente("Jhonatan", new DateTime(1990, 04, 14));
            Console.WriteLine(cliente1.Nome);
           

            
            Console.WriteLine(cliente1.GetDataNascimento());







        }
    }
}

