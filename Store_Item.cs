using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsHomeWork
{
    public class Store_Item
    {
        public string Name { get; private set; }
        public string Manufacturer { get; private set; }
        public double Price { get; private set; }
        public int Ammount { get; private set; }
        public Store_Item(string name, string manufacturer, double price , int ammount) 
        {
            Name = name;
            Manufacturer = manufacturer;
            Price = price;
            Ammount = ammount;
        }
        public void EditItem(string name, string manufacturer, double price, int ammount) 
        {
            Name = name;
            Manufacturer = manufacturer;
            Price = price;
            Ammount = ammount;
        }
        public void EditAmmo(int ammount)
        {
            Ammount = ammount;
        }
        public void AmmoPM(int ammount, char sigil)
        {
            switch (sigil)
            {
                case '+':
                    Ammount += ammount;
                    break;
                case '-':
                    Ammount -= ammount;
                    break;
                default:
                    MessageBox.Show("Error: incorrect sigil");
                    break;
            }
        }
        public Store_Item Copy() { return new(Name,Manufacturer, Price, Ammount); }
        public override string ToString()
        {
            return $"Название:\"{Name}\" Производители:\"{Manufacturer}\" Цена:{Price} руб./кг. На складе:{Ammount}";
        }
    }
}
