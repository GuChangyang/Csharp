using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(getresult());
            Console.ReadLine(); 
        }
        public static string getresult()
        {
            Console.WriteLine("请输入第一个操作数：");
            int first = int.Parse(Console.ReadLine());
            Console.WriteLine("请输入第二个操作数：");
            int second = int.Parse(Console.ReadLine());
            Console.WriteLine("请输入运算符");
            string fun = Console.ReadLine();
            int result = 0;
            if (fun == "+")
            {
                result = first + second;
            }
            else if (fun == "-")
            {
                result = first - second;
            }
            else if (fun == "*")
            {
                result = first * second;
            }
            else if (fun == "/" || fun == "%")
            {
                if (second != 0)
                {
                    if (fun == "/")
                    {
                        result = first / second;
                    }
                    else
                    {
                        result = first % second;
                    }
                }
                else
                    return "分母不能为0";
            }
            return "结果是：" + result;
        }      
    }      
   }

