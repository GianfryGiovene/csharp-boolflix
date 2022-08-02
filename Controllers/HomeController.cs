using BoolFlix.Context.DB;
using BoolFlix.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BoolFlix.Controllers
{
    
    public class HomeController : Controller
    {
        private readonly BoolflixContext _context;

        public HomeController(BoolflixContext context)
        {
            _context = context;
        }

        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}
        
        public IActionResult Index()
        {
            List<VideoContent> videoContentList = _context.VideoContents.ToList();

            Random rnd = new Random();
            VideoContent videoContent = videoContentList[rnd.Next(0, videoContentList.Count())];

            ViewData["Jumbotron"] = videoContent;
            return View("Index",videoContentList);
                
        }

        public IActionResult Play(int id, int profileId)
        {

            Profile profile = _context.Profiles.Where(x => x.Id == profileId).FirstOrDefault();
            profile.VideoContents = new List<VideoContent>();
            VideoContent content = _context.VideoContents.Where(x => x.Id == id).FirstOrDefault();
            
            profile.VideoContents.Add(content);

            _context.SaveChanges();
            return RedirectToAction("Index");
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