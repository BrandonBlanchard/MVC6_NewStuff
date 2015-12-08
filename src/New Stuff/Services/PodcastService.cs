using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using New_Stuff.Models;
using New_Stuff.Repositories;
using New_Stuff.Services;
using New_Stuff.ViewModels;

namespace New_Stuff.Services
{
    public class PodcastService : IPodcastService
    {
        PodcastRepository repository = new PodcastRepository();

        private static int pageLength = 12;

        public PodcastListViewModel GetPodcasts (int count)
        {
            PodcastListViewModel model = new PodcastListViewModel();

            model.Page = count;
            model.Podcasts = repository.Podcasts.Skip(count * pageLength).Take(pageLength);

            return model;
        }

        public RelatedPodcastViewModel GetRelatedPodcasts(string podcast)
        {
            RelatedPodcastViewModel model = new RelatedPodcastViewModel();

            model.RelatedPodcasts = repository.Podcasts.Take(3);
            
            return model;
        }

        public PodcastModel GetPodcast(int id)
        {
            return repository.Podcasts.FirstOrDefault();
        }
    }
}
