using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;

namespace ProjectX.AutoMapper
{
    public class Configuration
    {
        public static void Configure()
        {
            Mapper.Initialize(ctg => ctg.AddProfiles(new[] { "ProjectX" }));
        }
    }
}