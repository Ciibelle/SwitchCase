using System;

namespace UsandoSwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
             //SINTAXE: SWITCH / CASE

             int mesAno = 0;
             Console.WriteLine("Digite o número do Mês de 1 até 12: ");
             mesAno = Convert.ToInt16(Console.ReadLine());

             switch (mesAno)
             {
                 case 1:
                   Console.WriteLine("Janeiro ");
                   Console.WriteLine("Esse mês tem 31 dias!");
                   break;

                 case 2:
                   Console.WriteLine("Fevereiro ");
                   Console.WriteLine("Esse mês tem 28 ou 29 dias!");
                   break;

                 case 3:
                   Console.WriteLine("Março ");
                   Console.WriteLine("Esse mês tem 31 dias!");
                   break;

                 case 4:
                   Console.WriteLine("Abril ");
                   Console.WriteLine("Esse mês tem 30 dias!");
                   break;

                 case 5:
                   Console.WriteLine("Maio ");
                   Console.WriteLine("Esse mês tem 31 dias!");
                   break;

                 case 6:
                   Console.WriteLine("Junho ");
                   Console.WriteLine("Esse mês tem 30 dias!");
                   break;

                 case 7:
                   Console.WriteLine("Julho ");
                   Console.WriteLine("Esse mês tem 31 dias!");
                   break;

                 case 8:
                   Console.WriteLine("Agosto ");
                   Console.WriteLine("Esse mês tem 31 dias!");
                   break;

                 case 9:
                   Console.WriteLine("Setembro ");
                   Console.WriteLine("Esse mês tem 30 dias!");
                   break;

                 case 10:
                   Console.WriteLine("Outubro ");
                   Console.WriteLine("Esse mês tem 31 dias!");
                   break;

                 case 11:
                   Console.WriteLine("Novembro ");
                   Console.WriteLine("Esse mês tem 30 dias!");
                   break;

                 case 12:
                   Console.WriteLine("Dezembro ");
                   Console.WriteLine("Esse mês tem 31 dias!");
                   break;

                }

             

        }
    }
}
