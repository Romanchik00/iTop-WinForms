namespace WinFormsHomeWork
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());new int();
        }
        public static bool isFresh = false;
        public static void listRefresh(List<Store_Item> store , ListBox box) 
        {
            box.Items.Clear();
            foreach (Store_Item item in store) 
            {
                box.Items.Add(item);            
            }
        }
        public static void listRefresh(List<Store_Item> store, ComboBox box)
        {
            box.Items.Clear();
            foreach (Store_Item item in store)
            {
                box.Items.Add(item);
            }
        }
        public static void RefreshSales(this List<Store_Item> totalsales, List<Store_Item> store) 
        {
            foreach (Store_Item item in store) 
            {
                if (!totalsales.Contains(item))
                {
                    totalsales.Add(item);
                    totalsales.Last().EditAmmo(0);
                }
            }
        }
    }
}