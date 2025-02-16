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
    }
}
