using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculo_de_media
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double nota1, nota2, nota3, nota4, media;

            Console.Write("Digite a primeira nota: ");
            nota1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite a segunda nota: ");
            nota2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite a terceira nota : ");
            nota3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite a quarta nota: ");
            nota4 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("======================");
            Console.WriteLine("   CALCULE A MÉDIA"    );
            Console.WriteLine("======================");

            media = (nota1 + nota2 + nota3 + nota4) /4;

            if (media >= 7){
                Console.WriteLine("Você foi aprovado, parabens não fez mais que a obrigação");
             } else
            {
                Console.WriteLine("Você foi reprovado, inutil");
            }











        }
    }
}
