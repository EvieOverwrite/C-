using System;
using System.Collections.Generic;
using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturasDeControle;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Variaveis e Constantes - Fundamentos",VariaveisEConstantes.Executar},
                {"NotacaoPonto - Fundamentos",NotacaoPonto.Executar},
                {"LendoDados - Fundamentos",LendoDados.Executar },
                {"FormatandoNumeros - Fundamentos",FormatandoNumeros.Executar},
                {"Exercicio1 - Fundamentos",Exercicio1.Executar},
                {"EstruturaIF - Fundamentos",EstruturasIF.Executar}

            });

            central.SelecionarEExecutar();
        }
    }
}