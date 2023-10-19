using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4
{
    internal class Ex4
    {
        static void Main(string[] args)
        {
            int idade, rep=1, maior=0;

            while (rep <= 10)
            {
                Console.WriteLine("Digite a {0}º idade", rep);
                idade = Convert.ToInt32(Console.ReadLine());
                if (idade >= 18)
                    maior += 1;
                rep++;
            }
            Console.Clear();
            Console.WriteLine("-> {0} pessoas possuem mais de 18 anos",maior);
            Console.ReadKey();
        }
    }
}
