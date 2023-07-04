using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoObjeto
{
    internal class Livros
    {      
        public int IdLivros;
        public string Titulo;
        public string Autor;
        public int NumerosPaginas;
        public double Preco;

        public void ImprimeDetalhes()
        {
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Identificação: {0}", IdLivros);
            Console.WriteLine("Título: {0}", Titulo);
            Console.WriteLine("Autor: {0}", Autor);
            Console.WriteLine("Numeros de Paginas: {0}", NumerosPaginas);
            Console.WriteLine("Preço: {0:c}", Preco);
            Console.WriteLine("-------------------------------");
        }

        public Livros(int idLivros = 0, string titulo = "", string autor = "", int numerosPagina = 0, double preco = 0.0)
        {
            IdLivros = idLivros;
            Titulo = titulo;
            Autor = autor;
            NumerosPaginas = numerosPagina;
            Preco = preco;
        }
    }
}
