using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioCSharp
{
    public static class Questao09
    {
        public static void Exec()
        {
            Console.WriteLine("Encontrar todos os divisores inteiros diferentes de n.");

            int n = 0;
            bool entradaValida = false;

            while (!entradaValida)
            {
                Console.Write("Entre com um número inteiro positivo: ");
                string input = Console.ReadLine();

                if (!int.TryParse(input, out n))
                {
                    Console.WriteLine("Entrada inválida. Por favor, entre com um número inteiro válido.");
                }
                else if (n < 1)
                {
                    Console.WriteLine("Por favor, entre com um número inteiro positivo.");
                }
                else
                {
                    entradaValida = true;
                }
            }

            for (int i = 1; i < n; i++)
            {
                if (n % i == 0)
                {
                    Console.Write("{0} ", i);
                }
            }
        }
    }
}
