using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using New_Stuff.Models;

namespace New_Stuff.ViewModels
{
    public class PodcastListViewModel
    {
        public int Page { get; set; }

        public IEnumerable<PodcastModel> Podcasts { get; set; }
    }
}
