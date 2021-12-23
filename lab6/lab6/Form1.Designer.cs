
namespace Lab6
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button_fileKey_out = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_fileKey_out = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.checkBox_hand = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_Key = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.checkBox_viewPassWord = new System.Windows.Forms.CheckBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label_fileSave = new System.Windows.Forms.Label();
            this.label_fileCipher = new System.Windows.Forms.Label();
            this.label_fileOpen = new System.Windows.Forms.Label();
            this.label_3 = new System.Windows.Forms.Label();
            this.label_2 = new System.Windows.Forms.Label();
            this.label_1 = new System.Windows.Forms.Label();
            this.buttonа_fileSave = new System.Windows.Forms.Button();
            this.button_fileCipher = new System.Windows.Forms.Button();
            this.button_fileOpen = new System.Windows.Forms.Button();
            this.imageList_XOR = new System.Windows.Forms.ImageList(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_bits = new System.Windows.Forms.Label();
            this.comboBox_keyLength_byte = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButton_passWord = new System.Windows.Forms.RadioButton();
            this.radioButton_keyGen = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.imageList_KeyGen = new System.Windows.Forms.ImageList(this.components);
            this.label_time = new System.Windows.Forms.Label();
            this.button_OK = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(538, 90);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.button_fileKey_out);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.textBox_fileKey_out);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(530, 64);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Файл з ключем";
            // 
            // button_fileKey_out
            // 
            this.button_fileKey_out.Location = new System.Drawing.Point(481, 25);
            this.button_fileKey_out.Name = "button_fileKey_out";
            this.button_fileKey_out.Size = new System.Drawing.Size(43, 23);
            this.button_fileKey_out.TabIndex = 2;
            this.button_fileKey_out.Text = "...";
            this.button_fileKey_out.UseVisualStyleBackColor = true;
            this.button_fileKey_out.Click += new System.EventHandler(this.button_fileKey_out_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Шлях до файлу:";
            // 
            // textBox_fileKey_out
            // 
            this.textBox_fileKey_out.Location = new System.Drawing.Point(6, 27);
            this.textBox_fileKey_out.Name = "textBox_fileKey_out";
            this.textBox_fileKey_out.Size = new System.Drawing.Size(469, 20);
            this.textBox_fileKey_out.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.checkBox_hand);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.textBox_Key);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(530, 64);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ключ у HEX форматі";
            // 
            // checkBox_hand
            // 
            this.checkBox_hand.Image = ((System.Drawing.Image)(resources.GetObject("checkBox_hand.Image")));
            this.checkBox_hand.Location = new System.Drawing.Point(477, 18);
            this.checkBox_hand.Name = "checkBox_hand";
            this.checkBox_hand.Size = new System.Drawing.Size(50, 38);
            this.checkBox_hand.TabIndex = 5;
            this.checkBox_hand.UseVisualStyleBackColor = true;
            this.checkBox_hand.CheckedChanged += new System.EventHandler(this.checkBox_hand_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ключ (HEX) формат:";
            // 
            // textBox_Key
            // 
            this.textBox_Key.Location = new System.Drawing.Point(6, 27);
            this.textBox_Key.Name = "textBox_Key";
            this.textBox_Key.ReadOnly = true;
            this.textBox_Key.Size = new System.Drawing.Size(469, 20);
            this.textBox_Key.TabIndex = 3;
            this.textBox_Key.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Key_KeyPress);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage3.Controls.Add(this.checkBox_viewPassWord);
            this.tabPage3.Controls.Add(this.textBox_password);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(530, 64);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Власний пароль";
            // 
            // checkBox_viewPassWord
            // 
            this.checkBox_viewPassWord.Image = ((System.Drawing.Image)(resources.GetObject("checkBox_viewPassWord.Image")));
            this.checkBox_viewPassWord.Location = new System.Drawing.Point(466, 13);
            this.checkBox_viewPassWord.Name = "checkBox_viewPassWord";
            this.checkBox_viewPassWord.Size = new System.Drawing.Size(58, 38);
            this.checkBox_viewPassWord.TabIndex = 2;
            this.checkBox_viewPassWord.UseVisualStyleBackColor = true;
            this.checkBox_viewPassWord.CheckedChanged += new System.EventHandler(this.checkBox_viewPassWord_CheckedChanged);
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(143, 22);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.PasswordChar = '*';
            this.textBox_password.Size = new System.Drawing.Size(317, 20);
            this.textBox_password.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 26);
            this.label6.TabIndex = 0;
            this.label6.Text = "Придумайте свій пароль \r\nі запишіть його сюди:";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage4.Controls.Add(this.label_fileSave);
            this.tabPage4.Controls.Add(this.label_fileCipher);
            this.tabPage4.Controls.Add(this.label_fileOpen);
            this.tabPage4.Controls.Add(this.label_3);
            this.tabPage4.Controls.Add(this.label_2);
            this.tabPage4.Controls.Add(this.label_1);
            this.tabPage4.Controls.Add(this.buttonа_fileSave);
            this.tabPage4.Controls.Add(this.button_fileCipher);
            this.tabPage4.Controls.Add(this.button_fileOpen);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(530, 64);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Файл XOR ключ";
            // 
            // label_fileSave
            // 
            this.label_fileSave.AutoSize = true;
            this.label_fileSave.ForeColor = System.Drawing.Color.Red;
            this.label_fileSave.Location = new System.Drawing.Point(366, 39);
            this.label_fileSave.Name = "label_fileSave";
            this.label_fileSave.Size = new System.Drawing.Size(39, 13);
            this.label_fileSave.TabIndex = 8;
            this.label_fileSave.Text = "(нема)";
            // 
            // label_fileCipher
            // 
            this.label_fileCipher.AutoSize = true;
            this.label_fileCipher.ForeColor = System.Drawing.Color.Red;
            this.label_fileCipher.Location = new System.Drawing.Point(192, 38);
            this.label_fileCipher.Name = "label_fileCipher";
            this.label_fileCipher.Size = new System.Drawing.Size(39, 13);
            this.label_fileCipher.TabIndex = 7;
            this.label_fileCipher.Text = "(нема)";
            // 
            // label_fileOpen
            // 
            this.label_fileOpen.AutoSize = true;
            this.label_fileOpen.ForeColor = System.Drawing.Color.Red;
            this.label_fileOpen.Location = new System.Drawing.Point(27, 38);
            this.label_fileOpen.Name = "label_fileOpen";
            this.label_fileOpen.Size = new System.Drawing.Size(39, 13);
            this.label_fileOpen.TabIndex = 6;
            this.label_fileOpen.Text = "(нема)";
            // 
            // label_3
            // 
            this.label_3.AutoSize = true;
            this.label_3.Location = new System.Drawing.Point(344, 26);
            this.label_3.Name = "label_3";
            this.label_3.Size = new System.Drawing.Size(86, 13);
            this.label_3.TabIndex = 5;
            this.label_3.Text = "Зберегти файл:";
            // 
            // label_2
            // 
            this.label_2.AutoSize = true;
            this.label_2.Location = new System.Drawing.Point(177, 26);
            this.label_2.Name = "label_2";
            this.label_2.Size = new System.Drawing.Size(74, 13);
            this.label_2.TabIndex = 4;
            this.label_2.Text = "Шифрування:";
            // 
            // label_1
            // 
            this.label_1.AutoSize = true;
            this.label_1.Location = new System.Drawing.Point(6, 25);
            this.label_1.Name = "label_1";
            this.label_1.Size = new System.Drawing.Size(83, 13);
            this.label_1.TabIndex = 0;
            this.label_1.Text = "Відкрити файл:";
            // 
            // buttonа_fileSave
            // 
            this.buttonа_fileSave.Image = ((System.Drawing.Image)(resources.GetObject("buttonа_fileSave.Image")));
            this.buttonа_fileSave.Location = new System.Drawing.Point(455, 11);
            this.buttonа_fileSave.Name = "buttonа_fileSave";
            this.buttonа_fileSave.Size = new System.Drawing.Size(54, 40);
            this.buttonа_fileSave.TabIndex = 3;
            this.buttonа_fileSave.UseVisualStyleBackColor = true;
            this.buttonа_fileSave.Click += new System.EventHandler(this.buttonа_fileSave_Click);
            // 
            // button_fileCipher
            // 
            this.button_fileCipher.Image = ((System.Drawing.Image)(resources.GetObject("button_fileCipher.Image")));
            this.button_fileCipher.Location = new System.Drawing.Point(271, 11);
            this.button_fileCipher.Name = "button_fileCipher";
            this.button_fileCipher.Size = new System.Drawing.Size(54, 40);
            this.button_fileCipher.TabIndex = 2;
            this.button_fileCipher.UseVisualStyleBackColor = true;
            this.button_fileCipher.Click += new System.EventHandler(this.button_fileCipher_Click);
            // 
            // button_fileOpen
            // 
            this.button_fileOpen.Image = ((System.Drawing.Image)(resources.GetObject("button_fileOpen.Image")));
            this.button_fileOpen.Location = new System.Drawing.Point(95, 11);
            this.button_fileOpen.Name = "button_fileOpen";
            this.button_fileOpen.Size = new System.Drawing.Size(54, 40);
            this.button_fileOpen.TabIndex = 1;
            this.button_fileOpen.UseVisualStyleBackColor = true;
            this.button_fileOpen.Click += new System.EventHandler(this.button_fileOpen_Click);
            // 
            // imageList_XOR
            // 
            this.imageList_XOR.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList_XOR.ImageStream")));
            this.imageList_XOR.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList_XOR.Images.SetKeyName(0, "XOR.png");
            this.imageList_XOR.Images.SetKeyName(1, "XOR green.png");
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_bits);
            this.groupBox1.Controls.Add(this.comboBox_keyLength_byte);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.radioButton_passWord);
            this.groupBox1.Controls.Add(this.radioButton_keyGen);
            this.groupBox1.Location = new System.Drawing.Point(12, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(534, 102);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ключ";
            // 
            // label_bits
            // 
            this.label_bits.AutoSize = true;
            this.label_bits.Location = new System.Drawing.Point(142, 68);
            this.label_bits.Name = "label_bits";
            this.label_bits.Size = new System.Drawing.Size(35, 13);
            this.label_bits.TabIndex = 5;
            this.label_bits.Text = "label7";
            // 
            // comboBox_keyLength_byte
            // 
            this.comboBox_keyLength_byte.FormattingEnabled = true;
            this.comboBox_keyLength_byte.Items.AddRange(new object[] {
            "8",
            "16",
            "24",
            "32",
            "12500000"});
            this.comboBox_keyLength_byte.Location = new System.Drawing.Point(145, 19);
            this.comboBox_keyLength_byte.Name = "comboBox_keyLength_byte";
            this.comboBox_keyLength_byte.Size = new System.Drawing.Size(121, 21);
            this.comboBox_keyLength_byte.TabIndex = 4;
            this.comboBox_keyLength_byte.TextChanged += new System.EventHandler(this.comboBox_keyLength_byte_TextChanged);
            this.comboBox_keyLength_byte.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox_keyLength_byte_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Довжина ключа (біти):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Дожвина ключа (байти):";
            // 
            // radioButton_passWord
            // 
            this.radioButton_passWord.AutoSize = true;
            this.radioButton_passWord.Cursor = System.Windows.Forms.Cursors.Default;
            this.radioButton_passWord.Location = new System.Drawing.Point(299, 53);
            this.radioButton_passWord.Name = "radioButton_passWord";
            this.radioButton_passWord.Size = new System.Drawing.Size(229, 43);
            this.radioButton_passWord.TabIndex = 1;
            this.radioButton_passWord.Text = "\r\nКлюч генерується розширенням пароля\r\n\r\n";
            this.radioButton_passWord.UseVisualStyleBackColor = true;
            this.radioButton_passWord.CheckedChanged += new System.EventHandler(this.radioButton_passWord_CheckedChanged);
            // 
            // radioButton_keyGen
            // 
            this.radioButton_keyGen.AutoSize = true;
            this.radioButton_keyGen.Checked = true;
            this.radioButton_keyGen.Location = new System.Drawing.Point(299, 10);
            this.radioButton_keyGen.Name = "radioButton_keyGen";
            this.radioButton_keyGen.Size = new System.Drawing.Size(214, 43);
            this.radioButton_keyGen.TabIndex = 0;
            this.radioButton_keyGen.TabStop = true;
            this.radioButton_keyGen.Text = "\r\nКлюч з криптографічного генератора\r\n псевдовипадкових послідовностей";
            this.radioButton_keyGen.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.radioButton_keyGen.UseVisualStyleBackColor = true;
            this.radioButton_keyGen.CheckedChanged += new System.EventHandler(this.radioButton_keyGen_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(284, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Тривалість розрахунків ( мін.: сек. ):";
            // 
            // imageList_KeyGen
            // 
            this.imageList_KeyGen.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList_KeyGen.ImageStream")));
            this.imageList_KeyGen.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList_KeyGen.Images.SetKeyName(0, "Key yellow.png");
            this.imageList_KeyGen.Images.SetKeyName(1, "Key green.png");
            // 
            // label_time
            // 
            this.label_time.AutoSize = true;
            this.label_time.Location = new System.Drawing.Point(490, 217);
            this.label_time.Name = "label_time";
            this.label_time.Size = new System.Drawing.Size(49, 13);
            this.label_time.TabIndex = 4;
            this.label_time.Text = "00:00:00";
            // 
            // button_OK
            // 
            this.button_OK.Image = ((System.Drawing.Image)(resources.GetObject("button_OK.Image")));
            this.button_OK.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_OK.Location = new System.Drawing.Point(16, 212);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(149, 30);
            this.button_OK.TabIndex = 2;
            this.button_OK.Text = "Згенерувати ключ";
            this.button_OK.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 247);
            this.Controls.Add(this.label_time);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_OK);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button_fileKey_out;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_fileKey_out;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButton_passWord;
        private System.Windows.Forms.RadioButton radioButton_keyGen;
        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_keyLength_byte;
        private System.Windows.Forms.CheckBox checkBox_hand;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_Key;
        private System.Windows.Forms.CheckBox checkBox_viewPassWord;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ImageList imageList_KeyGen;
        private System.Windows.Forms.Label label_bits;
        private System.Windows.Forms.Label label_time;
        private System.Windows.Forms.Label label_3;
        private System.Windows.Forms.Label label_2;
        private System.Windows.Forms.Button buttonа_fileSave;
        private System.Windows.Forms.Button button_fileCipher;
        private System.Windows.Forms.Button button_fileOpen;
        private System.Windows.Forms.Label label_1;
        private System.Windows.Forms.ImageList imageList_XOR;
        private System.Windows.Forms.Label label_fileOpen;
        private System.Windows.Forms.Label label_fileSave;
        private System.Windows.Forms.Label label_fileCipher;
    }
}

