using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6
{
    internal class Ex6
    {
        static void Main(string[] args)
        {
            double x = 1, y = 0;
            while (x < 10)
            {
                y++;
                if (y == 10)
                {
                    x++;
                    y = 0;
                }
                Console.WriteLine("-> {0}.{1}",x,y);
            }
            Console.ReadKey();
        }
    }
}
