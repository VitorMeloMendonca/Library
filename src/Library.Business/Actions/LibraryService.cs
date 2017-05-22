using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Library.Data.Entity;
using Library.Data;


namespace Library.Business.Actions
{
    public class LibraryService : ILibraryService
    {
        public LibraryService() : base()
        {
        }

        public IEnumerable<Data.Entity.Library> GetAllLibraries()
        {
            LibraryContext context = new LibraryContext();
            var libraries = from x in context.Library select x;
            return libraries;
        }
    }
}