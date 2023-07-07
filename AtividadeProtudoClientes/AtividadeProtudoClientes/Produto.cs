using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeProtudoClientes
{
    internal class Produto : Doces
    {

        public int IdProduto;
        public string NomeProduto;
        public int Quantidade;
        public double Preco;

        public void ImprimeDetalhes()
        {
            Console.WriteLine("Identificação: {0}", IdProduto);
            Console.WriteLine("Nome de Produto: {0}", NomeProduto);
            Console.WriteLine("Quantidade de Produto: {0}", Quantidade);
            Console.WriteLine("Preço: {0:C}", Preco);
            Console.WriteLine("--------------------------------------");
        }
    }   
}
