using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Business.Actions
{
    public interface ILibraryService
    {
        IEnumerable<Data.Entity.Library> GetAllLibraries();
    }
}
