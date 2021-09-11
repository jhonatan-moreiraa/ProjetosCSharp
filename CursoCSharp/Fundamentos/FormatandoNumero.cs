using System;
using System.Globalization;

namespace CursoCSharp.Fundamentos {
    class FormatandoNumero {

        public static void Executar() {

            double valor = 3.178;
                       
            CultureInfo cultura = new CultureInfo("en-US");
            Console.WriteLine(valor.ToString("C3", cultura));

        }
    }
}
