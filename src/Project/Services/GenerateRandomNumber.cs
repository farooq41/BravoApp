using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Services
{
    public class GenerateRandomNumber : IGenerateRandomNumber
    {
        public int Generate()
        {
            return new Random().Next();
        }
    }
}
