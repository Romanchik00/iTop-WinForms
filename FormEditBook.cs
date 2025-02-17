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
    public partial class FormEditBook : Form
    {
        Book Book { get; set; }
        public FormEditBook(Book book)
        {
            InitializeComponent();
            Book = book;
        }

        private void buttonCreat_Click(object sender, EventArgs e)
        {
            foreach (var item in new List<TextBox>() { textBoxTitle, textBoxAuthor, textBoxDescription })
            {
                if (string.IsNullOrEmpty(item.Text))
                {
                    MessageBox.Show("Ошибка : пустые строки");
                    return;
                }
            }
            Book.Title = textBoxTitle.Text;
            Book.Author = textBoxAuthor.Text;
            Book.Description = textBoxDescription.Text;
            DialogResult = DialogResult.OK;
            Close();

        }
    }
}
