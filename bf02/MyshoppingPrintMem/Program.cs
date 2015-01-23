using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace MyshoppingPrintMem
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0;i<3;i++)
            {
            Console.WriteLine("请输入会员号（四位整数）");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("请输入会生日（月/日<用2位整数表示>）");
            string bir = Console.ReadLine();
            Console.WriteLine("请输入积分");
            int point = int.Parse(Console.ReadLine());
            if (num<1000||num>9999)
              {
                Console.WriteLine("输入的会员号错误");
                continue;
               }
             else
                {
                 Console.WriteLine("您输入的的会员信息是：\n会员号：{0}，生日：{1}，积分{2}。",num,bir,point);
                }
            }   
            Console.ReadLine();
       }
    }
}