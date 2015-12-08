using System.Collections.Generic;
using New_Stuff.Models;
using New_Stuff.ViewModels;

namespace New_Stuff.Services
{
    public interface IPodcastService
    {
        PodcastListViewModel GetPodcasts(int page);

        RelatedPodcastViewModel GetRelatedPodcasts(string podcast);

        PodcastModel GetPodcast(int id);
    }
}
