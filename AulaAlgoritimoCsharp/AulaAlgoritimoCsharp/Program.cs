using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaAlgoritimoCsharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero1, numero2, total;

            Console.Write("Digite o Número 1: ");
            numero1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("digite o número 2: ");
            numero2 = Convert.ToInt32(Console.ReadLine());


            total = numero1 + numero2;

            Console.WriteLine("=====================");
            Console.WriteLine("|    Calcula Média   |");
            Console.WriteLine("=====================");


            Console.WriteLine("O total é de: " + total);
            Console.WriteLine($"O total é: {total}");
            Console.WriteLine("A soma do {0} e {1} é: {2}",numero1, numero2, total );
            Console.WriteLine("Número 1.........:{0,10}", numero1);
            Console.WriteLine("Número 2.........:{0,10}", numero2);
            Console.WriteLine("Total............:{0,10:p" +"}", total);
            Console.WriteLine("Total............:{0,10:d" + "}", total);
            Console.WriteLine("Total\n.....\t......:{0,10:d" + "}", total);


        }

    }
}
