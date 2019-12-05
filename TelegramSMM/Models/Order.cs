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
        public string ChannelId { get; set; }
        public Post Post { get; set; }
        public int? PostId { get; set; }
        public double Cost { get; set; }
        public bool IsDone { get; set; }
        public bool Renouncement { get; set; }
        public bool DealCompleted { get; set; }
        public DateTime DatePost { get; set; }
        
    }
}