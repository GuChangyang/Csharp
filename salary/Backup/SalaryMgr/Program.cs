using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SalaryMgr
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("初使化公司信息中...");

            Corp corp = new Corp();

            Employee emp1 = new Employee();
            emp1.EmployeeId = "1001";
            emp1.EmployeeName = "zhang";
            emp1.EmployeeMobile = "12435354353";
            emp1.EmployeeBirth = DateTime.Parse("1988-1-1");
            emp1.DutyName = "普通员工";
            emp1.BaseSalay = 3000;
            emp1.EnterTime = DateTime.Parse("2010-1-1");
            emp1.Corp = new Corp("12324", "中华科技", "张三", "0551-3344556", "http://www.crop.com.cn");


            corp.AddEmployee(emp1);

            Employee emp2 = new Employee();
            emp2.EmployeeId = "1002";
            emp2.EmployeeName = "lishi";
            emp2.EmployeeMobile = "12435354353";
            emp2.EmployeeBirth = DateTime.Parse("1978-1-1");
            emp2.DutyName = "普通员工";
            emp2.BaseSalay = 2000;
            emp2.EnterTime = DateTime.Parse("2010-1-2");
            emp2.Corp = new Corp("12324", "中华科技", "张三", "0551-3344556", "http://www.crop.com.cn");

            corp.AddEmployee(emp2);

            Employee emp3 = new Employee();
            emp3.EmployeeId = "1003";
            emp3.EmployeeName = "wang";
            emp3.EmployeeMobile = "12435354353";
            emp3.EmployeeBirth = DateTime.Parse("1978-2-1");
            emp3.DutyName = "普通员工";
            emp3.BaseSalay = 2500;
            emp3.EnterTime = DateTime.Parse("2010-2-2");
            emp3.Corp = new Corp("12324", "中华科技", "张三", "0551-3344556", "http://www.crop.com.cn");

            corp.AddEmployee(emp3);

            System.Threading.Thread.Sleep(3000);
            Console.WriteLine("系统初使化工作已完成!");

            Console.WriteLine("请选择您的操作：\n1、查询员工\n2、开除员工\n3、入职新员工\n4、修改员工基本信息");
            int opt = int.Parse(Console.ReadLine());

            //查询员工
            if (opt == 1)
            {
                Console.Write("请输入员工的编号进行查找:");
                string employeeId = Console.ReadLine();

                Employee result = corp.GetEmployeeById(employeeId);
                if (result != null)
                {
                    Console.WriteLine("该员工信息如下：\n编号:{0}\n姓名:{1}\n出生日期：{2}\n联系方式:{3}\n所属公司:{4}\n应发工资:{5}",
                        result.EmployeeId, result.EmployeeName, result.EmployeeBirth, result.EmployeeMobile, result.Corp.CorpName, result.CalcSalary());
                }
                else
                {
                    Console.WriteLine("查无此人!");
                }
                Console.ReadLine();

                return;
            }
            //删除员工
            if (opt == 2)
            {
                Console.Write("请输入要删除员工的工号:");

                string _empNo = Console.ReadLine();

                Console.WriteLine("删除前公司员工人数为:" + corp.GetAllEmployees().Count);
                bool isok = corp.DelEmployee(_empNo);
                if (isok)
                {
                    Console.WriteLine("删除成功!");
                    Console.WriteLine("目前公司员工人数为:" + corp.GetAllEmployees().Count);
                }
                else
                {
                    Console.WriteLine("删除失败！请检查员工编号是否正确1");
                }
                Console.ReadLine();
                return;
            }

            



        }
    }
}
