using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosProfRomulo.ExercicioSete
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercicio 7  mostrar os números de 100 ate 1 de forma decrecente

            int i = 100;
            while (i > 0)
            {
                Console.WriteLine(i);
                //i=i-1;
                i--;
            }
            Console.ReadKey();
        }
    }
}
