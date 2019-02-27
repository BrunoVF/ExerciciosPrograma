using System;

namespace ExercicioCasa01
{
    class Program
    {
        static void Main(string[] args)
        {
            int soma = 0, diferenca = 0, produto = 0, resto = 0;
            double divisao = 0;
            int num1 = 10, num2 = 2;
            soma = num1 + num2;
            diferenca = num1 - num2;
            produto = num1 * num2;
            divisao = num1 / num2;

            resto = 3 % num2;
            System.Console.WriteLine("num1 = {0}, num2 = {1}", num1, num2);
            System.Console.WriteLine();
            System.Console.WriteLine("Soma de " + num1 + " e " + num2 + " é " + soma);
            System.Console.WriteLine("Diferença de {0} e {1} é {2}", num1, num2, diferenca);
            System.Console.WriteLine("Produto de {0} e {1} é {2}", num1, num2, produto);
            System.Console.WriteLine("Quociente de {0} e {1} é {2}", num1, num2, divisao);
            System.Console.WriteLine();
            System.Console.WriteLine("resto de 3 quando é dividido por {0} é {1}", num2, resto);


        }
    }
}
