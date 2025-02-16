namespace WinFormsRomRom
{
    partial class FormAdmin
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
            buttonAddUser = new Button();
            button2 = new Button();
            listBox1 = new ListBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // buttonAddUser
            // 
            buttonAddUser.Location = new Point(12, 269);
            buttonAddUser.Name = "buttonAddUser";
            buttonAddUser.Size = new Size(132, 23);
            buttonAddUser.TabIndex = 0;
            buttonAddUser.Text = "Добавить";
            buttonAddUser.UseVisualStyleBackColor = true;
            buttonAddUser.Click += buttonAddUser_Click;
            // 
            // button2
            // 
            button2.Location = new Point(277, 269);
            button2.Name = "button2";
            button2.Size = new Size(132, 23);
            button2.TabIndex = 1;
            button2.Text = "Удалить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += buttonDeleteUser_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 27);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(397, 229);
            listBox1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(133, 15);
            label1.TabIndex = 3;
            label1.Text = "Список пользователей";
            // 
            // FormAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(429, 368);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Controls.Add(button2);
            Controls.Add(buttonAddUser);
            Name = "FormAdmin";
            Text = "AdminForm";
            FormClosing += FormAdmin_FormClosing;
            FormClosed += FormAdmin_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonAddUser;
        private Button button2;
        private ListBox listBox1;
        private Label label1;
    }
}