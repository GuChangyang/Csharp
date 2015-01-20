using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SalaryMgr
{
    public class Tax
    {
        private string _taxName;

        public string TaxName
        {
            get { return _taxName; }
            set { _taxName = value; }
        }
        private double _startMoney;

        public double StartMoney
        {
            get { return _startMoney; }
            set { _startMoney = value; }
        }
        private double _taxRate;

        public double TaxRate
        {
            get { return _taxRate; }
            set { _taxRate = value; }
        }

        private double _money;

        public double Money
        {
          get { return _money; }
          set { _money = value; }
        }

        public Tax() {
            this._taxName = "Personal Tax";
            this._startMoney = 2000;
            this._taxRate = 0.2;
        }



        public double CalcTax()
        {
            return this.Money > this.StartMoney ? (this.Money - this.StartMoney) * this.TaxRate : 0;
        }

        public double CalcTax(double money)
        {
            this.Money = money;
            return CalcTax();
        }
    }
}
