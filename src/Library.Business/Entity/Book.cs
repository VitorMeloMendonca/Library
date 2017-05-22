using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Library.Business.Entity
{
    public class Book
    {
        public int BookID { get; set; }
        public int AuthorID { get; set; }
        public String Title { get; set; }

        public virtual Author Author { get; set; }
    }
}