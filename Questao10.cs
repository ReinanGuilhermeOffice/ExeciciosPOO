using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioCSharp
{
    public static class Questao10
    {
        public static void Exec()
        {
            string pasta = @"C:\Users\Reinan.Neto\Desktop\Projetos Reinan\ExercicioCSharp\arquivos\";
            string arquivo = "arquivo1.txt";

            if (!Directory.Exists(pasta))
            {
                Console.WriteLine("Pasta 'arquivos' não encontrada.");
                return;
            }

            if (!File.Exists(Path.Combine(pasta, arquivo)))
            {
                Console.WriteLine("Arquivo '{0}' não encontrado na pasta 'arquivos'.", arquivo);
                return;
            }

            int[] numeros = File.ReadAllLines(Path.Combine(pasta, arquivo)).Select(int.Parse).ToArray();

            if (numeros.Length == 0)
            {
                Console.WriteLine("O arquivo '{0}' está vazio.", arquivo);
                return;
            }

            int maximo = numeros[0];
            for (int i = 1; i < numeros.Length; i++)
            {
                if (numeros[i] > maximo)
                {
                    maximo = numeros[i];
                }
            }

            int minimo = numeros[0];
            for (int i = 1; i < numeros.Length; i++)
            {
                if (numeros[i] < minimo)
                {
                    minimo = numeros[i];
                }
            }

            double media = numeros.Average();

            Console.WriteLine("Valor máximo: {0}", maximo);
            Console.WriteLine("Valor mínimo: {0}", minimo);
            Console.WriteLine("Média: {0:F2}", media);

        }
    }
}
