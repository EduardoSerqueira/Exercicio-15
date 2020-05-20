using System;

namespace Exercicio_15
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;

            Console.WriteLine("Digite um número: ");
            num = int.Parse(Console.ReadLine());

            if (num >= 0 && num < 25)
                Console.WriteLine("Intervalo de [0,25]");
            else if (num >= 25 && num < 50)
                Console.WriteLine("Intervalo de [25,50]");
            else if (num >= 50 && num < 75)
                Console.WriteLine("Intervalo de [50,75]");
            else if (num >= 75 && num < 100)
                Console.WriteLine("Intervalo de [75,100]");

            Console.ReadKey();

            //Exemplo de teste
            //Entrada
            //23
            //Saída
            //Intervalo de [0,25]
        }
    }
}
