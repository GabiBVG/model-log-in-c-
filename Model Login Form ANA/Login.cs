using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Model_Login_Form_ANA
{
    public partial class Login : Form
    {
        string nume = "Ana";
        string parola = "pup&iubb";
        public Login()
        {
            InitializeComponent();
            this.textBoxParola.PasswordChar = '*';
            progressBar1.Hide();
            progressBar1.Maximum = 100;
            timer1.Interval = 100;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            groupBox1.Hide();
            progressBar1.Show();
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value == progressBar1.Maximum)
            {
                timer1.Stop();
                if ((textBox1.Text.CompareTo(nume) == 0) && (textBoxParola.Text.CompareTo(parola) == 0))
                {
                    DialogResult = DialogResult.OK;
                    MessageBox.Show("TE-ai logat");
                } 
                else
                {
                    DialogResult = DialogResult.Cancel;
                    MessageBox.Show("mai incearca");
                }
                this.Close();

            }
            else
            {
                progressBar1.Value += 10;
            }
            

        }
    }
}
