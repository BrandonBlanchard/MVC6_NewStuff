using System;

namespace New_Stuff.Models
{
    public class PodcastModel
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public string ImageSrc { get; set; }

        public int Duration { get; set; }

        public DateTime Published { get; set; }
    }
}