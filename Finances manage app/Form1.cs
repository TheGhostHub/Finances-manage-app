using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Finances_manage_app
{
    public partial class Form1 : Form
    {
        private List<Expense> transactionLog;

        public Form1()
        {
            InitializeComponent();
            transactionLog = new List<Expense>();
        }

        private void btnaddexpensetotranslog_Click(object sender, EventArgs e)
        {
            
            if (double.TryParse(noboxamount.Text, out double amount))
            {
                Expense expense = new Expense();
                expense.InitializeExpense(txtboxname.Text, amount);
                transactionLog.Add(expense);

                txtboxname.Text = "";
                noboxamount.Value = 0;
                
            }
            else
            {
                MessageBox.Show("Invalid amount");
            }

        }

        private void btnshowallexpenses_Click(object sender, EventArgs e)
        {
            listBoxExpenses.Items.Clear();
            foreach (Expense expense in transactionLog)
            {
                listBoxExpenses.Items.Add(expense.GetInfo());
            }
        }

        private void btnshowexpenseswithsameamount_Click(object sender, EventArgs e)
        {
            /*
            listBoxExpenses.Items.Clear();
            if (double.TryParse(noboxamount2.Text, out double amount))
            {
                foreach (Expense expense in transactionLog)
                {
                    if (expense.Amount == amount)
                    {
                        listBoxExpenses.Items.Add(expense.GetInfo());
                    }
                }
            }
            else
            {
                MessageBox.Show("Invalid amount");
            }
            */

            listBoxExpenses.Items.Clear();
            double targetAmount = double.Parse(noboxamount2.Text);

            foreach (Expense expense in transactionLog)
            {
                if (expense.Amount == targetAmount)
                {
                    listBoxExpenses.Items.Add(expense.GetInfo());
                }
            }
        }
    }
}
