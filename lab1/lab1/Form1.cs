using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            if (textBox_login.Text == "Artem" && textBox_password.Text == "123")
            {
                label_login.BackColor = Color.Green;
                label_password.BackColor = Color.Green;
                label_ok.BackColor = Color.Green;
                MessageBox.Show("Hello, Artem");
            }
            if (textBox_login.Text != "Artem" && textBox_password.Text != "123")
            {
                label_login.BackColor = Color.Red;
                label_password.BackColor = Color.Red;
                label_ok.BackColor = Color.Red;
                MessageBox.Show("Wrong login and password");
            }
            else
            {
                if (textBox_login.Text != "Artem")
                {
                    label_login.BackColor = Color.Red;
                    label_password.BackColor = Color.Green;
                    label_ok.BackColor = Color.Red;
                    MessageBox.Show("Wrong login");
                }
                if (textBox_password.Text != "123")
                {
                    label_login.BackColor = Color.Green;
                    label_password.BackColor = Color.Red;
                    label_ok.BackColor = Color.Red;
                    MessageBox.Show("Wrong password");
                }
            }
        }
    }
}
