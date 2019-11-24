using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TelegramSMM.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public string Link { get; set; }
        public string Image { get; set; }
        public string AdditionalInformation { get; set; }
        public User User { get; set; }
        public string UserId { get; set; }
        public bool IsDeleted { get; set; }

       
        public ICollection<Order> Orders { get; set; }



        public Post()
        {
            Orders = new List<Order>();

        }
    }
}