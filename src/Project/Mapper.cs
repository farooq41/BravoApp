using AutoMapper;
using Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            CreateMap<EventJson, Event>();
        }
    }
}
