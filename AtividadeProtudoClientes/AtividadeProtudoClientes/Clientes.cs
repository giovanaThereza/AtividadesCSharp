using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeProtudoClientes
{
    internal class Clientes
    {
        public int IdCliente;
        public string Nome;
        public string Endereço;
        public string Cidade;

        public void ImprimeDetalhes()
        {
            Console.WriteLine("Cadastro do Cliente: {0}", IdCliente);
            Console.WriteLine("Nome: {0}", Nome);
            Console.WriteLine("Endereço: {0}", Endereço);
            Console.WriteLine("Cidade: {0}", Cidade);      
        }
    }


}
