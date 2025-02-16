using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// comboBox1.Items.AddRange(new object[] { UserStatus.Admin, UserStatus.Worker, UserStatus.Visitor });

namespace WinFormsRomRom
{
    public partial class FormEditUser : Form
    {
        User newUser;
        public FormEditUser(User user)
        {
            InitializeComponent();
            comboBox1.Items.AddRange(new object[] { UserStatus.Admin, UserStatus.Worker, UserStatus.Visitor });
            newUser = user;
        }

        private void buttonCreat_Click(object sender, EventArgs e)
        {
            List<TextBox> list = new List<TextBox>() { textBoxLogin, textBoxPass, textBoxEmail };
            foreach (TextBox t in list)
            {
                if (t.Text == null || t.Text == "")
                {
                    MessageBox.Show("Error: empty field");
                    this.DialogResult = DialogResult.Abort;
                    Close();
                    return;
                }
            }
            newUser.Login = textBoxLogin.Text;
            newUser.Password = textBoxPass.Text;
            newUser.email = textBoxEmail.Text;
            newUser.Status = (UserStatus)comboBox1.SelectedItem;

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
