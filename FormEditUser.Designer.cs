namespace WinFormsRomRom
{
    partial class FormEditUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxPass = new TextBox();
            textBoxLogin = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            buttonCreat = new Button();
            comboBox1 = new ComboBox();
            textBoxEmail = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // textBoxPass
            // 
            textBoxPass.Location = new Point(78, 75);
            textBoxPass.Name = "textBoxPass";
            textBoxPass.PasswordChar = '*';
            textBoxPass.Size = new Size(190, 23);
            textBoxPass.TabIndex = 8;
            // 
            // textBoxLogin
            // 
            textBoxLogin.Location = new Point(78, 35);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(190, 23);
            textBoxLogin.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 78);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 6;
            label3.Text = "Пароль";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 38);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 5;
            label2.Text = "Логин";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 160);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 9;
            label1.Text = "Статус";
            // 
            // buttonCreat
            // 
            buttonCreat.Location = new Point(90, 203);
            buttonCreat.Name = "buttonCreat";
            buttonCreat.Size = new Size(159, 23);
            buttonCreat.TabIndex = 11;
            buttonCreat.Text = "Создать";
            buttonCreat.UseVisualStyleBackColor = true;
            buttonCreat.Click += buttonCreat_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(78, 157);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(190, 23);
            comboBox1.TabIndex = 12;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(78, 114);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.PasswordChar = '*';
            textBoxEmail.Size = new Size(190, 23);
            textBoxEmail.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 117);
            label4.Name = "label4";
            label4.Size = new Size(41, 15);
            label4.TabIndex = 13;
            label4.Text = "Почта";
            // 
            // FormEditUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(318, 235);
            Controls.Add(textBoxEmail);
            Controls.Add(label4);
            Controls.Add(comboBox1);
            Controls.Add(buttonCreat);
            Controls.Add(label1);
            Controls.Add(textBoxPass);
            Controls.Add(textBoxLogin);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "FormEditUser";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Edit User";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxPass;
        private TextBox textBoxLogin;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button buttonCreat;
        private ComboBox comboBox1;
        private TextBox textBoxEmail;
        private Label label4;
    }
}