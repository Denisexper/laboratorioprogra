using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void NullReferenceException_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double num1 = 0;
                double num2 = 0;
                double result = 0;
                num1 = Convert.ToDouble(dia.Text);
                num2 = Convert.ToDouble(mes.Text);
                result = num1 + num2;
                resultado.Text = Convert.ToString(result);
            }
            catch
            {
                MessageBox.Show("se detecto un problema...", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

       
    }
}
