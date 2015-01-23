using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Checktime
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] data = new int[50];//用于存储整形数据  
            string input = "";
            int amount = 0;//存储输入数据的个数  
            int temp1 = 0, temp2 = 0;
            int k = 0;//计数临时变量，用于统计数据的二维数组  
            //输入数据  
            Console.WriteLine("请输入一组整形数据");
            input = Console.ReadLine();
            while (!input.Equals("y"))
            {
                data[amount] = int.Parse(input);
                input = Console.ReadLine();
                amount++;
            }
            int[,] total = new int[amount, 2];//用于存储整形信息  

            //统计数组中重复元素的个数  
            for (int i = 0; i < amount; i++)
            {
                if (data[i] != -1)
                {
                    temp1 = data[i];
                    for (int j = 0; j < amount; j++)
                    {
                        if (temp1 == data[j])
                        {
                            temp2++;
                            data[j] = -1;
                        }

                    }
                    total[k, 0] = temp1;
                    total[k, 1] = temp2;
                    temp2 = 0;
                    k++;
                }
            }
            //输出统计数据  

            Console.WriteLine("数据\t数据出现的次数");
            Console.WriteLine("=====================");
            for (int i = 0; i < k; i++)
            {
                if (total[i, 0] != 0)
                    Console.WriteLine("{0}\t{1}", total[i, 0], total[i, 1]);

            }
            Console.ReadLine();        
        }
    }
}
