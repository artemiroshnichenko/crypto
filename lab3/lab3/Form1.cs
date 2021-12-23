using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static string ByteArrayToString(byte[] arr)
        {
            StringBuilder hex = new StringBuilder(arr.Length * 8);
            foreach (byte b in arr)
                hex.Append(Convert.ToString(b, 2));
            return hex.ToString();
        }
        void myShowToolTip(TextBox tB, byte[] arr)
        {

            toolTip_HEX.SetToolTip(tB, ByteArrayToString(arr));
        }

        byte[] myXOR(byte[] arr_text, byte[] arr_key)
        {
            int len_text = arr_text.Length;
            int len_key = arr_key.Length;
            if (len_key == 0) return arr_text;
            byte[] arr_cipher = new byte[len_text];
            for (int i = 0; i < len_text; i++)
            {
                byte p = arr_text[i];
                byte k = arr_key[i % len_key]; // mod
                byte c = (byte)(p ^ k); // XOR

                arr_cipher[i] = c;
            }
            return arr_cipher;
        }

        string myCipher(TextBox tb_text, TextBox tb_Key, TextBox tb_cipher, string cipher = "")
        {
            byte[] arr_text = Encoding.Unicode.GetBytes(tb_text.Text);
            byte[] arr_key = Encoding.Unicode.GetBytes(tb_Key.Text);


            byte[] arr_cipher = myXOR(arr_text, arr_key);
            tb_cipher.Text = Encoding.Unicode.GetString(arr_cipher);
            myShowToolTip(tb_text, arr_text);
            myShowToolTip(tb_Key, arr_key);
            myShowToolTip(tb_cipher, arr_cipher);
            return cipher;
        }

        private void button_XOR_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_Key_IN.Text))
            {
                MessageBox.Show("Ви забули ввести ключ?");
                textBox_Key_IN.Focus();
            }


            string cipher = myCipher(textBox_P_IN, textBox_Key_IN, textBox_C_IN); // зашифрування
            textBox_P_OUT.Text = textBox_C_IN.Text;
            textBox_Key_OUT.Text = textBox_Key_IN.Text;
            myCipher(textBox_P_OUT, textBox_Key_OUT, textBox_C_OUT, cipher); // розшифрування

        }

        private void button_clean_Click(object sender, EventArgs e)
        {
            textBox_P_IN.Text = "";
            textBox_Key_IN.Text = "";
            textBox_C_IN.Text = "";

            textBox_P_OUT.Text = "";
            textBox_Key_OUT.Text = "";
            textBox_C_OUT.Text = "";

        }
    }
}
