namespace WinFormsHomeWork
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            foreach (TextBox textBox in groupBox1.Controls)
            {
                if (textBox.Text == "" || textBox.Text == null)
                {
                    MessageBox.Show("Пустая строка");
                    return;
                }
            }
            User user = new User(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
            listBox1.Items.Add(user);
            foreach (TextBox textBox in groupBox1.Controls)
            {
                textBox.Clear();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                User user = listBox1.SelectedItem as User;

                if (user != null)
                {
                    textBox1.Text = user.name;
                    textBox2.Text = user.lastname;
                    textBox3.Text = user.email;
                    textBox4.Text = user.phone;
                }
            }
            button3_Click(sender, e);
        }

        private class User
        {
            public string name { get; private set; }
            public string lastname { get; private set; }
            public string email { get; private set; }
            public string phone { get; private set; }

            public User(string name, string lastname, string email, string phone)
            {
                this.name = name;
                this.lastname = lastname;
                this.email = email;
                this.phone = phone;
            }
            public User(string[] strings)
            {
                name = strings[0];
                lastname = strings[1];
                email = strings[2];
                phone = strings[3];
            }
            public override string ToString()
            {
                return name + ' ' + lastname + ' ' + email + ' ' + phone;
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter("users.txt"))
            {
                foreach (var item in listBox1.Items)
                {
                    sw.WriteLine(item.ToString());
                }
                sw.Flush();
                sw.Close();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var str = File.ReadAllLines("users.txt");
            foreach (var item in str)
            {
                listBox1.Items.Add(new User(item.Split(' ')) );
            }
        }

    }
}
