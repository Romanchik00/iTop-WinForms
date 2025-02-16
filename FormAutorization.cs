﻿using System;
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
    public partial class FormAutorization : Form
    {
        private string login = "admin";
        private string pass = "admin";
        public FormAutorization()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text) || !string.IsNullOrEmpty(textBox2.Text)) 
            {
                if (textBox1.Text == login && textBox2.Text == pass)
                {
                    FormStore formStore = new FormStore();
                    formStore.Show(Owner);
                    this.Close();
                }
                else 
                {
                    MessageBox.Show("Error: unknown user");
                }
            }
            else
            {
                MessageBox.Show("Error: empty fields");
            }
        }
    }
}
