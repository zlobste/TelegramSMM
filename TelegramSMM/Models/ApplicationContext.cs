using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace TelegramSMM.Models
{
    public class ApplicationContext: IdentityDbContext<User>
    {

        public ApplicationContext() : base("DefaultConnection") { }
        public ApplicationContext(string connectionString)
            : base(connectionString) { }


        public DbSet<Post> Posts { get; set; }
        public DbSet<Order> Orders { get; set; }

        internal static ApplicationContext Create()
        {
            return new ApplicationContext();
        }

        public DbSet<Channel>Channels { get; set; }

    }
}