namespace WinFormsRomRom
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBoxLogin = new TextBox();
            textBoxPass = new TextBox();
            buttonEnter = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(124, 9);
            label1.Name = "label1";
            label1.Size = new Size(49, 21);
            label1.TabIndex = 0;
            label1.Text = "Вход";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 99);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 1;
            label2.Text = "Логин";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 139);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 2;
            label3.Text = "Пароль";
            // 
            // textBoxLogin
            // 
            textBoxLogin.Location = new Point(67, 96);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(190, 23);
            textBoxLogin.TabIndex = 3;
            // 
            // textBoxPass
            // 
            textBoxPass.Location = new Point(67, 136);
            textBoxPass.Name = "textBoxPass";
            textBoxPass.PasswordChar = '*';
            textBoxPass.Size = new Size(190, 23);
            textBoxPass.TabIndex = 4;
            // 
            // buttonEnter
            // 
            buttonEnter.Location = new Point(111, 185);
            buttonEnter.Name = "buttonEnter";
            buttonEnter.Size = new Size(75, 23);
            buttonEnter.TabIndex = 5;
            buttonEnter.Text = "Войти";
            buttonEnter.UseVisualStyleBackColor = true;
            buttonEnter.Click += buttonEnter_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(309, 255);
            Controls.Add(buttonEnter);
            Controls.Add(textBoxPass);
            Controls.Add(textBoxLogin);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "My Library";
            Shown += Form1_Shown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxLogin;
        private TextBox textBoxPass;
        private Button buttonEnter;
    }

}