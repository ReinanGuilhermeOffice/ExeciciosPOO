using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioCSharp
{
    public static class Questao02
    {
        public static void Exec()
        {
            //Desenvolva um programa que calcule a soma dos 10 primeiros números inteiros pares positivos.

            int contador = 0;
            int soma = 0;

            while (contador < 10)
            {

                Console.Write("Digite um número inteiro: ");
                string input = Console.ReadLine();
                int numero;

                if (!int.TryParse(input, out numero) || numero % 2 != 0 || numero <= 0)
                {
                    Console.WriteLine("Por favor, digite um número inteiro par positivo!");
                    continue;
                }

                soma += numero;
                contador++;
            }

            Console.WriteLine("A soma dos 10 primeiros números inteiros pares positivos é: " + soma);

        }
    }
}
