using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Project.Models;
using Project.Services;
using System;
using System.Collections.Generic;
using System.IO;

namespace Project.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        private readonly IConfiguration _configuration;
        private readonly IFileOperation _fileOperation;
        private readonly IMapper _mapper;
        public HomeController(IConfiguration configuration, IFileOperation fileOperation, IMapper mapper)
        {
            _configuration = configuration;
            _fileOperation = fileOperation;
            _mapper = mapper;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("Event")]
        public IActionResult Event(bool isRandom)
        {
            var path = Path.Combine(_configuration.GetValue<string>(WebHostDefaults.ContentRootKey), $"wwwroot\\assets\\secure\\events.json");
            var events = _fileOperation.ReadFile(path);
            var result = _mapper.Map<List<EventJson>, List<Event>>(events);

            if (isRandom)
            {
                var random = new Random();
                var count = result.Count;
                for (var i = 0; i < count - 1; ++i)
                {
                    var r = random.Next(i, count);
                    var tmp = result[i];
                    result[i] = result[r];
                    result[r] = tmp;
                }

            }

            return View(new EventModel() {Event = result});
        }

        [HttpPost]
        [Route("EventPost")]
        public IActionResult EventPost(EventModel model)
        {
            return RedirectToAction("Event",new { isRandom= model.isRandom });
        }
    }
}