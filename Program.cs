using System;

namespace Exercicio // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DetalharData();
            //CalcularDescontoINSS();
        }
        public static void DetalharData()
        {
          Console.WriteLine("Digite uma data: ");
          DateTime Data = DateTime.Parse(Console.ReadLine());

          string frase1 = string.Format("{0:dddd}, {0:MMMM}", Data);
         Console.WriteLine(frase1);

         if(Data.DayOfWeek == DayOfWeek.Sunday)
         {
            string frase2 = string.Format("{0:dd} de {0:yyyy}. as {0:HH:mm:ss}", DateTime.Now);
            Console.WriteLine(frase2);
         }
         else
         {
          Console.WriteLine("Hoje não é domingo!!");
         }
        }




     public static void CalcularDescontoINSS()
     {
      Console.WriteLine("Digite o seu salário: ");
    decimal salario = decimal.Parse(Console.ReadLine());

    decimal descontoINSS = 0m;
    
    if (salario <= 1212.00m)
    {
        descontoINSS = salario * 0.075m;
    }
    else if (salario <= 2427.35m)
    {
        descontoINSS = (1212.00m * 0.075m) + ((salario - 1212.00m) * 0.09m);
    }
    else if (salario <= 3641.03m)
    {
        descontoINSS = (1212.00m * 0.075m) + ((2427.35m - 1212.00m) * 0.09m) + ((salario - 2571.29m) * 0.12m);
    }
    else if (salario <= 7087.22m)
    {
        descontoINSS = (1212.00m * 0.075m) + ((2427.35m - 1212.00m) * 0.09m) + ((3641.03m - 2427.35m) * 0.12m) + ((salario - 3641.03m) * 0.14m);
    }
    else
    {
        descontoINSS = (1212.00m * 0.075m) + ((2427.35m - 1212.00m) * 0.09m) + ((3641.03m - 2427.35m) * 0.12m) + ((7087.22m - 3641.03m) * 0.14m);
    }

    decimal salarioDescontado = salario - descontoINSS;

    Console.WriteLine($"O desconto do INSS é: R$ {descontoINSS:F2}");
    Console.WriteLine($"O salário após o desconto é R$ {salarioDescontado:F2}");

     
     }


    }
}






// See https://aka.ms/new-console-template for more information

