using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isRight = true;
            Console.WriteLine("*******************");
            Console.WriteLine("1.客户信息管理");
            Console.WriteLine("2.购物结算");
            Console.WriteLine("3.真情回馈");
            Console.WriteLine("4.注销");
            Console.WriteLine("*******************");
            Console.WriteLine("请选择输入数字：");
            int a = int.Parse(Console.ReadLine());
            if (a>4)
            {
                isRight = false;
                do
                {
                    Console.WriteLine("输入错误，请重新输入");
                    Console.WriteLine("请选择输入数字：");
                    a = int.Parse(Console.ReadLine());
                    if (a > 4)
                    {
                        isRight = false;
                    }
                    else
                        isRight = true;
                    switch (a)
                    {
                        case 1:
                            Console.WriteLine("客户信息管理成功");
                            break;
                        case 2:
                            Console.WriteLine("购物结算成功");
                            break;
                        case 3:
                            Console.WriteLine("真情回馈成功");
                            break;
                        case 4:
                            Console.WriteLine("注销成功");
                            break;
                    }
                }
                while (!isRight);

            }
                else 
                {
                    isRight = true;
                 switch (a)
                 {
                     case 1 :
                         Console.WriteLine("客户信息管理成功");
                         break;
                     case 2:
                          Console.WriteLine("购物结算成功");
                          break;
                     case 3:
                          Console.WriteLine("真情回馈成功");
                          break;
                     case 4:
                         Console.WriteLine("注销成功");
                         break;
                 }
                }
            Console.ReadLine();
        }
    }
}
