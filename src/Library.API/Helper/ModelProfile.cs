using AutoMapper;
using Library.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Library.API.Helper
{
    public class ModelProfile : Profile
    {
        public override string ProfileName
        {
            get { return "ViewModelMappings"; }
        }

        protected override void Configure()
        {

        }
    }
}