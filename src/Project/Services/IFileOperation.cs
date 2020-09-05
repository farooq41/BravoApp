using Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Services
{
    public interface IFileOperation
    {
        List<EventJson> ReadFile(string path);
    }
}
