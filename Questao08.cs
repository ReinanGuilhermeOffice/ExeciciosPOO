using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioCSharp
{
    public static class Questao08
    {
        public static void Exec()
        {
            Console.WriteLine("Verificar se um número é um quadrado perfeito.");

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

            int i = 1;
            while (n > 0)
            {
                n -= i;
                i += 2;
            }

            if (n == 0)
            {
                Console.WriteLine("{0} é um quadrado perfeito.", (i / 2) * (i / 2));
            }
            else
            {
                Console.WriteLine("{0} não é um quadrado perfeito.", n);
            }
        }
    }
}
