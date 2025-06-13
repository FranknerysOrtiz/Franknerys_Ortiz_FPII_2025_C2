using System;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Loteria
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            MessageBox.Show("Ingresa un numero del 1-100");
        }

        private void btnJugar_Click(object sender, EventArgs e)
        {
            string num = txtNumero.Text;
            string monto = txtMonto.Text;
            

            if (string.IsNullOrWhiteSpace(num) || string.IsNullOrWhiteSpace(monto))
            {
                MessageBox.Show("Tiene que llenar ambos espacios");
            }

            Random rnd = new Random();
            int num1 = rnd.Next(1, 1001);
            int num2 = rnd.Next(1, 101);
            int num3 = rnd.Next(1, 11);

            lblNum1.Text = num1.ToString();
            lblNum2.Text = num2.ToString();
            lblNum3.Text = num3.ToString();

            if (num == num1.ToString() || num == num2.ToString() || num == num3.ToString())
            {
                if (num == num1.ToString() && num == num2.ToString() || num == num1.ToString() && num == num3.ToString() || num == num2.ToString() && num == num3.ToString())
                {
                    if (int.TryParse(monto, out int montoNumerico1))
                    {
                        txtPremio.Text = ((montoNumerico1 * 10) * 2).ToString();
                    }

                }
                else if (int.TryParse(monto, out int montoNumerico))
                {
                    txtPremio.Text = (montoNumerico * 10).ToString();
                }
            }
            else
            {
                MessageBox.Show("No haz ganado");
            }

        }


    }
}


