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
    public partial class FormAdmin : Form
    {
        User user;
        
        public FormAdmin()
        {
            InitializeComponent();
            if (!(Form1.users[0].Login == "admin" && Form1.users[0].Password == "admin"))
            {
                Form1.users.ForEach(u => { listBox1.Items.Add(u); });
            }
            TextBox text = new TextBox();
            
        }

        public void buttonAddUser_Click(object sender, EventArgs e)
        {
            user = new();
            FormEditUser formEditUser = new(user);
            if (formEditUser.ShowDialog() == DialogResult.OK)
            {
                listBox1.Items.Add(user);
                Form1.users.Add(user);
            }

        }

        private void buttonDeleteUser_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedItem is not null)
            {
                Form1.users.Remove(listBox1.SelectedItem as User);
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
        }

        private void FormAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.Close();
        }

        private void FormAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (listBox1.Items.Count == 0) 
            {
                return;
            }
            using (var fs = File.Create("users"))
            {
                JsonSerializer.Serialize(fs, listBox1.Items.Cast<User>().ToList());
            }
        }
    }
}
