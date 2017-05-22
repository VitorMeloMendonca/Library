using AutoMapper;
using Library.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Library.API.Helper
{
    public class EntityProfile: Profile
    {
        public override string ProfileName
        {
            get { return "DomainMappings"; }
        }

        protected override void Configure()
        {

        }
    }
}