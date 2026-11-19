using System;
using System.Collections.Generic;
using System.Text;

namespace C__Basics_Session02
{
    internal class Book
    {
        public string title;
        public int pages;
        public override string ToString()
        {
            return $"Title: {title}, pages: {pages} ";
        }
    }
}
