using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Lab_10._00
{
    internal class Book
    {
        public string Title;
        private int Pages;

        public Book(string title, int pages)
        {
            this.Title = title;
            this.Pages = pages;
        }
    }
}
