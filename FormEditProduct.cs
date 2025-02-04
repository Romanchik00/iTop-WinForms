using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsHomeWork
{
    public partial class FormEditProduct : Form
    {
        List<Store_Item> Store = Form1.Store;
        Store_Item _Item;
        public FormEditProduct()
        {
            InitializeComponent();
        }
        public void Edit(Store_Item? item)
        {
            if (item != null)
            {
                var i = Store.Find(x => x == item);
                if (i != null)
                {
                    _Item = i;
                    textBox1.Text = i.Name;
                    textBox2.Text = i.Manufacturer;
                    numericUpDown1.Value = i.Ammount;
                    numericUpDown2.Value = decimal.Parse(i.Price.ToString());
                }
            }

        }
        private void Save_Click(object sender, EventArgs e)
        {
            if (_Item != null)
            {
                Store.Find(x=>x.Name==_Item.Name).EditItem(
                    textBox1.Text,
                    textBox2.Text,
                    decimal.ToDouble(numericUpDown2.Value),
                    decimal.ToInt32(numericUpDown1.Value)
                    );
            }
            else
            {
                Store.Add(new(
                    textBox1.Text,
                    textBox2.Text,
                    decimal.ToDouble(numericUpDown2.Value),
                    decimal.ToInt32(numericUpDown1.Value)));
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
