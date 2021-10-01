using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {

    public class Carreta {
        private string Marca;
        private string Modelo;

        public Carreta() {
        }

        public Carreta(string marca, string modelo) {
            Marca = marca;
            Modelo = modelo;
        }

        public string GetMarca() {
            return Marca;
        }
        public void SetMarca(string marca) {
            Marca = marca;

        }
       
    }
    class GetSetSecond {

        public static void Executar() {


            var carreta1 = new Carreta();
            carreta1.SetMarca("Honda");

            var carreta2 = new Carreta("Toyota", "Corolla");
            Console.WriteLine(carreta2.GetMarca());


        }
    }
}
