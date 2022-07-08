using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosProRomulo.ExercicioSeis
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //###==================== PRIMEIRA FORMA USANDO O FOR =====================================###
            /* int num, i;
              num = 1;
              i = 100;
              for (int x = num; x <= i; x++)
              {
                  if (x % 2 == 0)
                  {
                      Console.WriteLine(x);
                  }

              }*/

            //============================================== USANDO A FORMA DO PROFESSOR USANDO [ WHILE,  IF,  % ] =======================

            int i;
            i = 1;
            while (i <= 100)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
              
                i++;

            }
            Console.ReadKey();
        }
    }
}
