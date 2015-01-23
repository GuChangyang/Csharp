using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atm
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("请输入密码");
            //int pass = int.Parse(Console.ReadLine());
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("请输入密码");
                int pass = int.Parse(Console.ReadLine());
                if (pass == 888888)
                { 
                    int amount;
                    do
                    {
                        Console.WriteLine("请输入您的取款金额。");
                        amount = int.Parse(Console.ReadLine());
                    }
                    while (!(amount >= 0 && amount <= 1000 && amount % 100 == 0));
                    Console.WriteLine("您取了{0}元\n交易完成，请取卡。",amount);
                    break;
                }
                else
                {
                    Console.WriteLine("密码输入错误，请重新输入");
                    continue;
                }
            }
            Console.ReadLine();
        }
    }
}
