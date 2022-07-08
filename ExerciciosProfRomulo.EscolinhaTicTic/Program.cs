using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosProfRomulo.EscolinhaTicTic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declarando variável
            string nome, resultado;
            double nota1;
            double nota2;
            double nota3;
            double soma;
            double media;
            // usando as variaveis 
            Console.WriteLine("Qual Nome do Aluno?");
            nome = Console.ReadLine();
            Console.WriteLine("quais sao as 3 notas ?");
            nota1 = double.Parse(Console.ReadLine());
            nota2 = double.Parse(Console.ReadLine());
            nota3 = double.Parse(Console.ReadLine());
            soma = nota1 + nota2 + nota3;
            media = soma / 3;
            /* if (media >= 7)
             {
                 resultado = "Aprovado";
                 //Console.WriteLine($"Você foi Aprovado sua média é {media}");

             }
             else
                 resultado = "Reprovado";
              //Console.WriteLine($"Você está reprovado sua média é {media} ");
             */

            //Comando IF ELSE  em line "Operador ternario" .
            resultado = media >= 7 ? "Aprovado" : "Reprovado";
            Console.WriteLine($"Nome do Aluno {nome} \r\n As soma das Notas {soma}\r\n Valor da Media {media} e Você foi {resultado}");

           
        }

    }
}
