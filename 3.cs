using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    internal class Ex3
    {
        static void Main(string[] args)
        {
            int n, i, maior = 0, menor = 0;

            for (i = 1; i <= 20; i++)
            {
                Console.WriteLine("Insira o {0}º numero: ", i);
                n = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                if (i == 1) {
                    maior = n;
                    menor = n;
                }
                if (n > maior)
                    maior = n;
                else if (n < menor && n < maior)
                    menor = n;
            }
            Console.WriteLine("Maior numero digitado: {0}\nMenor numero digitado {1}",maior,menor);
            Console.ReadKey();
        }
    }
}
