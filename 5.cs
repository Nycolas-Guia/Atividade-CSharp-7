using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5
{
    internal class Ex5
    {
        static void Main(string[] args)
        {
            int n, c = 1, negativo = 0;

            while (c <= 10)
            {
                Console.WriteLine("Digite o {0}º numero",c);
                n = Convert.ToInt32(Console.ReadLine());
                if (n < 0)
                    negativo = negativo + 1;
                c++;
            }
            Console.Clear();
            Console.WriteLine("Quantidade de numeros negativos:\n-> {0}",negativo);
            Console.ReadKey();
        }
    }
}
