using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TelegramSMM.Models
{
    public class Channel
    {
        [Key]
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Link { get; set; }
        public string Type { get; set; }
        public User User { get; set; }
        public string UserId { get; set; }
        public double PostPrice { get; set; }
        public int CountOfSubscribers { get; set; }
        public string Image { get; set; }
        public string UserName { get; set; }


        public ICollection<Theme> Themes{ get; set; }
        public ICollection<Order> Orders { get; set; }



        public Channel()
        {
            Themes = new List<Theme>();
            Orders = new List<Order>();

        }
    }
}