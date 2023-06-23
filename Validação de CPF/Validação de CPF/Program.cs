using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validação_de_CPF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numero;
            int i;
            int soma = 0, soma2 = 0, resto1 = 0, resto2 = 0;
            int[] vt = new int[11];
            int[] peso1 = { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] peso2 = { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };           

            while (true)
            {

                Console.Write("Digite o seu CPF (Apenas Números): "); //Atribuição
                numero = Console.ReadLine().Trim();
                bool isNumeric = numero.All(char.IsDigit);
               
                if (!isNumeric) 
                {
                    Console.WriteLine("Contém Letras");
                    Console.WriteLine("\n======================\n");
                    continue;
                }

                else if (numero.Length != 11)
                {
                    Console.WriteLine("Inválido");
                    continue;
                }
                else
                {
                    vt = numero.Select(d => Convert.ToInt32(d.ToString())).ToArray();
                    break;
                }
            }
            for (i = 0; i < 9; i++) //Primeiro Dígito
            {
                soma += vt[i] * peso1[i];
                resto1 = (soma * 10) % 11;

                if (resto1 == 10 || resto1 == 11)
                {
                    resto1 = 0;
                }
            }

            for (i = 0; i < 10; i++) //Segundo Dígito
            {
                soma2 += vt[i] * peso2[i];
                resto2 = (soma2 * 10) % 11;

                if (resto2 == 10 || resto2 == 11)
                {
                    resto2 = 0;
                }
            }
            string CPFcru = string.Join("", vt);
            string CPFrenovado = $"{CPFcru.Substring(0, 3)}.{CPFcru.Substring(3, 3)}.{CPFcru.Substring(6, 3)}-{CPFcru.Substring(9, 2)}";

            if (resto1 == vt[9] || resto2 == vt[10]) //Validação
            {
                Console.WriteLine("\n===================================");
                Console.WriteLine($"Seu CPF está aprovado: {CPFrenovado}");
                Console.WriteLine("===================================\n");
            }

            else
            {
                Console.WriteLine("\n===================================");
                Console.WriteLine($"Seu CPF está inválido: {CPFrenovado}");
                Console.WriteLine("===================================\n");
            }

            
        }     
    }
}
