using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TelegramSMM.Models;

namespace TelegramSMM.ViewModels
{
    public class ViewPost
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public string Link { get; set; }
        public HttpPostedFileBase Image { get; set; }
        public string AdditionalInformation { get; set; }
        public string UserId { get; set; }
        public bool IsDeleted { get; set; }

    }
}