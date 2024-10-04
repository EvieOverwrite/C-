using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    class NotacaoPonto {
        public static void Executar() {
            string saudacao = "ola".ToUpper().Insert(3,"mundo").Replace("mundo","mundo");
            Console.WriteLine(saudacao);
        }
    }

}
