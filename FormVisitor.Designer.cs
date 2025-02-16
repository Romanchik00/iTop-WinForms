namespace WinFormsRomRom
{
    partial class FormVisitor
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
            richTextBox1 = new RichTextBox();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(249, 12);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ScrollBars = RichTextBoxScrollBars.Horizontal;
            richTextBox1.Size = new Size(539, 426);
            richTextBox1.TabIndex = 4;
            richTextBox1.Text = "";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(231, 424);
            listBox1.TabIndex = 3;
            // 
            // FormVisitor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 567);
            Controls.Add(richTextBox1);
            Controls.Add(listBox1);
            Name = "FormVisitor";
            Text = "My Library ~ ~ ~";
            FormClosed += FormVisitor_FormClosed;
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox richTextBox1;
        private ListBox listBox1;
    }
}