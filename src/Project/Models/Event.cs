using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Models
{
    public class Event
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public string ImgUrlMobile { get; set; }

        public string ImgUrlMobile2x { get; set; }

        public string ImgUrlDesktop { get; set; }

        public string ImgUrlDesktop2x { get; set; }
    }
}
