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
            TextToolStripMenuItem = new ToolStripMenuItem();
            FontToolStripMenuItem1 = new ToolStripMenuItem();
            timeNewRomanToolStripMenuItem = new ToolStripMenuItem();
            sansToolStripMenuItem = new ToolStripMenuItem();
            oldEnglishTextMTToolStripMenuItem = new ToolStripMenuItem();
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
            ColorToolStripMenuItem = new ToolStripMenuItem();
            ColTxtToolStripMenuItem = new ToolStripMenuItem();
            BlackToolStripMenuItem = new ToolStripMenuItem();
            RedToolStripMenuItem = new ToolStripMenuItem();
            WhiteToolStripMenuItem = new ToolStripMenuItem();
            GreenToolStripMenuItem = new ToolStripMenuItem();
            YellowToolStripMenuItem = new ToolStripMenuItem();
            BlueToolStripMenuItem = new ToolStripMenuItem();
            BackgroundToolStripMenuItem = new ToolStripMenuItem();
            blackToolStripMenuItem1 = new ToolStripMenuItem();
            redToolStripMenuItem1 = new ToolStripMenuItem();
            whiteToolStripMenuItem1 = new ToolStripMenuItem();
            greenToolStripMenuItem1 = new ToolStripMenuItem();
            yellowToolStripMenuItem1 = new ToolStripMenuItem();
            blueToolStripMenuItem1 = new ToolStripMenuItem();
            button1 = new Button();
            button2 = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 27);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(231, 334);
            listBox1.TabIndex = 1;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
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
            menuStrip1.Items.AddRange(new ToolStripItem[] { TextToolStripMenuItem, ColorToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.RightToLeft = RightToLeft.No;
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // TextToolStripMenuItem
            // 
            TextToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { FontToolStripMenuItem1, SizeToolStripMenuItem, StyleToolStripMenuItem });
            TextToolStripMenuItem.Name = "TextToolStripMenuItem";
            TextToolStripMenuItem.Size = new Size(48, 20);
            TextToolStripMenuItem.Text = "Текст";
            // 
            // FontToolStripMenuItem1
            // 
            FontToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { timeNewRomanToolStripMenuItem, sansToolStripMenuItem, oldEnglishTextMTToolStripMenuItem });
            FontToolStripMenuItem1.Name = "FontToolStripMenuItem1";
            FontToolStripMenuItem1.Size = new Size(180, 22);
            FontToolStripMenuItem1.Text = "Шрифт";
            // 
            // timeNewRomanToolStripMenuItem
            // 
            timeNewRomanToolStripMenuItem.Name = "timeNewRomanToolStripMenuItem";
            timeNewRomanToolStripMenuItem.Size = new Size(180, 22);
            timeNewRomanToolStripMenuItem.Text = "Time New Roman";
            timeNewRomanToolStripMenuItem.Click += FontToolStripMenuItem_Click;
            // 
            // sansToolStripMenuItem
            // 
            sansToolStripMenuItem.Name = "sansToolStripMenuItem";
            sansToolStripMenuItem.Size = new Size(180, 22);
            sansToolStripMenuItem.Text = "Sans";
            sansToolStripMenuItem.Click += FontToolStripMenuItem_Click;
            // 
            // oldEnglishTextMTToolStripMenuItem
            // 
            oldEnglishTextMTToolStripMenuItem.Name = "oldEnglishTextMTToolStripMenuItem";
            oldEnglishTextMTToolStripMenuItem.Size = new Size(180, 22);
            oldEnglishTextMTToolStripMenuItem.Text = "Old English Text MT";
            oldEnglishTextMTToolStripMenuItem.Click += FontToolStripMenuItem_Click;
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
            BoldToolStripMenuItem.Size = new Size(156, 22);
            BoldToolStripMenuItem.Text = "Толстый";
            BoldToolStripMenuItem.Click += StyleToolStripMenuItem_Click;
            // 
            // ItalicToolStripMenuItem
            // 
            ItalicToolStripMenuItem.Name = "ItalicToolStripMenuItem";
            ItalicToolStripMenuItem.Size = new Size(156, 22);
            ItalicToolStripMenuItem.Text = "Курсив";
            ItalicToolStripMenuItem.Click += StyleToolStripMenuItem_Click;
            // 
            // RegularToolStripMenuItem
            // 
            RegularToolStripMenuItem.Name = "RegularToolStripMenuItem";
            RegularToolStripMenuItem.Size = new Size(156, 22);
            RegularToolStripMenuItem.Text = "Стандартный";
            RegularToolStripMenuItem.Click += StyleToolStripMenuItem_Click;
            // 
            // StrikeoutToolStripMenuItem
            // 
            StrikeoutToolStripMenuItem.Name = "StrikeoutToolStripMenuItem";
            StrikeoutToolStripMenuItem.Size = new Size(156, 22);
            StrikeoutToolStripMenuItem.Text = "Зачеркнутый";
            StrikeoutToolStripMenuItem.Click += StyleToolStripMenuItem_Click;
            // 
            // UnderlineToolStripMenuItem
            // 
            UnderlineToolStripMenuItem.Name = "UnderlineToolStripMenuItem";
            UnderlineToolStripMenuItem.Size = new Size(156, 22);
            UnderlineToolStripMenuItem.Text = "Подчеркнутый";
            UnderlineToolStripMenuItem.Click += StyleToolStripMenuItem_Click;
            // 
            // ColorToolStripMenuItem
            // 
            ColorToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ColTxtToolStripMenuItem, BackgroundToolStripMenuItem });
            ColorToolStripMenuItem.Name = "ColorToolStripMenuItem";
            ColorToolStripMenuItem.Size = new Size(45, 20);
            ColorToolStripMenuItem.Text = "Цвет";
            // 
            // ColTxtToolStripMenuItem
            // 
            ColTxtToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { BlackToolStripMenuItem, RedToolStripMenuItem, WhiteToolStripMenuItem, GreenToolStripMenuItem, YellowToolStripMenuItem, BlueToolStripMenuItem });
            ColTxtToolStripMenuItem.Name = "ColTxtToolStripMenuItem";
            ColTxtToolStripMenuItem.Size = new Size(103, 22);
            ColTxtToolStripMenuItem.Text = "Текст";
            // 
            // BlackToolStripMenuItem
            // 
            BlackToolStripMenuItem.Name = "BlackToolStripMenuItem";
            BlackToolStripMenuItem.Size = new Size(123, 22);
            BlackToolStripMenuItem.Text = "Черный";
            BlackToolStripMenuItem.Click += TextColorToolStripMenuItem_Click;
            // 
            // RedToolStripMenuItem
            // 
            RedToolStripMenuItem.Name = "RedToolStripMenuItem";
            RedToolStripMenuItem.Size = new Size(123, 22);
            RedToolStripMenuItem.Text = "Красный";
            RedToolStripMenuItem.Click += TextColorToolStripMenuItem_Click;
            // 
            // WhiteToolStripMenuItem
            // 
            WhiteToolStripMenuItem.Name = "WhiteToolStripMenuItem";
            WhiteToolStripMenuItem.Size = new Size(123, 22);
            WhiteToolStripMenuItem.Text = "Белый";
            WhiteToolStripMenuItem.Click += TextColorToolStripMenuItem_Click;
            // 
            // GreenToolStripMenuItem
            // 
            GreenToolStripMenuItem.Name = "GreenToolStripMenuItem";
            GreenToolStripMenuItem.Size = new Size(123, 22);
            GreenToolStripMenuItem.Text = "Зеленый";
            GreenToolStripMenuItem.Click += TextColorToolStripMenuItem_Click;
            // 
            // YellowToolStripMenuItem
            // 
            YellowToolStripMenuItem.Name = "YellowToolStripMenuItem";
            YellowToolStripMenuItem.Size = new Size(123, 22);
            YellowToolStripMenuItem.Text = "Желтый";
            YellowToolStripMenuItem.Click += TextColorToolStripMenuItem_Click;
            // 
            // BlueToolStripMenuItem
            // 
            BlueToolStripMenuItem.Name = "BlueToolStripMenuItem";
            BlueToolStripMenuItem.Size = new Size(123, 22);
            BlueToolStripMenuItem.Text = "Синий";
            BlueToolStripMenuItem.Click += TextColorToolStripMenuItem_Click;
            // 
            // BackgroundToolStripMenuItem
            // 
            BackgroundToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { blackToolStripMenuItem1, redToolStripMenuItem1, whiteToolStripMenuItem1, greenToolStripMenuItem1, yellowToolStripMenuItem1, blueToolStripMenuItem1 });
            BackgroundToolStripMenuItem.Name = "BackgroundToolStripMenuItem";
            BackgroundToolStripMenuItem.Size = new Size(103, 22);
            BackgroundToolStripMenuItem.Text = "Фон";
            // 
            // blackToolStripMenuItem1
            // 
            blackToolStripMenuItem1.Name = "blackToolStripMenuItem1";
            blackToolStripMenuItem1.Size = new Size(123, 22);
            blackToolStripMenuItem1.Text = "Черный";
            blackToolStripMenuItem1.Click += BackgroundColorToolStripMenuItem1_Click;
            // 
            // redToolStripMenuItem1
            // 
            redToolStripMenuItem1.Name = "redToolStripMenuItem1";
            redToolStripMenuItem1.Size = new Size(123, 22);
            redToolStripMenuItem1.Text = "Красный";
            redToolStripMenuItem1.Click += BackgroundColorToolStripMenuItem1_Click;
            // 
            // whiteToolStripMenuItem1
            // 
            whiteToolStripMenuItem1.Name = "whiteToolStripMenuItem1";
            whiteToolStripMenuItem1.Size = new Size(123, 22);
            whiteToolStripMenuItem1.Text = "Белый";
            whiteToolStripMenuItem1.Click += BackgroundColorToolStripMenuItem1_Click;
            // 
            // greenToolStripMenuItem1
            // 
            greenToolStripMenuItem1.Name = "greenToolStripMenuItem1";
            greenToolStripMenuItem1.Size = new Size(123, 22);
            greenToolStripMenuItem1.Text = "Зеленый";
            greenToolStripMenuItem1.Click += BackgroundColorToolStripMenuItem1_Click;
            // 
            // yellowToolStripMenuItem1
            // 
            yellowToolStripMenuItem1.Name = "yellowToolStripMenuItem1";
            yellowToolStripMenuItem1.Size = new Size(123, 22);
            yellowToolStripMenuItem1.Text = "Желтый";
            yellowToolStripMenuItem1.Click += BackgroundColorToolStripMenuItem1_Click;
            // 
            // blueToolStripMenuItem1
            // 
            blueToolStripMenuItem1.Name = "blueToolStripMenuItem1";
            blueToolStripMenuItem1.Size = new Size(123, 22);
            blueToolStripMenuItem1.Text = "Синий";
            blueToolStripMenuItem1.Click += BackgroundColorToolStripMenuItem1_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.GreenYellow;
            button1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(155, 367);
            button1.Name = "button1";
            button1.Size = new Size(88, 71);
            button1.TabIndex = 4;
            button1.Text = "Сохранить изменения текста";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.NavajoWhite;
            button2.Location = new Point(74, 367);
            button2.Name = "button2";
            button2.Size = new Size(75, 45);
            button2.TabIndex = 5;
            button2.Text = "Создать книгу";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // FormWorker
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(richTextBox1);
            Controls.Add(listBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FormWorker";
            Text = "WorkerForm";
            FormClosing += FormWorker_FormClosing;
            FormClosed += FormWorker_FormClosed;
            Load += FormWorker_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListBox listBox1;
        private RichTextBox richTextBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem TextToolStripMenuItem;
        private ToolStripMenuItem FontToolStripMenuItem1;
        private ToolStripMenuItem ColorToolStripMenuItem;
        private ToolStripMenuItem SizeToolStripMenuItem;
        private ToolStripMenuItem ColTxtToolStripMenuItem;
        private ToolStripMenuItem BackgroundToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItemPlus;
        private ToolStripTextBox toolStripTextBoxCurrSize;
        private ToolStripMenuItem toolStripMenuItemMinus;
        private ToolStripMenuItem StyleToolStripMenuItem;
        private ToolStripMenuItem BoldToolStripMenuItem;
        private ToolStripMenuItem ItalicToolStripMenuItem;
        private ToolStripMenuItem RegularToolStripMenuItem;
        private ToolStripMenuItem StrikeoutToolStripMenuItem;
        private ToolStripMenuItem UnderlineToolStripMenuItem;
        private ToolStripMenuItem BlackToolStripMenuItem;
        private ToolStripMenuItem RedToolStripMenuItem;
        private ToolStripMenuItem WhiteToolStripMenuItem;
        private ToolStripMenuItem GreenToolStripMenuItem;
        private ToolStripMenuItem YellowToolStripMenuItem;
        private ToolStripMenuItem BlueToolStripMenuItem;
        private ToolStripMenuItem blackToolStripMenuItem1;
        private ToolStripMenuItem redToolStripMenuItem1;
        private ToolStripMenuItem whiteToolStripMenuItem1;
        private ToolStripMenuItem greenToolStripMenuItem1;
        private ToolStripMenuItem yellowToolStripMenuItem1;
        private ToolStripMenuItem blueToolStripMenuItem1;
        private Button button1;
        private Button button2;
        private ToolStripMenuItem timeNewRomanToolStripMenuItem;
        private ToolStripMenuItem sansToolStripMenuItem;
        private ToolStripMenuItem oldEnglishTextMTToolStripMenuItem;
    }
}