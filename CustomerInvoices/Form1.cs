using CustomerInvoicesLogic;
using CustomerInvoicesModels.Request;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerInvoices
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var customerId = textBox1.Text;
            var startDate = dateTimePicker1.Value;
            var endDate = dateTimePicker2.Value;
            var request = new InvoiceCountRequest(customerId, startDate, endDate);
            var result = new PerDayLogic().GetCustomerInvoicesCount(request);
            textBox3.Text = result.CustomerInvoices.ToString();
            textBox2.Text = result.Calls.ToString();
        }
    }
}
