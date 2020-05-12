using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Задание_1_г
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            A.Minimum = decimal.MinValue;
            A.Maximum = decimal.MaxValue;
            B.Minimum = decimal.MinValue;
            B.Maximum = decimal.MaxValue;
            H.Maximum = decimal.MaxValue;
        }
        private decimal f(decimal x)
        {
            try
            {
                if (Math.Abs(x) == 1) throw new Exception();
                else return 1 / (x * x - 1);
            }
            catch
            {
                throw;
            }
        }
        private void Rashbutton_Click(object sender, EventArgs e)
        {
            Res.Clear();
            if (B.Value < A.Value)
                Res.Text += "Конечное значение числа x меньше начального значения";
            for (decimal i = A.Value; i <= B.Value; i += H.Value)
                try
                {
                    Res.Text += "y( " + Math.Round(i, 5) + " )= "+ Math.Round(f(Math.Round(i, 5)), 5)+ "\n";
                }
                catch
                {
                    Res.Text += "y( " + i + " )=error"+"\n";
                }
        }
    }
}
