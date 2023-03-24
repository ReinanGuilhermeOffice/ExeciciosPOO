using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioCSharp
{
    public static class Questao05
    {
        public static void Exec()
        {
            Console.WriteLine("Determinar a data cronologicamente maior de duas datas.");

            Console.Write("Primeira data (DD/MM/AAAA): ");
            string input1 = Console.ReadLine();
            Console.Write("Segunda data (DD/MM/AAAA): ");
            string input2 = Console.ReadLine();

            DateTime data1, data2;
            if (!DateTime.TryParse(input1, out data1) || !DateTime.TryParse(input2, out data2))
            {
                Console.WriteLine("Entrada inválida. Por favor, entre com uma data válida no formato DD/MM/AAAA.");
                return;
            }

            if (data1 > data2)
            {
                Console.WriteLine("{0} é a mais recente.", data1.ToShortDateString());
            }
            else
            {
                Console.WriteLine("{0} é a mais recente.", data2.ToShortDateString());
            }
        }
    }
}
