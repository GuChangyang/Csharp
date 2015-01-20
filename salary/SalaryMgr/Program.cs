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
            Console.WriteLine("Initializing Information...");

            Corp corp = new Corp();

            Employee emp1 = new Employee();
            emp1.EmployeeId = "1001";
            emp1.EmployeeName = "zhang";
            emp1.EmployeeMobile = "12435354353";
            emp1.EmployeeBirth = DateTime.Parse("1988-1-1");
            emp1.DutyName = "Normal Employee";
            emp1.BaseSalay = 3000;
            emp1.EnterTime = DateTime.Parse("2010-1-1");
            emp1.Corp = new Corp("12324", "apple", "zhang", "0551-3344556", "http://www.crop.com.cn");


            corp.AddEmployee(emp1);

            Employee emp2 = new Employee();
            emp2.EmployeeId = "1002";
            emp2.EmployeeName = "lishi";
            emp2.EmployeeMobile = "12435354353";
            emp2.EmployeeBirth = DateTime.Parse("1978-1-1");
            emp2.DutyName = "Normal Employee";
            emp2.BaseSalay = 2000;
            emp2.EnterTime = DateTime.Parse("2010-1-2");
            emp2.Corp = new Corp("12324", "Dell", "zhang", "0551-3344556", "http://www.crop.com.cn");

            corp.AddEmployee(emp2);

            Employee emp3 = new Employee();
            emp3.EmployeeId = "1003";
            emp3.EmployeeName = "wang";
            emp3.EmployeeMobile = "12435354353";
            emp3.EmployeeBirth = DateTime.Parse("1978-2-1");
            emp3.DutyName = "Normal Employee";
            emp3.BaseSalay = 2500;
            emp3.EnterTime = DateTime.Parse("2010-2-2");
            emp3.Corp = new Corp("12324", "Dell", "zhang", "0551-3344556", "http://www.crop.com.cn");

            corp.AddEmployee(emp3);

            System.Threading.Thread.Sleep(3000);
            Console.WriteLine("Initialization Completed");

            Console.WriteLine("Select following options：\n1、Check_Employee\n2、Fire_Employee\n3、Add_new_Employee\n4、Update_Employee's_information");
            int opt = int.Parse(Console.ReadLine());

            //查询员工
            if (opt == 1)
            {
                Console.Write("Please enter the Employee ID:");
                string employeeId = Console.ReadLine();

                Employee result = corp.GetEmployeeById(employeeId);
                if (result != null)
                {
                    Console.WriteLine("The employee's information is following：\nID:{0}\nName:{1}\nBirthday：{2}\nTel:{3}\nCompany:{4}\nSalary:{5}",
                        result.EmployeeId, result.EmployeeName, result.EmployeeBirth, result.EmployeeMobile, result.Corp.CorpName, result.CalcSalary());
                }
                else
                {
                    Console.WriteLine("Can not find");
                }
                Console.ReadLine();

                return;
            }
            //删除员工
            if (opt == 2)
            {
                Console.Write("Please enter the Employee's ID you want to delete:");

                string _empNo = Console.ReadLine();

                Console.WriteLine("before delete the total number is:" + corp.GetAllEmployees().Count);
                bool isok = corp.DelEmployee(_empNo);
                if (isok)
                {
                    Console.WriteLine("delete successfully!");
                    Console.WriteLine("Now the number is:" + corp.GetAllEmployees().Count);
                }
                else
                {
                    Console.WriteLine("Can not delete, please check the employee's number");
                }
                Console.ReadLine();
                return;
            }

            



        }
    }
}
