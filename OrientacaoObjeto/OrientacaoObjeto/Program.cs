using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoObjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Livros livro = new Livros();

            livro.IdLivros = 1;
            livro.Titulo = "Por Lugares Incriveis";
            livro.Autor = "Jennifer Niven";
            livro.NumerosPaginas = 355;
            livro.Preco = 32.80;

            livro.ImprimeDetalhes();

            Livros livro2 = new Livros();

            livro2.IdLivros = 2;
            livro2.Titulo = "Os sete Maridos de Evelyn Hugo";
            livro2.Autor = "Taylor Jenkins Reid";
            livro2.NumerosPaginas = 360;
            livro2.Preco = 41.50;

            Console.WriteLine("Detalhes do Segundo Livro");

            livro2.ImprimeDetalhes();

            Livros livro3 = new Livros(3,"A Culpa é das Estrelas", "John Green", 288, 40.90);

            Livros livro4 = new Livros(idLivros: 4, numerosPagina: 500, titulo: "Tempestade de Guerra", autor: "Victoria Aveyard", preco: 31.80);

            livro3.ImprimeDetalhes();
            livro4.ImprimeDetalhes();

            Livros livro5 = new Livros()
            {
                IdLivros = 5,
                Titulo = "Cinco passos de Você",
                Autor = "Rachael Lippincott",
                NumerosPaginas = 288,
                Preco = 27.90,
            };

            livro5.ImprimeDetalhes();
        }

    }
}
