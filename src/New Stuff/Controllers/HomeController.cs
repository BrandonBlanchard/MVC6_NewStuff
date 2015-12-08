using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using New_Stuff.Models;
using New_Stuff.Services;
using New_Stuff.ViewModels;

namespace New_Stuff.Controllers
{
    public class HomeController : Controller
    {
        public IPodcastService _podcastService;
        
        public HomeController(IPodcastService service)
        {
            _podcastService = service;
        }

        public IActionResult Index(int page = 0)
        {
            PodcastListViewModel model = _podcastService.GetPodcasts(page);

            return View(model);
        }

        public IActionResult Podcast(int podcast = 0)
        {
            PodcastModel model = _podcastService.GetPodcast(podcast);

            return View(model);
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
