﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBiblioteca
{
    internal class LivroDigital : Livro
    {
        public string TipoArquivo;
        private int tamanhoMB;

        public int TamanhoMB
        {
            get { return tamanhoMB; }
            set
            {
                if (value > 0)
                {
                    tamanhoMB = value;
                }
                else
                {
                    Console.WriteLine("Tamanho do arquivo Inválido");
                }
            }
        }
        
        public override void MostrarDetalhes()
        {
            base.MostrarDetalhes();
            Console.WriteLine("Tamanho: {0}MB",tamanhoMB);
            Console.WriteLine("Tipo de Arquivo: {0}", TipoArquivo);
        }
    }
}
