using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finances_manage_app
{
    internal class Expense
    {
        private string name;
        private double amount;

        public double Amount
        {
            get { return amount; }
            set { amount = value; }
        }

        public void InitializeExpense(string name, double amount)
        {
            this.name = name;
            this.amount = amount;
        }

        public string GetInfo()
        {
            return $"{name}  - {amount}";
        }
    }


}
