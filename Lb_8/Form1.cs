using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Lb_8
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox.Text.Length == 0)
            {
                System.Media.SystemSounds.Beep.Play();
                textBox.BackColor = Color.Red;
                textBox.Focus();
            }
            else
            {
                textBox.BackColor = Color.White;
            }
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SelectNextControl((Control)sender, true, true, false, true);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                System.Media.SystemSounds.Beep.Play();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                System.Media.SystemSounds.Beep.Play();
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                System.Media.SystemSounds.Beep.Play();
            }
            else if (e.KeyChar == ',' && textBox.Text.Length == 0)
            {
                e.Handled = true;
                System.Media.SystemSounds.Beep.Play();
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                System.Media.SystemSounds.Beep.Play();
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {

                e.Handled = true;
                textBox5.BackColor = Color.White;

            }
        }

        private void textBox5_Leave(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox.Text.Length == 0 || textBox.Text.Length > 2)
            {
                System.Media.SystemSounds.Beep.Play();
                textBox.BackColor = Color.Red;
                textBox.Focus();
            }
            else
            {
                textBox.BackColor = Color.White;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool Error = false;
            foreach (Control control in Controls)
            {
                if (control is TextBox textBox && textBox != textBox6)
                {
                    if(textBox.Text == "")
                    {
                        Error = true;
                        MessageBox.Show("Не заповненні всі рядки!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                }
              
            }
            if (!Error)
            {
                float value1 = float.Parse(textBox3.Text);
                float value2 = float.Parse(textBox4.Text);
                int discount = int.Parse(textBox5.Text);

                float result = (value1 * value2) * (1 - discount / 100.0f);
                textBox6.Text = result.ToString();
            }
            textBox1.Focus();

      
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Control control in Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Text = "";
                }
            }
            textBox1.Focus();
        }
    }
}
