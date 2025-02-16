using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsRomRom
{
    public partial class FormWorker : Form
    {
        public FormWorker()
        {
            InitializeComponent();
            BoldToolStripMenuItem.Tag = FontStyle.Bold;
            ItalicToolStripMenuItem.Tag = FontStyle.Italic;
            RegularToolStripMenuItem.Tag = FontStyle.Regular;
            StrikeoutToolStripMenuItem.Tag = FontStyle.Strikeout;
            UnderlineToolStripMenuItem.Tag = FontStyle.Underline;new int();
        }

        private void FormWorker_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.Close();
        }

        private void SizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionLength > 0)
            {
                toolStripTextBoxCurrSize.Text = richTextBox1.SelectionFont.Size.ToString();
            }
            else
            {
                toolStripTextBoxCurrSize.Text = "";
            }
        }

        private void toolStripMenuItemPlus_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionLength > 0)
            {
                var currentFont = richTextBox1.SelectionFont ?? DefaultFont;
                richTextBox1.SelectionFont = new(currentFont.FontFamily, currentFont.Size + 1, currentFont.Style);
            }
        }

        private void toolStripMenuItemMinus_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionLength > 0)
            {
                var currentFont = richTextBox1.SelectionFont ?? DefaultFont;
                if (currentFont.Size - 1 > 0)
                    richTextBox1.SelectionFont = new(currentFont.FontFamily, currentFont.Size - 1, currentFont.Style);
                else { }
            }
        }

        private void StyleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sender is ToolStripMenuItem menuItem && menuItem.Tag is FontStyle style)
            {

                var currentFont = richTextBox1.SelectionFont ?? DefaultFont;

                Font newFont = new Font(
                    currentFont.FontFamily,
                    currentFont.Size,
                    (currentFont.Style ^ style)
                    );

                richTextBox1.SelectionFont = newFont;
            }
        }
    }
}
