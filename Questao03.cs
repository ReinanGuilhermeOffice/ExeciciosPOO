using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioCSharp
{
    public static class Questao03
    {
        public static void Exec()
        {
            //Escreva um programa que apresente os n primeiros números primos a partir do número 2 para um valor n>0 fornecido pelo usuário.

            Console.Write("Digite o valor de n para exibir os n primeiros números primos: ");
            string input = Console.ReadLine();
            int n;

            if (!int.TryParse(input, out n) || n < 1)
            {
                Console.WriteLine("Por favor, digite um número inteiro positivo maior do que zero.");
                return;
            }

            int numero = 2;
            int contador = 0;

            while (contador < n)
            {

                bool primo = true;

                for (int i = 2; i <= Math.Sqrt(numero); i++)
                {
                    if (numero % i == 0)
                    {
                        primo = false;
                        break;
                    }
                }

                if (primo)
                {
                    Console.Write(numero + " ");
                    contador++;
                }

                numero++;
            }
        }
    }
}
