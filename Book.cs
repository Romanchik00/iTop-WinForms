using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsRomRom
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public string Text { get; set; }
        public override string ToString()
        {
            return Author + " " + Title;
        }
        public Book() 
        {
            Title = "";
            Author = "";
            Description = "";
            Text = "";
        }
    }
}
