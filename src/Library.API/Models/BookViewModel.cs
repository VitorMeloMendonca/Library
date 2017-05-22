using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Library.API.Models
{
    public class BookViewModel
    {
        public int BookID { get; set; }
        public int AuthorID { get; set; }
        public String Title { get; set; }
    }
}