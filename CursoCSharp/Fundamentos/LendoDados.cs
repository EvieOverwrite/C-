using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    class LendoDados {
        public static void Executar() {
            Console.WriteLine("Qual seu nome ?");
            string nome = Console.ReadLine();

            Console.WriteLine("Em qual a posição o vasco esta ?");
            int posicao = int.Parse(Console.ReadLine());
            Console.WriteLine($"Seu nome é {nome} e a posição do vasco {posicao}");

            Console.WriteLine("Fala um numero");
            string numero = Console.ReadLine();

        }
    }
}
