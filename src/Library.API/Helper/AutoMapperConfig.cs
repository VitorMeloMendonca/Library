using AutoMapper;
using Library.API.Models;
using Library.Business.Entity;

namespace Library.API.Helper
{
    public class AutoMapperConfig
    {
        public static void Register()
        {
            Mapper.Initialize(m =>
            {
                m.AddProfile<EntityProfile>();
                m.AddProfile<ModelProfile>();
                m.CreateMap<Data.Entity.Library, LibraryViewModel>();
                m.CreateMap<Book, BookViewModel>();
                m.CreateMap<Author, AuthorViewModel>();
                //RegisterControllerMappings(m);
            });
        }
        //private static void RegisterControllerMappings(IConfiguration configuration)
        //{
        //    var executingAssembly = Assembly.GetExecutingAssembly();
        //    var interfaceType = typeof(IMapperController);
        //    var types = executingAssembly.GetTypes().Where(currentType => currentType.IsClass && interfaceType.IsAssignableFrom(currentType));
        //    foreach (var type in types)
        //    {
        //        var objectInstance = FormatterServices.GetUninitializedObject(type) as IMapperController;
        //        objectInstance.MapEntityToModel(configuration.CreateProfile(type.Name + "EntityToModel"));
        //        objectInstance.MapEntityToModel(configuration.)
        //        //objectInstance.MapModelToEntity(configuration.CreateProfile(type.Name + "ModelToEntity"));
        //    }
        //}
    }
}