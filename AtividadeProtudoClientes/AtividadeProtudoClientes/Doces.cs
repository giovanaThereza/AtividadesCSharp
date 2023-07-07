using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeProtudoClientes
{
    internal class Doces
    {
        public string NomeDoce;
        public int QuantidadeD;
        public double PrecoD;

        public void MostarDetalhes()
        {
            Console.WriteLine("Nome do Doce: {0}", NomeDoce);
            Console.WriteLine("Quantidade de Doce(s): {0}", QuantidadeD);
            Console.WriteLine("Preço do(s) Doce(s): {0:c}", PrecoD);
        }

    }
}
