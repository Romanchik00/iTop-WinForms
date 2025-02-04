using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsHomeWork
{
    public partial class FormStore : Form
    {
        List<Store_Item> Store = Form1.Store;
        public FormStore()
        {
            InitializeComponent();
            //listBox1.Items.AddRange(Store.ToArray());
            Program.listRefresh(Store, listBox1);
        }

        private void AddItem_Click(object sender, EventArgs e)
        {
            FormEditProduct EditProduct = new FormEditProduct();
            if (EditProduct.ShowDialog() == DialogResult.OK)
            {
                Program.listRefresh(Store, listBox1);
                Program.isFresh = true;
            }
        }

        private void EditItem_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                FormEditProduct EditProduct = new FormEditProduct();
                EditProduct.Edit((Store_Item)listBox1.SelectedItem);
                if (EditProduct.ShowDialog() == DialogResult.OK)
                {
                    Program.listRefresh(Store, listBox1);
                    Program.isFresh = true;
                }
            }
        }

        private void DeleteItem_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                Store.Remove((Store_Item)listBox1.SelectedItem);
                Program.listRefresh(Store, listBox1);
                Program.isFresh = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormStore_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Program.isFresh) 
            {
                Program.listRefresh(Store,(System.Windows.Forms.ComboBox)Owner.Controls.Find("comboBox1", true)[0]);
            }
        }
    }
}
