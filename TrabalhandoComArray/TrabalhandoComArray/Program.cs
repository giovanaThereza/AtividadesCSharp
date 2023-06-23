using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhandoComArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o seu CPF (Apenas Números): ");
            string cpf = Console.ReadLine();

            char[] numerosCPF = cpf.ToCharArray();

            for(int i = 0; i < numerosCPF.Length; i++)
            {
                Console.WriteLine(numerosCPF[i]);
            }

            Console.WriteLine("===========================");

            foreach (char numero in numerosCPF)
            {
                Console.WriteLine(numerosCPF);
            }

            int[] numeroInteiro = numerosCPF.Select(numero => Convert.ToInt32(numero.ToString())).ToArray();

            Console.WriteLine(string.Join("-", numeroInteiro));
        }
    }
}
