using System;
using System.Collections.Generic;
using System.Text;

namespace WeekendsDay7
{
    internal class Book
    {
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public int PageCount { get; set; }
        public string Code { get; set; }
        public static int  Counter=10;


        public Book(string name,string authorname,int pagecount)
        {
            Counter++;
            Name = name;    
            AuthorName = authorname;
            PageCount = pagecount;

            Code = Name.Substring(0,2).ToUpper().ToString() +  "-" + Counter;
        }

    }
}
