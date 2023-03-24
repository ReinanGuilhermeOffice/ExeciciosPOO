using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioCSharp
{
    public static class Questao01
    {
    
        public static void Exec()
        {
            //Escreva um programa que, dados três valores inteiros diferentes entre si, apresente o maior de tais valores.

            Console.Write("Digite o primeiro número inteiro: ");
            string input1 = Console.ReadLine();
            int numero1;

            Console.Write("Digite o segundo número inteiro: ");
            string input2 = Console.ReadLine();
            int numero2;

            Console.Write("Digite o terceiro número inteiro: ");
            string input3 = Console.ReadLine();
            int numero3;

            if (!int.TryParse(input1, out numero1) || !int.TryParse(input2, out numero2) || !int.TryParse(input3, out numero3))
            {
                Console.WriteLine("Por favor, digite somente números inteiros!");
                return;
            }

            if (numero1 == numero2 || numero1 == numero3 || numero2 == numero3)
            {
                Console.WriteLine("Por favor, digite três números inteiros diferentes entre si!");
                return;
            }

            int maior = numero1;

            if (numero2 > maior)
            {
                maior = numero2;
            }

            if (numero3 > maior)
            {
                maior = numero3;
            }

            Console.WriteLine("O maior número digitado é: " + maior);

        }
    }
}
