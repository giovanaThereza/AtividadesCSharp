using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeProtudoClientes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LojaVendas lojaVendas = new LojaVendas();
            lojaVendas.Nome = "Papelaria Socorro";
           
            Clientes Cliente = new Clientes();

            Cliente.IdCliente = 1;
            Cliente.Nome = "José de Alencar";
            Cliente.Cidade = "Marília";
            Cliente.Endereço = "Rua: Narlia, N°547, Bairro: Alem do Universo";

            Cliente.ImprimeDetalhes();
            
            Console.WriteLine("============================");
            Console.WriteLine("O pedido de José foi :");
            Console.WriteLine("============================");
           
            Produto Produto = new Produto();

            Produto.IdProduto = 2;
            Produto.NomeProduto = "Lápís";
            Produto.Quantidade = 5;
            Produto.Preco = 12.50;
            
            Produto.ImprimeDetalhes();
           
            Doces doces = new Doces();

            doces.NomeDoce = "Bem Casado";
            doces.QuantidadeD = 2;
            doces.PrecoD = 5.0;

            doces.MostarDetalhes();


        }
    }
}
