using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using New_Stuff.Models;

namespace New_Stuff.ViewModels
{
    public class RelatedPodcastViewModel
    {
        public RelatedPodcastViewModel()
        {
            RelatedPodcasts = new List<PodcastModel>();
        }

        public IEnumerable<PodcastModel> RelatedPodcasts { get; set; }
    }
}
