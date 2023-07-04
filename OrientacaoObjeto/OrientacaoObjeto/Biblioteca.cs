using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoObjeto
{
    internal class Biblioteca
    {
        public string Nome;
        public List<Livros> catalogo;

        public Biblioteca()
        {
            catalogo = new List<Livros>();
        }

        public void CadastrarLivro(Livros livro)
        {
            catalogo.Add(livro);
        }

        public void MostrarCatalogo()
        {
            Console.WriteLine("Catalogo de Livros da BiBlioteca: {0}", Nome);
            Console.WriteLine("==============================================");
            foreach (var livro in catalogo)
            {
                Console.WriteLine("identificação: {0} | {1} | preco: {2:c}", livro.IdLivros, livro.Titulo, livro.Preco);
            }
            Console.WriteLine("==============================================");
            Console.WriteLine("Total de livros: {0}", catalogo.Count());
        }


    }
}
