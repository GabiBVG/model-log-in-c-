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
    public partial class Form1 : Form
    {
        public Form1()
        {
             InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var f = new Login();
            if(f.ShowDialog() == DialogResult.OK)
            {
                button1.Hide();
                var c = new Label();
                c.Text = "esti on";
                this.Controls.Add(c);
            }
        }
    }
}
