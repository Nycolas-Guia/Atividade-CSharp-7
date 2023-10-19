using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    internal class Ex2
    {
        static void Main(string[] args)
        {
            int n, i, som = 0;
           
            for (i = 1; i <= 10; i++)
            {
                Console.WriteLine("Insira o {0}º numero: ", i);
                n = Convert.ToInt32(Console.ReadLine());                
                if (n > 10)
                {
                    som = som + n;
                }
            }
            Console.Clear();
            Console.WriteLine("Soma dos numeros maiores que 10 = " + som);                       
            Console.ReadKey();
        }
    }
}
