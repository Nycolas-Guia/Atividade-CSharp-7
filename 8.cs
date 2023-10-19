using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex8
{
    internal class Ex8
    {
        static void Main(string[] args)
        {
            double n;
            do
            {
                Console.WriteLine("Digite um numero: ");
                n = Convert.ToDouble(Console.ReadLine());
                Console.Clear();
            } while (n > 1);
            Console.WriteLine("Achou :)");
            Console.ReadKey();
        }
    }
}
