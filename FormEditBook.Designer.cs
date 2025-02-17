namespace WinFormsRomRom
{
    partial class FormEditBook
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
            textBoxDescription = new TextBox();
            label4 = new Label();
            buttonCreat = new Button();
            textBoxAuthor = new TextBox();
            textBoxTitle = new TextBox();
            label3 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location = new Point(77, 96);
            textBoxDescription.Multiline = true;
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(190, 123);
            textBoxDescription.TabIndex = 23;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(9, 99);
            label4.Name = "label4";
            label4.Size = new Size(62, 15);
            label4.TabIndex = 22;
            label4.Text = "Описание";
            // 
            // buttonCreat
            // 
            buttonCreat.Location = new Point(77, 225);
            buttonCreat.Name = "buttonCreat";
            buttonCreat.Size = new Size(159, 23);
            buttonCreat.TabIndex = 20;
            buttonCreat.Text = "Создать";
            buttonCreat.UseVisualStyleBackColor = true;
            buttonCreat.Click += buttonCreat_Click;
            // 
            // textBoxAuthor
            // 
            textBoxAuthor.Location = new Point(77, 57);
            textBoxAuthor.Name = "textBoxAuthor";
            textBoxAuthor.Size = new Size(190, 23);
            textBoxAuthor.TabIndex = 18;
            // 
            // textBoxTitle
            // 
            textBoxTitle.Location = new Point(77, 17);
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.Size = new Size(190, 23);
            textBoxTitle.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 60);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 16;
            label3.Text = "Автор";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 20);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 15;
            label2.Text = "Название";
            // 
            // FormEditBook
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(294, 273);
            Controls.Add(textBoxDescription);
            Controls.Add(label4);
            Controls.Add(buttonCreat);
            Controls.Add(textBoxAuthor);
            Controls.Add(textBoxTitle);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "FormEditBook";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Создать книгу";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxDescription;
        private Label label4;
        private Button buttonCreat;
        private TextBox textBoxAuthor;
        private TextBox textBoxTitle;
        private Label label3;
        private Label label2;
    }
}