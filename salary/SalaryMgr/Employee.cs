using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SalaryMgr
{
    public class Employee
    {
        private string employeeId;
        private Tax _tax;

        public Employee()
        {
            this._tax = new Tax();
        }

        public string EmployeeId
        {
            get { return employeeId; }
            set { employeeId = value; }
        }
        private string employeeName;

        public string EmployeeName
        {
            get { return employeeName; }
            set { employeeName = value; }
        }
        private DateTime employeeBirth;

        public DateTime EmployeeBirth
        {
            get { return employeeBirth; }
            set { employeeBirth = value; }
        }
        private string employeeMobile;

        public string EmployeeMobile
        {
            get { return employeeMobile; }
            set { employeeMobile = value; }
        }
        private DateTime enterTime;

        public DateTime EnterTime
        {
            get { return enterTime; }
            set { enterTime = value; }
        }
        private string dutyName;

        public string DutyName
        {
            get { return dutyName; }
            set { dutyName = value; }
        }
        private Corp corp;

        public Corp Corp
        {
            get { return corp; }
            set { corp = value; }
        }
        private double baseSalay;

        public double BaseSalay
        {
            get { return baseSalay; }
            set { baseSalay = value; }
        }

        public double CalcSalary()
        {
            //Tax tax = new Tax();
            return this.baseSalay - this._tax.CalcTax(this.baseSalay);
        }
    }
}
