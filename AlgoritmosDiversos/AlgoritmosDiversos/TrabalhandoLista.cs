using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmosDiversos
{
    internal class TrabalhandoLista
    {
        static void ImprimeLista(List<int> lista, String Titulo = "===============" )
        {
            Console.WriteLine("==================="+ Titulo +"====================");

            foreach (int num in lista)
            {
                Console.WriteLine(num);
            }
        }

        static void Main()
        {
            //Add: Adicionando elemento na lista
            List<int> lista = new List<int>();
            lista.Add(1);
            lista.Add(50);
            lista.Add(10);
            lista.Add(90);
            lista.Add(40);
            lista.Add(70);

            ImprimeLista(lista, "Adicionando elemento na lista");

            //Remove: Remove a primeira ocorrência de um elemento da lista 

            lista.Remove(10);

            ImprimeLista(lista, "Remove a primeira ocorrência de um elemento da lista");

            //RemoveAt: Remove o elemento de um índice

            lista.RemoveAt(0);

            ImprimeLista(lista, "Remove o elemento de um índice");

            //Sort: Ordenar os elementos em ordem crescente

            lista.Sort();
            ImprimeLista(lista, "Ordem crescente");

            //Reverse: Ordenar os elementos em ordem Decrescente

            lista.Reverse();
            ImprimeLista(lista, "Ordem Decrescente");

            Console.WriteLine("===========================");

            //count: Retorna a quantidade de elementos na lista

            int NumeroItem = lista.Count();
            Console.WriteLine("Existem {0} itens na lista", NumeroItem);

            //Cotains: Verifica se o lista contém um determinado elementos

            if (lista.Contains(40))
            {
                Console.WriteLine("Foi encotrado o item na lista");
                Console.WriteLine("=============================");
            }
            else
            {
                Console.WriteLine("Não foi encontrado nenhum item na lista");
            }

            //Insert: Insere um elemento em um determinado indice da lista

            lista.Insert(2,45); 
            ImprimeLista(lista, "Insere um elemento em um determinado indice da lista");


            //Clear: Limpar os itens na lista

            lista.Clear();
        }
    }
}
