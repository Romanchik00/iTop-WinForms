using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

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
            UnderlineToolStripMenuItem.Tag = FontStyle.Underline;

            BlackToolStripMenuItem.Tag = blackToolStripMenuItem1.Tag = Color.Black;
            WhiteToolStripMenuItem.Tag = whiteToolStripMenuItem1.Tag = Color.White;
            RedToolStripMenuItem.Tag = redToolStripMenuItem1.Tag = Color.Red;
            BlueToolStripMenuItem.Tag = blueToolStripMenuItem1.Tag = Color.Blue;
            GreenToolStripMenuItem.Tag = greenToolStripMenuItem1.Tag = Color.Green;
            YellowToolStripMenuItem.Tag = yellowToolStripMenuItem1.Tag = Color.Yellow;

            // test
            //listBox1.Items.Add(new Book { Title = "new" });
            //listBox1.Items.Add(new Book { Title = "new2" });
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

        private void TextColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sender is ToolStripMenuItem menuItem && menuItem.Tag is Color color)
            {
                if (richTextBox1.SelectionLength > 0)
                    richTextBox1.SelectionColor = color;
            }
        }

        private void BackgroundColorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (sender is ToolStripMenuItem menuItem && menuItem.Tag is Color color)
            {
                if (richTextBox1.SelectionLength > 0)
                    richTextBox1.SelectionBackColor = color;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                richTextBox1.Rtf = ((Book)listBox1.SelectedItem).Text;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                ((Book)listBox1.SelectedItem).Text = richTextBox1.Rtf;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Book book = new Book();
            if ((new FormEditBook(book)).ShowDialog() == DialogResult.OK)
            {
                listBox1.Items.Add(book);
            }
        }

        private void FormWorker_Load(object sender, EventArgs e)
        {
            if (Directory.Exists("Books"))
            {
                foreach (var bookpath in Directory.EnumerateFiles("Books"))
                {
                    Book book = JsonSerializer.Deserialize<Book>(File.ReadAllText(bookpath));
                    if (book != null)
                    {
                        listBox1.Items.Add(book);
                    }
                }
            }
        }

        private void FormWorker_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!Directory.Exists("Books"))
                Directory.CreateDirectory("Books");
            foreach (Book item in listBox1.Items)
            {
                var save = JsonSerializer.Serialize(item);
                StreamWriter writer = new(File.OpenWrite("Books\\" + item.ToString()));
                writer.Write(save);
                writer.Close();
            }
        }

        private void FontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sender is ToolStripMenuItem)
            {
                switch (((ToolStripMenuItem)sender).Text) 
                {
                    case "Time New Roman":
                        richTextBox1.SelectionFont = new Font("Times New Roman", richTextBox1.SelectionFont.Size);
                        break;
                    case "Sans":
                        richTextBox1.SelectionFont = new Font(FontFamily.GenericSansSerif, richTextBox1.SelectionFont.Size);
                        break;
                    case "Old English Text MT":
                        richTextBox1.SelectionFont = new Font("Old English Text MT", richTextBox1.SelectionFont.Size);
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
