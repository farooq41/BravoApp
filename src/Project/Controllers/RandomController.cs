using Microsoft.AspNetCore.Mvc;
using Project.Services;

namespace Project.Controllers
{
    [Route("Random")]
    public class RandomController : Controller
    {
        private IGenerateRandomNumber _generateRandomNumber;
        public RandomController(IGenerateRandomNumber generateRandomNumber)
        {
            _generateRandomNumber = generateRandomNumber;
        }

        // GET: RandomController
        [Route("Index")]
        public ActionResult Index()
        {
            return View();
        }


        // GET: RandomController/GenerateRandomNumber
        [Route("GenerateRandomNumber")]
        public ActionResult GenerateRandomNumber()
        {
            ViewData.Add("random", _generateRandomNumber.Generate());
            return View("Index");
        }       
    }
}
