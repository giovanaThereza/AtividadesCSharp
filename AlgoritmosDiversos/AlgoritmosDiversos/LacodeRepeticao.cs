using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmosDiversos
{
    internal class LacodeRepeticao
    {

        static void Main()
        {
            Console.WriteLine("======== Laços de Repetição ========");

            int contador = 0;

            while (contador <= 5)
            {
                Console.WriteLine("O valor do contador é: " + contador);
                contador++;
            }

            Console.WriteLine("=========================================");

            contador = 0; 

            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine("O valor do contador é: " + i);
            }

            for (contador =0; contador <= 5; contador++)
            {
                Console.WriteLine("O valor do contador é: " + contador);
            }

            Console.WriteLine("=========================================");

            contador = 0; 

            do
            {
                Console.WriteLine("O valor do contador é: " + contador);
                contador++;            
            }while (contador <= 5);
            {

            }

            Console.WriteLine("=========================================");

            string[] frutas = { "Maça", "Banana", "Laranja", "tomate" };

            for (int i = 0; i < frutas.Length; i++)
            {
                Console.WriteLine(frutas[i]);
            }

            Console.WriteLine("=========================================");

            foreach (string fruta in frutas)
            {
                Console.WriteLine(fruta);
            }



        }
    }
}
