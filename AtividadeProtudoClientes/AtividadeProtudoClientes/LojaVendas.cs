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
        
        public  LojaVendas()
        {
            catalogo = new List<Produto>();
        }

        public void CadastrarProdutos (Produto produto)
        {
            catalogo.Add(produto);
        }

        public void MostarCatalogo()
        {
            Console.WriteLine("Catalogo de Produtos na Loja de Vendas: {0}", Nome);
            Console.WriteLine("=================================================");
            foreach (var produto in catalogo)
            {
                Console.WriteLine("identificação: {0} | {0} | preco: {0:c}", produto.IdProduto, produto.NomeProduto, produto.Preco);
            }
            Console.WriteLine("=================================================");
            Console.WriteLine("Total de Protudos: {0}", catalogo.Count());
        }
    }
}
