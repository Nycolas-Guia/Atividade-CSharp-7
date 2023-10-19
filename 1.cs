using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade11
{
    internal class Ex1
    {
        static void Main(string[] args)
        {
            int n, i;

            inicio:
            Console.WriteLine("Insira o ultimo numero da sequencia:");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            if (n > 0)
            {
                for (i = 1; i <= n; i++)
                {
                    Console.WriteLine("-> " + i);
                }
            }
            else
                goto inicio;
            Console.ReadKey();
        }
    }
}
