using AutoMapper;
using Library.API.Helper;
using Library.API.Models;
using Library.Business.Actions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Library.API.Controllers
{
    [RoutePrefix("api/Library")]
    public class LibraryController : ApiController, IMapperController
    {
        [HttpGet]
        [Route("GetAllLibrary")]
        public IEnumerable<LibraryViewModel> GetAllLibrary()
        {
            LibraryService libraryService = new LibraryService();
            var lib = libraryService.GetAllLibraries();


            return Mapper.Map<IEnumerable<LibraryViewModel>>(lib);
            
        }

        public void MapEntityToModel(IProfileExpression profile)
        {
            //profile.CreateMap<Data.Entity.Library, LibraryViewModel>();
            profile.CreateMap<Data.Entity.Library, LibraryViewModel>();
        }
    }
}
