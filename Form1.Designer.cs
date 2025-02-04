using static WinFormsHomeWork.Form1;

namespace WinFormsHomeWork
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
            components = new System.ComponentModel.Container();
            groupBox1 = new GroupBox();
            label3 = new Label();
            button2 = new Button();
            label2 = new Label();
            label1 = new Label();
            checkedListBox1 = new CheckedListBox();
            button1 = new Button();
            numericUpDown1 = new NumericUpDown();
            comboBox1 = new ComboBox();
            imageList1 = new ImageList(components);
            button3 = new Button();
            button4 = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(checkedListBox1);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(numericUpDown1);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Location = new Point(23, 24);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(716, 427);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Касса";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(654, 346);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 7;
            label3.Text = "руб.";
            // 
            // button2
            // 
            button2.Location = new Point(276, 368);
            button2.Name = "button2";
            button2.Size = new Size(201, 40);
            button2.TabIndex = 6;
            button2.Text = "Выдать чек";
            button2.UseVisualStyleBackColor = true;
            button2.Click += GetCheck_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(477, 341);
            label2.Name = "label2";
            label2.Size = new Size(171, 23);
            label2.TabIndex = 5;
            label2.Text = "0,0";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(645, 43);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 4;
            label1.Text = "кг";
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(36, 137);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(656, 184);
            checkedListBox1.TabIndex = 3;
            checkedListBox1.Click += TotalSum;
            checkedListBox1.SelectedIndexChanged += TotalSum;
            // 
            // button1
            // 
            button1.Location = new Point(276, 81);
            button1.Name = "button1";
            button1.Size = new Size(195, 37);
            button1.TabIndex = 2;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Add_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(519, 41);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 1;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(27, 40);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(475, 23);
            comboBox1.TabIndex = 0;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // button3
            // 
            button3.Location = new Point(23, 457);
            button3.Name = "button3";
            button3.Size = new Size(213, 35);
            button3.TabIndex = 1;
            button3.Text = "Склад";
            button3.UseVisualStyleBackColor = true;
            button3.Click += Store_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(255, 128, 128);
            button4.Location = new Point(554, 457);
            button4.Name = "button4";
            button4.Size = new Size(185, 35);
            button4.TabIndex = 2;
            button4.Text = "Закончить смену";
            button4.UseVisualStyleBackColor = false;
            button4.Click += Finish_Shift_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(775, 516);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(groupBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label3;
        private Button button2;
        private Label label2;
        private Label label1;
        private CheckedListBox checkedListBox1;
        private Button button1;
        private NumericUpDown numericUpDown1;
        private ComboBox comboBox1;
        private ImageList imageList1;
        private Button button3;
        private Button button4;
    }
}