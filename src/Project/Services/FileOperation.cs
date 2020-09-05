using Newtonsoft.Json.Linq;
using Project.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Services
{
    public class FileOperation : IFileOperation
    {
        public List<EventJson> ReadFile(string path)
        {
            var fileContents = File.ReadAllText(path);
            var json = (JArray) Newtonsoft.Json.JsonConvert.DeserializeObject(fileContents);
            List<EventJson> events = json.ToObject<List<EventJson>>();
            return events;
        }
    }
}
