using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmosDiversos
{
    internal class ListaDeCompras
    {
        static void ImprimeLista(List<int> Lista, String titulo = "========")
        {
            foreach (int num in Lista)
            {
                Console.WriteLine(num);
            }
        }
        static void Main()
        {
            List<string> ListadeCompra = new List<string>();

            Console.WriteLine(":::::::: Programa de lista de Compras ::::::::");

            while (true)
            {
                Console.WriteLine("Digite um item da lista (ou 'parar' para sair");

                string item = Console.ReadLine();

                if (item.ToLower() == "parar")
                {
                    break;
                }

                ListadeCompra.Add(item);
                Console.WriteLine("Item adicionado com sucesso!");
            }

            Console.WriteLine("------ Sua lista de Compras -----");

            //imprimir a lista, porem caso esteja vazia retornar o texto 'A lista está vazia'
            //Caso ao contrario imprimitr todos os itens na tela

            if (ListadeCompra.Count() == 0)
            {
                Console.WriteLine("Não foi encontrado nenhum item na lista");
            }
           else
           {
                foreach (string Item in ListadeCompra)
                {
                    Console.WriteLine(Item);
                }
           }

        }
    }
}
