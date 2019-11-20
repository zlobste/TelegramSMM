using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TelegramSMM.Models
{
    public class User : IdentityUser
    {
        public string TelegramAccount { get; set; }
        public double Balance { get; set; }


      
        public ICollection<Post> Posts { get; set; }
        public ICollection<Channel> Channels { get; set; }
        public ICollection<Order> Orders { get; set; }



        public User()
        {
            
            Posts = new List<Post>();
            Channels = new List<Channel>();
            Orders = new List<Order>();

        }
    }
}