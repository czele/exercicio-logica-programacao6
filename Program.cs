using System;
using System.ComponentModel.DataAnnotations;

namespace ex6
{
    class Program
    {
        public static object MaxValue { get; private set; }

        static void Main(string[] args)
        {
            Console.WriteLine("Iremos calcura o Maior Divisor Comum!");
            Console.WriteLine("Qual o primeiro número?");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Qual o segundo número?");
            int b = Convert.ToInt32(Console.ReadLine());

            int retorno = MDC.Mdc(a, b);

            Console.WriteLine($"O Maior Divisor comum entre {a} e {b} é {retorno}.");
        }
    }
}
