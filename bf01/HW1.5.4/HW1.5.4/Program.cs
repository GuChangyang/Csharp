using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1._5._4
{
   public class Program
    {
       public static void Main(string[] args)
        {
            Console.WriteLine("请输入您的姓名：");
            string name = Console.ReadLine();
            Console.WriteLine("请输入您的星座：");
            string xz = Console.ReadLine();
            Console.WriteLine("请输入您的年龄");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine(" 您的姓名是：{0}\n您的星座是：{1}\n您的年龄是：{2}",name,xz,age);
            Console.ReadLine();
        }
    }
}
