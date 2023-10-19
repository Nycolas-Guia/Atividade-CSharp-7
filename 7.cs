using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex7
{
    internal class Ex7
    {
        static void Main(string[] args)
        {
            double nota, i=1, c = 0;
            char res;
            inicio:
            do
            {                
                Console.WriteLine("Digite a nota {0}: ", i);
                nota = Convert.ToDouble(Console.ReadLine());
                if (nota > 0 && nota < 10)
                {
                    c = c + nota;
                    i++;
                }
                Console.Clear();
            } while (i < 5);

            Console.WriteLine("Confirme para ver a média: s/n");
            res = Convert.ToChar(Console.ReadLine());

            if (res == 'n')
            {
                i = 1;
                c = 0;
                goto inicio;
            }            
            c = c / 4;
            Console.WriteLine("Média = {0}",c);
            Console.ReadKey();
        }
    }
}
