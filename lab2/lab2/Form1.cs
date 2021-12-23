using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button_XOR_Click(object sender, EventArgs e)
        {
            string strS = textBox1.Text;
            int intS = Convert.ToInt32(strS, 10);
            try
            {
                string strP = textBox_P.Text;
                int intP = Convert.ToInt32(strP, intS);
                string strKey = textBox_Key.Text;
                int intKey = Convert.ToInt32(strKey, intS);

                int intC = intP ^ intKey;
                string strC = Convert.ToString(intC, intS);
                textBox_C.Text = strC;
                label4.Text = Convert.ToString(intC, 16);
                label5.Text = Convert.ToString(intC, 10);
            }
            catch
            {

            }
            try
            {
                string strdC = textBox_dC.Text;
                int intdC = Convert.ToInt32(strdC, intS);
                string strdKey = textBox_dKey.Text;
                int intdKey = Convert.ToInt32(strdKey, intS);

                int intdP = intdC ^ intdKey;
                string strdP = Convert.ToString(intdP, intS);
                textBox_dP.Text = strdP;
                label13.Text = Convert.ToString(intdP, 10);
                label14.Text = Convert.ToString(intdP, 16);
            }
            catch
            {

            }
        }


        private void button_clean_Click(object sender, EventArgs e)
        {
            textBox_P.Text = "";
            textBox_Key.Text = "";
            textBox_C.Text = "";
        }
    }
}
