using System.Text.Json;

namespace WinFormsRomRom
{
    public partial class Form1 : Form
    {
        public static List<User> users;
        bool f1 = false;
        public Form1()
        {
            InitializeComponent();
            try
            {
                using (var fs = File.OpenRead("users"))
                {
                    users = JsonSerializer.Deserialize<List<User>>(fs);
                }
                if (users == null)
                {
                    users = new List<User>();
                }
            }
            catch (FileNotFoundException)
            {
                users = new List<User>() { new("admin", "admin", "admin@admin", UserStatus.Admin) };
                f1 = true;
            }
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            foreach (var item in (new List<TextBox>() { textBoxLogin, textBoxPass }))
            {
                if (item.Text == null || item.Text.Length == 0)
                {
                    MessageBox.Show("Error: empty field");
                    return;
                }
            }
            User? user = users.Find(x => (x.Login == textBoxLogin.Text && x.Password == textBoxPass.Text) ? true : false);
            if (user is not null)
            {
                UserStatus status = user.Status;
                switch (status)
                {
                    case UserStatus.Admin:
                        {
                            FormAdmin formAdmin = new FormAdmin();
                            formAdmin.Show();

                            break;
                        }
                    case UserStatus.Worker:
                        {
                            FormWorker formWorker = new FormWorker();
                            formWorker.Show();

                            break;
                        }
                    case UserStatus.Visitor:
                        {
                            FormVisitor formVisitor = new FormVisitor();
                            formVisitor.Show();

                            break;
                        }
                    default:
                        {
                            MessageBox.Show("Error: unexisting status ! ");
                            break;
                        }
                }
            }
            else
            {
                MessageBox.Show("Error: user is null");
                return;
            }
            Hide();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            if (f1)
            {
                MessageBox.Show("В первый раз ?\n--Создай Админа !");
            }
        }
    }
}