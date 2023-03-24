using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioCSharp
{
    public static class Questao06
    {
        public static void Exec()
        {
            Console.WriteLine("Calcular nota de aproveitamento do aluno.");

            double p1 = 0, p2 = 0, t = 0, ap = 0;
            bool entradaValida = false;

            while (!entradaValida)
            {
                Console.Write("Nota da P1: ");
                string input1 = Console.ReadLine();

                Console.Write("Nota da P2: ");
                string input2 = Console.ReadLine();

                Console.Write("Nota do trabalho: ");
                string input3 = Console.ReadLine();

                if (!double.TryParse(input1, out p1) || !double.TryParse(input2, out p2) || !double.TryParse(input3, out t))
                {
                    Console.WriteLine("Entrada inválida. Por favor, entre com números válidos.");
                }
                else if (p1 < 0 || p1 > 10 || p2 < 0 || p2 > 10 || t < 0 || t > 10)
                {
                    Console.WriteLine("Notas inválidas. Por favor, entre com notas entre 0 e 10.");
                }
                else
                {
                    entradaValida = true;
                }
            }

            ap = ((p1 * 2) + (p2 * 3) + (t * 2)) / 7;

            Console.WriteLine("Nota de aproveitamento do aluno: {0:F2}", ap);
        }
    }
}
