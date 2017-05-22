using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.API.Helper
{
    public interface IMapperController
    {
        void MapEntityToModel(IProfileExpression profile);
    }
}
