using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioCSharp
{
    public static class Questao04
    {
        public static void Exec()
        {
            Console.WriteLine("Converter temperatura de Celsius para Fahrenheit ou vice-versa.");
            Console.WriteLine("Escolha a opção:");
            Console.WriteLine("[1] Converter de Celsius para Fahrenheit");
            Console.WriteLine("[2] Converter de Fahrenheit para Celsius");

            int escolha = 0;
            double temperatura = 0;
            bool entradaValida = false;

            // Loop até o usuário fornecer uma entrada válida
            while (!entradaValida)
            {
                Console.Write("Opção: ");
                string input = Console.ReadLine();

                // Validar entrada do usuário
                if (!int.TryParse(input, out escolha))
                {
                    Console.WriteLine("Entrada inválida. Por favor, entre com um número inteiro válido.");
                }
                else if (escolha != 1 && escolha != 2)
                {
                    Console.WriteLine("Opção inválida. Por favor, escolha 1 ou 2.");
                }
                else
                {
                    entradaValida = true;
                }
            }

            Console.Write("Temperatura: ");
            entradaValida = false;

            // Loop até o usuário fornecer uma entrada válida
            while (!entradaValida)
            {
                string input = Console.ReadLine();

                // Validar entrada do usuário
                if (!double.TryParse(input, out temperatura))
                {
                    Console.WriteLine("Entrada inválida. Por favor, entre com um número válido.");
                }
                else
                {
                    entradaValida = true;
                }
            }

            double resultado = 0;

            // Realizar conversão de acordo com a escolha do usuário
            if (escolha == 1)
            {
                resultado = (temperatura * 9 / 5) + 32;
                Console.WriteLine("{0}°C = {1}°F", temperatura, resultado);
            }
            else
            {
                resultado = (temperatura - 32) * 5 / 9;
                Console.WriteLine("{0}°F = {1}°C", temperatura, resultado);
            }

            Console.ReadKey(); // Aguarda uma tecla ser pressionada antes de encerrar o programa
            }
        }
    }
