using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercici0_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input = inputTextBox.Text.ToLower();
            string reversed = new string(input.Reverse().ToArray());

            if (input == reversed)
            {
                resultado.Text = "Es un palíndromo";
            }
            else
            {
                resultado.Text = "No es un palíndromo";
            }
            
        }

      
    }
    
                
    }

