using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeProtudoClientes
{
    internal class LojaVendas
    {
        public string Nome;
        public List<Produto> catalogo;
       
        public void CadastrarProdutos(Produto produto)
        {
            catalogo.Add(produto);
        }

        public void MostarCatalogo()
        {
            Console.WriteLine("Catalogo de Produtos : {0}", Nome);
            Console.WriteLine("==============================================");
            foreach (var produto in catalogo)
            {
                Console.WriteLine("identificação: {0} | {1} | preco: {2:c}", produto.IdProduto, produto.Quantidade, produto.Preco);
            }
            Console.WriteLine("==============================================");
            Console.WriteLine("Total de Protudos: {0}", catalogo.Count());
        }
    }
}
