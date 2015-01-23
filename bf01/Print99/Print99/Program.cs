using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print99
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int j;
            for (
                i = 1; i <= 9; i++)
            {
                for ( j = 1; j <= i; j++)
                {
                    Console.Write(i+"*"+ j + "=" +(i*j)+"  ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
