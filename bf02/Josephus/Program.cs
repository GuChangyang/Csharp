using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Josephus
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[17]; int sum = 17;//共有17个人;             
            int k = 3;//每次数到3就退出;             
            int count = 0;//记录退出的人数;            
            int i = 0, j = 0; 
            for (int m = 0; m < sum; m++) 
               a[m] = 1;
            while (count < sum - 1)            
            {                 
                if (a[i] != 0)                    
                    j++;                
                if (j == k)                 
                {                      
                    a[i] = 0;
                    Console.WriteLine("{0}号退出。",i);
                    count++;                      
                    j = 0;//重新开始,找下一个值!                
                }                 
                i++;
                if (i == sum) 
                    i = 0;//实现环(即围成一圈);            
            } 
            for (int m = 0; m < sum; m++)                
                if (a[m] != 0)
                Console.Write("{0}号剩下了。",m);
                Console.Read();               
        }
    }
}
