using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AppBiblioteca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Livro livro = new Livro();

            livro.Id = 1;
            livro.Titulo = "Os sete Maridos de Evelyn Hugo";
            livro.Ano = 2017;
            livro.numeropagina = 360;

            livro.MostrarDetalhes();
           
            Console.WriteLine("===========================================");
           
            LivroDigital livroDigital = new LivroDigital();

            livroDigital.Id = 2;
            livroDigital.Titulo = "Por Lugares Incriveis";
            livroDigital.Ano = 2015;
            livroDigital.numeropagina = 355;
            livroDigital.TipoArquivo = "PDF";
            livroDigital.TamanhoMB = 284;

            livroDigital.MostrarDetalhes();

        }
    }
}
