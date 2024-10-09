using System.Diagnostics.Eventing.Reader;

namespace Calculator
{
    public partial class Form1 : Form
    {
        double var1, var2, ans;
        char sign;
        bool dec = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            if (tbx_ans.Text == "0")
            {
                tbx_ans.Text = "0";
            }
            else
            {
                tbx_ans.Text = tbx_ans.Text + "0";
            }
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            if (tbx_ans.Text == "0")
            {
                tbx_ans.Text = "1";
            }
            else
            {
                tbx_ans.Text = tbx_ans.Text + "1";
            }
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            if (tbx_ans.Text == "0")
            {
                tbx_ans.Text = "2";
            }
            else
            {
                tbx_ans.Text = tbx_ans.Text + "2";
            }
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            if (tbx_ans.Text == "0")
            {
                tbx_ans.Text = "3";
            }
            else
            {
                tbx_ans.Text = tbx_ans.Text + "3";
            }
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            if (tbx_ans.Text == "0")
            {
                tbx_ans.Text = "4";
            }
            else
            {
                tbx_ans.Text = tbx_ans.Text + "4";
            }
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            if (tbx_ans.Text == "0")
            {
                tbx_ans.Text = "5";
            }
            else
            {
                tbx_ans.Text = tbx_ans.Text + "5";
            }
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            if (tbx_ans.Text == "0")
            {
                tbx_ans.Text = "6";
            }
            else
            {
                tbx_ans.Text = tbx_ans.Text + "6";
            }
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            if (tbx_ans.Text == "0")
            {
                tbx_ans.Text = "7";
            }
            else
            {
                tbx_ans.Text = tbx_ans.Text + "7";
            }
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            if (tbx_ans.Text == "0")
            {
                tbx_ans.Text = "8";
            }
            else
            {
                tbx_ans.Text = tbx_ans.Text + "8";
            }
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            if (tbx_ans.Text == "0")
            {
                tbx_ans.Text = "9";
            }
            else
            {
                tbx_ans.Text = tbx_ans.Text + "9";
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            var1 = 0;
            var2 = 0;
            ans = 0;
            tbx_ans.Text = "0";
            tbx_equation.Text = "";

        }

        private void btn_equal_Click(object sender, EventArgs e)
        {
            if (double.TryParse(tbx_ans.Text, out var2))
            {
                if (sign == '+')
                {
                    ans = var1 + var2;
                    tbx_ans.Text = ans.ToString(); // Clear the textbox for the next input
                    tbx_equation.Text = tbx_equation.Text + var2.ToString() + " = ";
                }
                else if (sign == '-')
                {
                    ans = var1 - var2;
                    tbx_ans.Text = ans.ToString(); // Clear the textbox for the next input
                    tbx_equation.Text = tbx_equation.Text + var2.ToString() + " = ";
                }
                else if (sign == '*')
                {
                    ans = var1 * var2;
                    tbx_ans.Text = ans.ToString(); // Clear the textbox for the next input
                    tbx_equation.Text = tbx_equation.Text + var2.ToString() + " = ";
                }
                else if (sign == '/')
                {
                    ans = var1 / var2;
                    tbx_ans.Text = ans.ToString(); // Clear the textbox for the next input
                    tbx_equation.Text = tbx_equation.Text + var2.ToString() + " = ";
                }
            }
            else
            {
                // Handle the error, e.g., show a message to the user
                MessageBox.Show("Please enter a valid number.");
            }
        }

        private void btn_plus_Click(object sender, EventArgs e)
        {
            if (double.TryParse(tbx_ans.Text, out var1))
            {
                tbx_ans.Text = "0"; // Clear the textbox for the next input
                sign = '+'; // Store the operation sign
                tbx_equation.Text = var1.ToString() + " + ";
                dec = false;
            }
            else
            {
                // Handle the error, e.g., show a message to the user
                MessageBox.Show("Please enter a valid number.");
            }
        }

        private void btn_minus_Click(object sender, EventArgs e)
        {
            if (double.TryParse(tbx_ans.Text, out var1))
            {
                tbx_ans.Text = "0"; // Clear the textbox for the next input
                sign = '-'; // Store the operation sign
                tbx_equation.Text = var1.ToString() + " - ";
                dec = false;
            }
            else
            {
                // Handle the error, e.g., show a message to the user
                MessageBox.Show("Please enter a valid number.");
            }
        }

        private void btn_multiply_Click(object sender, EventArgs e)
        {
            if (double.TryParse(tbx_ans.Text, out var1))
            {
                tbx_ans.Text = "0"; // Clear the textbox for the next input
                sign = '*'; // Store the operation sign
                tbx_equation.Text = var1.ToString() + " x ";
                dec = false;
            }
            else
            {
                // Handle the error, e.g., show a message to the user
                MessageBox.Show("Please enter a valid number.");
            }
        }

        private void btn_divide_Click(object sender, EventArgs e)
        {
            if (double.TryParse(tbx_ans.Text, out var1))
            {
                tbx_ans.Text = "0"; // Clear the textbox for the next input
                sign = '/'; // Store the operation sign
                tbx_equation.Text = var1.ToString() + " / ";
                dec = false;
            }
            else
            {
                // Handle the error, e.g., show a message to the user
                MessageBox.Show("Please enter a valid number.");
            }
        }

        private void btn_decimal_Click(object sender, EventArgs e)
        {
            if (dec == false)
            {
                tbx_ans.Text = tbx_ans.Text + ".";
                dec = true;
            }
            else
            {
                tbx_ans.Text = tbx_ans.Text;
            }

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (tbx_ans.Text.Length == 1)
            {
                tbx_ans.Text = "0";
            }

            if (tbx_ans.Text != "0")
            {
                if (tbx_ans.Text[tbx_ans.Text.Length - 1] == '.')
                {
                    dec = false;
                }
                tbx_ans.Text = tbx_ans.Text.Substring(0, tbx_ans.Text.Length - 1);
            }
        }

        private void btn_posneg_Click(object sender, EventArgs e)
        {
            if (tbx_ans.Text == "0")
            {
                tbx_ans.Text = "0";
            }
            else
            {
                if (tbx_ans.Text[0] == '-')
                {
                    tbx_ans.Text = tbx_ans.Text.Substring(1);
                }
                else
                {
                    tbx_ans.Text = "-" + tbx_ans.Text;
                }
            }
        }
    }
}
