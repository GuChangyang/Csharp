using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maiji
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int j;
            int k;
            for (i = 0; i <= 20;i++ )
            {
                for (j = 0; j <= 33; j++)
                {
                    for (k = 0; k <= 300; k++)
                    {
                        if ((i + j + k == 100) && (5 * i + 3 * j + k / 3) == 100 && (k % 3 == 0))
                        {
                            Console.WriteLine("公鸡个数为：{0}\n母鸡个数为：{1}\n雏鸡个数为：{2} ", i, j, k);
                        }
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
