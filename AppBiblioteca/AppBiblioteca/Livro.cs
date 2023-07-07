using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace AppBiblioteca
{
    internal class Livro
    {
        public int Id { get; set; }
        public string Titulo;
        private int ano;
        private int NumeroPagina;

        public int Ano
        {
            get { return ano; }
            set 
            { 
                if (value > 0)
                {
                    ano = value;
                }else
                {
                    Console.WriteLine("Ano de publicação inválido");
                }
            }
        }

        public int numeropagina
        {
            get { return NumeroPagina; }
            set
            {
                if(value > 0) 
                { 
                    NumeroPagina = value;
                }
                else
                {
                    Console.WriteLine("Números de Paginas inválido");
                }
            }       
        }


        public virtual void MostrarDetalhes()
        {
            Console.WriteLine("Id: {0}", Id);
            Console.WriteLine("Titulo: {0}", Titulo);
            Console.WriteLine("Ano de publicação: {0}", ano);
            Console.WriteLine("Números de Páginas: {0} ", NumeroPagina);
        }
    }

}
