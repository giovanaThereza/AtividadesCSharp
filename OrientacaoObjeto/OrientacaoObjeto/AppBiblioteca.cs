using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoObjeto
{
    internal class AppBiblioteca
    {
        static void Main()
        {
            Biblioteca biblioteca = new Biblioteca();
            biblioteca.Nome = "Senac Maríla";

            Livros livro = new Livros();
            livro.IdLivros = 1;
            livro.Titulo = "Por Lugares Incriveis";
            livro.Autor = "Jennifer Niven";
            livro.NumerosPaginas = 355;
            livro.Preco = 32.80;
           
            biblioteca.CadastrarLivro(livro);

            Livros livro2 = new Livros();

            livro2.IdLivros = 2;
            livro2.Titulo = "Os sete Maridos de Evelyn Hugo";
            livro2.Autor = "Taylor Jenkins Reid";
            livro2.NumerosPaginas = 360;
            livro2.Preco = 41.50;

            biblioteca.CadastrarLivro(livro2);
            biblioteca.MostrarCatalogo();
        }
    }
}
