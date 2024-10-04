using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    class VariaveisEConstantes {
        public static void Executar() {

            string nome = "luiz";
            string sexo = "M";
            int idade = 21;
            double altura = 1.80;
            bool temCachorro = true;
            Console.WriteLine($"Seu nome é {nome} e eu tenho tenho {idade}");

            var time = "cortina";
            var posicao = 17;


            double raio = 4.5; //real
            const double pi = 3.14; //constant
            double area = pi * raio * raio;
            Console.WriteLine("Area total é" + area);
        }
    }
}
