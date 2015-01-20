using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketPrice
{
    public class Program
    {
       public static void Main(string[] args)
        {
            Console.WriteLine("优惠后票价为："+ getprice());
            Console.ReadLine();
        }
       public static string getprice()
       {
           Console.WriteLine("请输入您属于哪类参观者：\n1-1.2米以下儿童。\n2-大中小学生。\n3-离退休人员。\n4-老年人。\n5-其它。");
           int ch =int.Parse(Console.ReadLine());
           Console.WriteLine("请输入您参观故宫的月份。");
           int month = int.Parse(Console.ReadLine());
           switch (ch)
           { 
               case 1:
                   return "0";
                   break;
                   
               case 2:
                   return "20";
                   break;
               case 3:
                   return "0";
                   break;
               case 4 :
                   switch (month)
                   { 
                       case 4:
                       case 5:
                       case 6:
                       case 7:
                       case 8:
                       case 9:
                       case 10:
                           return "30";
                           break;

                       default :
                           return "20";
                           break;                                             
                   }
               case 5:
                   switch (month){
               case 4:
               case 5:
               case 6:
               case 7:
               case 8:
               case 9:
               case 10:
                   return "60";
                   break;

               default:
                   return "40";
                   break;

               }
               default :
                   return null;
                   break;
           }
       
       }
    }
}
