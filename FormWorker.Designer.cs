namespace WinFormsRomRom
{
    partial class FormWorker
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
            listBox1 = new ListBox();
            richTextBox1 = new RichTextBox();
            menuStrip1 = new MenuStrip();
            qewqweToolStripMenuItem = new ToolStripMenuItem();
            FontToolStripMenuItem1 = new ToolStripMenuItem();
            SizeToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItemPlus = new ToolStripMenuItem();
            toolStripTextBoxCurrSize = new ToolStripTextBox();
            toolStripMenuItemMinus = new ToolStripMenuItem();
            StyleToolStripMenuItem = new ToolStripMenuItem();
            BoldToolStripMenuItem = new ToolStripMenuItem();
            ItalicToolStripMenuItem = new ToolStripMenuItem();
            RegularToolStripMenuItem = new ToolStripMenuItem();
            StrikeoutToolStripMenuItem = new ToolStripMenuItem();
            UnderlineToolStripMenuItem = new ToolStripMenuItem();
            qewweToolStripMenuItem = new ToolStripMenuItem();
            текстToolStripMenuItem = new ToolStripMenuItem();
            фонToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 27);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(231, 409);
            listBox1.TabIndex = 1;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(249, 27);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ScrollBars = RichTextBoxScrollBars.Horizontal;
            richTextBox1.Size = new Size(539, 411);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { qewqweToolStripMenuItem, qewweToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.RightToLeft = RightToLeft.No;
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // qewqweToolStripMenuItem
            // 
            qewqweToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { FontToolStripMenuItem1, SizeToolStripMenuItem, StyleToolStripMenuItem });
            qewqweToolStripMenuItem.Name = "qewqweToolStripMenuItem";
            qewqweToolStripMenuItem.Size = new Size(48, 20);
            qewqweToolStripMenuItem.Text = "Текст";
            // 
            // FontToolStripMenuItem1
            // 
            FontToolStripMenuItem1.Name = "FontToolStripMenuItem1";
            FontToolStripMenuItem1.Size = new Size(180, 22);
            FontToolStripMenuItem1.Text = "Шрифт";
            // 
            // SizeToolStripMenuItem
            // 
            SizeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItemPlus, toolStripTextBoxCurrSize, toolStripMenuItemMinus });
            SizeToolStripMenuItem.Name = "SizeToolStripMenuItem";
            SizeToolStripMenuItem.Size = new Size(180, 22);
            SizeToolStripMenuItem.Text = "Размер";
            SizeToolStripMenuItem.MouseEnter += SizeToolStripMenuItem_Click;
            // 
            // toolStripMenuItemPlus
            // 
            toolStripMenuItemPlus.Name = "toolStripMenuItemPlus";
            toolStripMenuItemPlus.Size = new Size(160, 22);
            toolStripMenuItemPlus.Text = "+";
            toolStripMenuItemPlus.Click += toolStripMenuItemPlus_Click;
            // 
            // toolStripTextBoxCurrSize
            // 
            toolStripTextBoxCurrSize.Name = "toolStripTextBoxCurrSize";
            toolStripTextBoxCurrSize.Size = new Size(100, 23);
            // 
            // toolStripMenuItemMinus
            // 
            toolStripMenuItemMinus.Name = "toolStripMenuItemMinus";
            toolStripMenuItemMinus.Size = new Size(160, 22);
            toolStripMenuItemMinus.Text = "-";
            toolStripMenuItemMinus.Click += toolStripMenuItemMinus_Click;
            // 
            // StyleToolStripMenuItem
            // 
            StyleToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { BoldToolStripMenuItem, ItalicToolStripMenuItem, RegularToolStripMenuItem, StrikeoutToolStripMenuItem, UnderlineToolStripMenuItem });
            StyleToolStripMenuItem.Name = "StyleToolStripMenuItem";
            StyleToolStripMenuItem.Size = new Size(180, 22);
            StyleToolStripMenuItem.Text = "Стиль";
            // 
            // BoldToolStripMenuItem
            // 
            BoldToolStripMenuItem.Name = "BoldToolStripMenuItem";
            BoldToolStripMenuItem.Size = new Size(180, 22);
            BoldToolStripMenuItem.Text = "Толстый";
            BoldToolStripMenuItem.Click += StyleToolStripMenuItem_Click;
            // 
            // ItalicToolStripMenuItem
            // 
            ItalicToolStripMenuItem.Name = "ItalicToolStripMenuItem";
            ItalicToolStripMenuItem.Size = new Size(180, 22);
            ItalicToolStripMenuItem.Text = "Курсив";
            ItalicToolStripMenuItem.Click += StyleToolStripMenuItem_Click;
            // 
            // RegularToolStripMenuItem
            // 
            RegularToolStripMenuItem.Name = "RegularToolStripMenuItem";
            RegularToolStripMenuItem.Size = new Size(180, 22);
            RegularToolStripMenuItem.Text = "Стандартный";
            RegularToolStripMenuItem.Click += StyleToolStripMenuItem_Click;
            // 
            // StrikeoutToolStripMenuItem
            // 
            StrikeoutToolStripMenuItem.Name = "StrikeoutToolStripMenuItem";
            StrikeoutToolStripMenuItem.Size = new Size(180, 22);
            StrikeoutToolStripMenuItem.Text = "Зачеркнутый";
            StrikeoutToolStripMenuItem.Click += StyleToolStripMenuItem_Click;
            // 
            // UnderlineToolStripMenuItem
            // 
            UnderlineToolStripMenuItem.Name = "UnderlineToolStripMenuItem";
            UnderlineToolStripMenuItem.Size = new Size(180, 22);
            UnderlineToolStripMenuItem.Text = "Подчеркнутый";
            UnderlineToolStripMenuItem.Click += StyleToolStripMenuItem_Click;
            // 
            // qewweToolStripMenuItem
            // 
            qewweToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { текстToolStripMenuItem, фонToolStripMenuItem });
            qewweToolStripMenuItem.Name = "qewweToolStripMenuItem";
            qewweToolStripMenuItem.Size = new Size(45, 20);
            qewweToolStripMenuItem.Text = "Цвет";
            // 
            // текстToolStripMenuItem
            // 
            текстToolStripMenuItem.Name = "текстToolStripMenuItem";
            текстToolStripMenuItem.Size = new Size(103, 22);
            текстToolStripMenuItem.Text = "Текст";
            // 
            // фонToolStripMenuItem
            // 
            фонToolStripMenuItem.Name = "фонToolStripMenuItem";
            фонToolStripMenuItem.Size = new Size(103, 22);
            фонToolStripMenuItem.Text = "Фон";
            // 
            // FormWorker
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(richTextBox1);
            Controls.Add(listBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FormWorker";
            Text = "WorkerForm";
            FormClosed += FormWorker_FormClosed;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListBox listBox1;
        private RichTextBox richTextBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem qewqweToolStripMenuItem;
        private ToolStripMenuItem FontToolStripMenuItem1;
        private ToolStripMenuItem qewweToolStripMenuItem;
        private ToolStripMenuItem SizeToolStripMenuItem;
        private ToolStripMenuItem текстToolStripMenuItem;
        private ToolStripMenuItem фонToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItemPlus;
        private ToolStripTextBox toolStripTextBoxCurrSize;
        private ToolStripMenuItem toolStripMenuItemMinus;
        private ToolStripMenuItem StyleToolStripMenuItem;
        private ToolStripMenuItem BoldToolStripMenuItem;
        private ToolStripMenuItem ItalicToolStripMenuItem;
        private ToolStripMenuItem RegularToolStripMenuItem;
        private ToolStripMenuItem StrikeoutToolStripMenuItem;
        private ToolStripMenuItem UnderlineToolStripMenuItem;
    }
}