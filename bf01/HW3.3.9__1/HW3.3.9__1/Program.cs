using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3._3._9__1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            getresult();
            Console.ReadLine();
        }
        public static void getresult()
        {
            Console.WriteLine("MyShopping管理系统>购物结算");
            Console.WriteLine("***************************");
            Console.WriteLine("请选择购买的商品编号：");
            Console.WriteLine("1.  T恤");
            Console.WriteLine("2.  网球鞋");
            Console.WriteLine("3.  网球拍");
            Console.WriteLine("***************************");
            Console.WriteLine("请输入商品编号：");
            int ch = int.Parse(Console.ReadLine());
            string infor= "";
            switch (ch)
            { 
                case 1 :
                    infor = "T恤   245";
                    break;
                  
                case 2 :
                    infor = "网球鞋  570";
                    break;
                 
                case 3 :
                    infor = "网球拍  320";
                    break;         
            }
            Console.WriteLine(infor);
            Console.WriteLine("是否继续  （y/n）?");
            string a = Console.ReadLine();
              while (a.Equals("y"))
            {
                Console.WriteLine("请输入商品编号：");
                ch = int.Parse(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        infor = "T恤   245";
                        break;

                    case 2:
                        infor = "网球鞋  570";
                        break;

                    case 3:
                        infor = "网球拍  320";
                        break;
                }
                Console.WriteLine(infor);
                Console.WriteLine("是否继续  （y/n）?");
                a = Console.ReadLine();
            }
             Console.WriteLine("程序结束");
            
               
            }



         
        
        }
    }
