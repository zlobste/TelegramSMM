using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TelegramSMM.Models
{
    public class Theme
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Channel> Channels { get; set; }


        public Theme()
        {
            Channels = new List<Channel>();

        }

    }
}