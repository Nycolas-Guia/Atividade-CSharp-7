using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex9
{
    internal class Ex9
    {
        static void Main(string[] args)
        {
            double n, c = 0;

            do
            {
                Console.WriteLine("Digite um numero: ");
                n = Convert.ToDouble(Console.ReadLine());
                c = c + n;
                Console.Clear();
            } while (n != 0);
            Console.WriteLine("Soma dos numeros digitados:\n-> {0}",c);
            Console.ReadKey();
        }
    }
}
