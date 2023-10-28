using AspNetCoreDevops.Models;
using AspNetCoreDevops.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AspNetCoreDevops.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IPostRepository _postRepository;


        public HomeController(IPostRepository postRepository)
        {
            _postRepository = postRepository;
        }

        public IActionResult Index()
        {
            var model = _postRepository.GetPosts();
            return View(model);
            //test change
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}