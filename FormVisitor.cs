using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsRomRom
{
    public partial class FormVisitor : Form
    {
        public FormVisitor()
        {
            InitializeComponent();
        }

        private void FormVisitor_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.Close();
        }

        private void FormVisitor_Load(object sender, EventArgs e)
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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                richTextBox1.Rtf = ((Book)listBox1.SelectedItem).Text;
            }
        }
    }
}
