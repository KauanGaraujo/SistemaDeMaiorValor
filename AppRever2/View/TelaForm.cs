using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppRever2.View
{
    public partial class TelaForm : Form
    {
        public TelaForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }





        private int quadrado(int num)
        {

            int resultado = num;
            return resultado;
        }







        private void button1_Click(object sender, EventArgs e)
        {

            int num1 = Convert.ToInt32(textBox1.Text);
            int num2 = Convert.ToInt32(textBox2.Text);
            int num3 = Convert.ToInt32(textBox3.Text);
            int resultado;

            if (num1 >= num2 && num1 >= num3)
            {
                resultado = num1;
            }
            else if (num2 >= num1 && num2 >= num3)
            {
                resultado = num2;
            }
            else
            {
                resultado = num3;
            }


            label5.Text = "O maior valor" + " é " + resultado;









        }

        private void button2_Click(object sender, EventArgs e)
        {
            label5.Text = "";
        }
    }
}






