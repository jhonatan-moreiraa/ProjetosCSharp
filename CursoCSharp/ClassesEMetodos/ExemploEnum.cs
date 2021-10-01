using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {

    public enum Genero {Acao, Aventura, Animacao, Terror };

    public class Filme {
        public string Titulo;
        public Genero GeneroDoFilme;
    }
    class ExemploEnum {

        public static void Executar() {

            int id = (int)Genero.Animacao;
            Console.WriteLine(id);

            Filme filmeParaFamilia = new Filme();
            filmeParaFamilia.GeneroDoFilme = Genero.Acao;

            Console.WriteLine("O gênero do filme é {0}", filmeParaFamilia.GeneroDoFilme);

        }
    }
}
