using System;
using static System.Console;

namespace UsingSwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            //sintaxe: switch / case

            //Switch (var ou valor)

            //{
                    //case valor1:
                        // fazer algo referente ao valor 1
                    //break;

                    //case valor1:
                        // fazer algo referente ao valor 1
                    //break;
            //}
            WriteLine("Digite o numero do mês");
            int mes = Convert.ToInt32(ReadLine());
            
           switch (mes)
           {
               case 1 or 3 or 5 or 7 or 8 or 10 or 12:
               WriteLine("Este mês tem mais de 31 dias");
               break;

               case 2:
               WriteLine("Este mês tem 28 ou 29 dias");
               break;

               default:
                WriteLine("Este mês tem 30 dias");
               break;
           }
        }
    }
}
