using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace New_Stuff.ViewModels
{
    public class CupTradeViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Display(Name = "Whats App Contact")]
        public string WhatsApp { get; set; }

        [Required]
        [StringLength(250, ErrorMessage = "Required")]
        [Display(Name ="How would you describe your relationship with this cup?")]
        public string CupRelationShip { get; set; }

        [Required]
        [StringLength(250, ErrorMessage = "Required")]
        [Display(Name = "What is the reason of giving this cup away?")]
        public string GiveReason { get; set; }

        [Required]
        [StringLength(250, ErrorMessage ="Required")]
        [Display(Name = "What would you do with the new cup?")]
        public string WhatWouldYouDo { get; set; }

        [Required]
        [Display(Name = "Share a photo of your cup")]
        public string ImagePath { get; set; }

        [Required]
        [Display(Name ="Pick a Mtr station for exchange.")]
        public string MetroStation { get; set; }

        [Required]
        [Display(Name = "Exchange Date & Time")]
        public DateTime ExchangeDate { get; set; }

        [Required]
        [Display(Name = "Pick a cup to exchange")]
        public string CupChoice { get; set; }

        public IEnumerable<string> CupChoices { get; set; }

        public IEnumerable<Tuple<string, string>> GetAll()
        {
            IList<Tuple<string, string>> vals = new List<Tuple<string, string>>();

            vals.Add(new Tuple<string, string>("Email Address", Email));
            vals.Add(new Tuple<string, string>("Whats App", WhatsApp));
            vals.Add(new Tuple<string, string>("Relationship", CupRelationShip));
            vals.Add(new Tuple<string, string>("Reason for Giving", GiveReason));
            vals.Add(new Tuple<string, string>("New cup use", WhatWouldYouDo));
            vals.Add(new Tuple<string, string>("Metro Station", MetroStation));
            vals.Add(new Tuple<string, string>("Prefered Cup", CupChoice));

            return vals;
        }
    }
}
