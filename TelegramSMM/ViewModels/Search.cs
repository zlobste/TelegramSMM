using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TelegramSMM.ViewModels
{
    public class Search
    {
        public string Text { get; set; }
        public int? MinPrice { get; set; }
        public int? MaxPrice { get; set; }
        public int? MinSubscribers { get; set; }
        public int? MaxSubscribers { get; set; }
        public string Sort { get; set; }
   
    }
}