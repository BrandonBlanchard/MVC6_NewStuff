using System;
using System.Collections.Generic;
using New_Stuff.Helpers;
using New_Stuff.Models;

namespace New_Stuff.Repositories
{
    public class PodcastRepository
    {
        public IEnumerable<PodcastModel> Podcasts { get; private set; }

        public PodcastRepository()
        {
            int count = 50;
            Random rnd = new Random();
            List<PodcastModel> podcast = new List<PodcastModel>();
            
            for(int i = 0; i < count; i += 1)
            {
                podcast.Add(new PodcastModel() {
                    Title = LoremIpsumHelpers.GetSentence(),
                    Description = LoremIpsumHelpers.GetParagraph(),
                    Duration = rnd.Next(60, 65898),
                    Published = DateTime.Now.AddDays(rnd.Next(-365, 365)),
                    ImageSrc = rnd.Next(1, 9).ToString()
                });
            }

            Podcasts = podcast;
        }
    }
}
