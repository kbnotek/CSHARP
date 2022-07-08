using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioProfRomulo.ExercicioOito
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, fatorial, cont;
            num = 0;
            fatorial = 1;
            Console.WriteLine("Digite o Número");
            num = int.Parse(Console.ReadLine());
            if (num < 0)
            {
                Console.WriteLine("Numero Invalido");
            }
            else if ((num == 0) || (num == 1))
            {
                Console.WriteLine("fatorial de {0} é {1}",num);
            }
            else
            {
                for (cont = num; cont >= 1; cont--)
                {
                    fatorial *= cont;
                }
                Console.WriteLine("Fatorial de {0} é {1}",num,fatorial);

            }
            Console.ReadKey();

        }
    }
}
