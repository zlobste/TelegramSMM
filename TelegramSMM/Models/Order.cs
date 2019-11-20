using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TelegramSMM.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime PublicationDate { get; set; }
        public Channel Channel { get; set; }
        public int ChannelId { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }
        public Post Post { get; set; }
        public int PostId { get; set; }
    }
}