using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SalaryMgr
{
    public class Corp
    {
        private string _corpId;

        //private Employee[] emloyees = null;
        private List<Employee> employees = new List<Employee>();

        public Corp()
        {
            //emloyees = new List<Employee>();
        
        }
        public Corp(string corpId,string corpName,string corpLeader,string corpTel,string corpWeb)
        {
            //emloyees = new List<Employee>();
            this.CorpId = corpId;
            this.CorpName = corpName;
            this.CorpLeader = corpLeader;
            this.CorpTel = corpTel;
            this.CorpWeb = corpWeb;

        }
      

        public string CorpId
        {
            get { return _corpId; }
            set { _corpId = value; }
        }
        private string _corpName;

        public string CorpName
        {
            get { return _corpName; }
            set { _corpName = value; }
        }
        private string _corpLeader;

        public string CorpLeader
        {
            get { return _corpLeader; }
            set { _corpLeader = value; }
        }
        private string _corpWeb;

        public string CorpWeb
        {
            get { return _corpWeb; }
            set { _corpWeb = value; }
        }
        private string _corpTel;

        public string CorpTel
        {
            get { return _corpTel; }
            set { _corpTel = value; }
        }
        //入职新员工
        public void AddEmployee(Employee employee)
        {
            this.employees.Add(employee);
        }

        public void AddEmployee(string employeeId, string employeeName, DateTime employeeBirth, string employeeMobile, DateTime enterTime, string dutyName, Corp corp, double baseSalay)
        {
            Employee emp = new Employee();
            emp.EmployeeId = employeeId;
            emp.EmployeeName = employeeName;
            emp.EmployeeBirth = employeeBirth;
            emp.EmployeeMobile = employeeMobile;
            emp.EnterTime = enterTime;
            emp.DutyName = emp.DutyName;
            emp.BaseSalay = baseSalay;
            emp.Corp = corp;

            //this.employees.Add(emp);
            this.AddEmployee(emp);
        }

        public void ModifyEmployee(Employee empoyee)
        {
            int index = -1;
            for(int i=0;i<this.employees.Count;i++)
            {
                if (employees[i].EmployeeId == empoyee.EmployeeId)
                {
                    index = i;
                    break;             
                }
            }

            if (index != -1)
            {
                this.employees[index] = empoyee;
            }
        }
        /// <summary>
        /// 修改员工信息
        /// </summary>
        /// <param name="employeeId"></param>
        /// <param name="employeeName"></param>
        /// <param name="employeeBirth"></param>
        /// <param name="employeeMobile"></param>
        /// <param name="enterTime"></param>
        /// <param name="dutyName"></param>
        /// <param name="corp"></param>
        /// <param name="baseSalay"></param>
        public void ModifyEmployee(string employeeId, string employeeName, DateTime employeeBirth, string employeeMobile, DateTime enterTime, string dutyName, Corp corp, double baseSalay)
        {
            Employee emp = new Employee();
            emp.EmployeeId = employeeId;
            emp.EmployeeName = employeeName;
            emp.EmployeeBirth = employeeBirth;
            emp.EmployeeMobile = employeeMobile;
            emp.EnterTime = enterTime;
            emp.DutyName = emp.DutyName;
            emp.BaseSalay = baseSalay;
            emp.Corp = corp;

            this.ModifyEmployee(emp);

        
        }

        public bool DelEmployee(Employee employee)
        {
            if (this.employees.Count > 0)
            {
                this.employees.Remove(employee);
                return true;
            }

            return false;
        }
        /// <summary>
        /// 删除员工信息
        /// </summary>
        /// <param name="employeeId"></param>
        /// <returns></returns>
        public bool DelEmployee(string employeeId)
        {
            Employee employee = this.GetEmployeeById(employeeId);
            if (employee!=null)
            {
                this.DelEmployee(employee);
                return true;
            }

            return false;
           
        }
        /// <summary>
        /// 根据员工ID查找员工实体信息
        /// </summary>
        /// <param name="employeeId"></param>
        /// <returns></returns>
        public Employee GetEmployeeById(string employeeId)
        {
            Employee _emp = null;
            if (this.employees.Count > 0)
            {
                foreach (Employee emp in this.employees)
                {
                    if (emp.EmployeeId == employeeId)
                    {
                        _emp = emp;
                        break;
                    }
                }
            }


            return _emp;
        }

        public List<Employee> GetAllEmployees()
        {

            return this.employees;
        }




    }
}
