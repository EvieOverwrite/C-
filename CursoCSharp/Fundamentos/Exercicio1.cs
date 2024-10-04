using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class Exercicio1
    {
        public static void Executar() {

            //-------------------------------------------------------
            //Exemplo
            //-------------------------------------------------------
            /*
            //Solicita o primeiro numero
            Console.Write("Digite um numero");
            Double num1 = Convert.ToDouble(Console.ReadLine());

            //Solicita o segundo numero
            Console.Write("Digite um numero");
            Double num2 = Convert.ToDouble(Console.ReadLine());

            //calcule a soma
            Double soma = num1 + num2;

            //Exibe o resultado
            Console.WriteLine($"A soma de {num1} e {num2} e: {soma}");
            */

            //-------------------------------------------------------
            //Exercicio 1
            //-------------------------------------------------------
            /*
            //le as notas do usuario
            Console.Write("digite a primeira nota (n1):");
            double N1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("digite a segunda nota (n2):");
            double N2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("digite a terceira nota (n3):");
            double N3 = Convert.ToDouble(Console.ReadLine());

            //calcula a media ponderada
            double media = (N1 + N2 + N3)/3;

            //mensagem bonita
            Console.WriteLine("A média do aluno é: {0:F2}", media);
            */
            //-------------------------------------------------------
            //Exercicio 2
            //-------------------------------------------------------
            /*
            // entrada de dois valores
            Console.WriteLine("Digite a primiera nota: ");
            double N1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota nota: ");
            double N2 = double.Parse(Console.ReadLine());

            //calculo a média ponderada
            Double media = (N1 * 3.5 + N2 * 7.5)/11;

            //exibe a mensagem
            Console.WriteLine("A nota é: {0:F2}",media);
            */
            //-------------------------------------------------------
            //Exercicio 3
            //-------------------------------------------------------
            //entrada dos valores
            Console.WriteLine("Digiete o numero de funcionarios:");
            int numeroFuncionario = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite as horas trabalhadas: ");
            int horasTrabalhadas = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor por hora: ");
            double valorPorHora = double.Parse(Console.ReadLine());

            //calcule o salario
            Double salario = horasTrabalhadas * valorPorHora;

            // saída Formatada
            Console.WriteLine("Número de funcionário: {0}", numeroFuncionario);
            Console.WriteLine("Salário: R$ {0:F2}", salario);
        }
    }
}
