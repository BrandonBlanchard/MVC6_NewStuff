using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using New_Stuff.Services;
using New_Stuff.ViewModels;

namespace New_Stuff.ViewComponents
{
    [ViewComponent(Name = "RelatedPodcasts")]
    public class RelatedPodcastsComponent : ViewComponent
    {
        protected ICupService service;

        public RelatedPodcastsComponent(ICupService _service)
        {
            service = _service;
        }

        public IViewComponentResult Invoke(string podcast)
        {
            return View();
        }
    }
}
