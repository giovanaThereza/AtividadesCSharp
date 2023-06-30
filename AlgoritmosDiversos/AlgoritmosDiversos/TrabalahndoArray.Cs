using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmosDiversos
{
    internal class TrabalahndoArray
    {
        static void Main()
        {
            int[] numeros = { 10, 25, 30, 5, 50, };
            int[] numerosNotas = new int[5] {10, 5, 8, 8, 5 };
            int[] Notas = new int[4];

            Notas[0] = 10;
            Notas[1] = 8;
            Notas[2] = 3;
            Notas[3] = 10;

            foreach (int nota in numerosNotas)
            {
                Console.WriteLine(nota);
            }
        }
    }
}
