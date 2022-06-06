using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atvFibonacci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void getIndex_Click(object sender, EventArgs e)
        {
            int numero = Convert.ToInt32(numeroInput.Text);

            int fib1 = 0;
            int fib2 = 1;
            int counter = 3;
            while (counter <= numero)
            {
                int fib3 = fib1 + fib2;
                fib1 = fib2;
                fib2 = fib3;
                counter += 1;
                fiboRes.Text = $"Fibonacci do indice desejado é: {fib3}";
            }
            
        }

        private void clearFields_Click(object sender, EventArgs e)
        {
            numeroInput.Text = "";
            fiboRes.Text = "";
        }

        private void getSequence_Click(object sender, EventArgs e)
        {
            int numero = Convert.ToInt32(numeroInput.Text);

            int fib1 = 0;
            int fib2 = 1;
            fiboRes.Text = $" {fib1} > {fib2} ";
            for(int i = 3; i <= numero; i= i += 1)
            {
                int fib3 = fib1 + fib2;
                fiboRes.Text += $" > {fib3} ";
                fib1 = fib2;
                fib2 = fib3;
            }
        }
    }
}
