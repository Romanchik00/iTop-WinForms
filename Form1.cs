using System;

namespace WinFormsHomeWork
{
    //"Мишка косолапый","Красный Октябрь",600
    //"Красная шапочка","Красный Октябрь",550
    //"Белочка","Красный Октябрь",500
    //"Коровка","Рот Фронт",400
    //"Птичье молоко","Рот Фронт",700

    //string formattedString = string.Format("{0:F2}", myDouble); // "12.35"
    //string interpolatedString = $"{myDouble:F2}";
    //string stringValue = myDouble.ToString("F2");

    public partial class Form1 : Form
    {
        public static List<Store_Item> Store = new List<Store_Item>() 
        {
            new Store_Item("Мишка косолапый","Красный Октябрь", 600 , 100),
            new Store_Item("Красная шапочка", "Красный Октябрь", 550 , 100),
            new Store_Item("Белочка", "Красный Октябрь", 500 , 100)
        };
        public static List<Store_Item> TotalSales = new();
        public Form1()
        {
            InitializeComponent();
            foreach (Store_Item item in Store)
            {
                comboBox1.Items.Add((Candy)item);
            }
            Store.ForEach(x => TotalSales.Add(x.Copy()));
            TotalSales.ForEach(x => x.EditAmmo(0));
        }

        public class Candy
        {
            public string Name { get; private set; }
            public string Manufacturer { get; private set; }
            public double Price { get; private set; }

            public Candy(string name, string manufacturer, double price)
            {
                Name = name;
                Manufacturer = manufacturer;
                Price = price;
            }

            public override string ToString()
            {
                return $"Название:\"{Name}\" Производители:\"{Manufacturer}\" Цена:{Price} руб./кг.";
            }
            public string ToShortString() { return $"{Name} {Manufacturer}"; }
            public static explicit operator Candy(Store_Item item)
            {
                return new Candy(item.Name, item.Manufacturer, item.Price) ;
            }
        }
        private class Check_Candy
        {
            public Candy Item { get; private set; }
            public int Ammount { get; private set; }
            public Check_Candy(Candy candy, int ammo)
            {
                Item = candy;
                Ammount = ammo;
            }
            public override string ToString()
            {
                return $"{Item.ToString()} * {Ammount} - {Item.Price * Ammount}";
            }
            public string ToShortString() { return Item.ToShortString(); }
            public double GetSum() 
            {
                return Item.Price * Ammount;
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null && numericUpDown1.Value > 0)
            {
                checkedListBox1.Items.Add(new Check_Candy((Candy)comboBox1.SelectedItem, (int)numericUpDown1.Value));
            }
            numericUpDown1.Value = 0;
        }

        private void GetCheck_Click(object sender, EventArgs e)
        {
            string check = "";
            double sum = 0;
            foreach (Check_Candy item in checkedListBox1.CheckedItems)
            {
                var s = Store.Find(x => x.Name == item.Item.Name && x.Manufacturer == item.Item.Manufacturer);
                var ts = TotalSales.Find(x => x.Name == item.Item.Name && x.Manufacturer == item.Item.Manufacturer);
                if (s is not null && ts is not null)
                {
                    if (s.Ammount - item.Ammount >= 0)
                    {
                        ts.AmmoPM(item.Ammount, '+');
                        s.AmmoPM(item.Ammount, '-');
                    }
                    else
                    {
                        MessageBox.Show("Error: low items");
                    }
                }

            }

            foreach (Check_Candy item in checkedListBox1.CheckedItems) 
            {
                check += $"{item.ToShortString()}\t\t{item.GetSum()} руб\n";
                sum += item.GetSum();
            }
            check += $"Итог:\t{sum}";
            MessageBox.Show(check);
            checkedListBox1.Items.Clear();
            comboBox1.Items.Clear();
            label2.Text = "0.00";
            foreach (Store_Item item in Store)
            {
                comboBox1.Items.Add(new Candy(item.Name,item.Manufacturer,item.Price));
            }
        }

        private void Store_Click(object sender, EventArgs e)
        {
            FormAutorization Autorization = new FormAutorization();
            Autorization.ShowDialog(this);
        }

        private void Finish_Shift_Click(object sender, EventArgs e)
        {
            string check = "";
            double sum = 0;

            foreach (var item in TotalSales)
            {
                //check += $"{item.ToShortString()}\t\t{item.GetSum()} руб\n";
                check += $"{item.Name} {item.Manufacturer} - {item.Ammount} кг.\t {item.Price * item.Ammount} руб\n";
                sum += item.Price * item.Ammount;
            }
            check += $"Итог:\t{sum}";
            MessageBox.Show(check);
        }

        private void TotalSum(object sender, EventArgs e)
        {
            if(checkedListBox1.SelectedItem != null)
            {
                double sum = 0;
                foreach(Check_Candy item in checkedListBox1.CheckedItems)
                {
                    sum += item.GetSum();
                }
                label2.Text = sum.ToString("F2");
            }
        }
    }
}
