using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TelegramSMM.Models;

namespace TelegramSMM.Controllers
{
    public class HomeController : Controller
    {

       

        static List<Phone> data = new List<Phone>
        {
            new Phone { Id = Guid.NewGuid().ToString(), Name="iPhone 7", Price=52000 },
            new Phone { Id = Guid.NewGuid().ToString(), Name="Samsung Galaxy S7", Price=42000 },
        };

        public ActionResult GetPhones()
        {
            return Json(data, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult AddPhone(Phone phone)
        {
            phone.Id = Guid.NewGuid().ToString();
            data.Add(phone);
            return Json(phone);
        }

        [HttpDelete]
        public ActionResult DeletePhone(string id)
        {
            Phone phone = data.FirstOrDefault(x => x.Id == id);
            if (phone != null)
            {
                data.Remove(phone);
                return Json(phone);
            }
            return HttpNotFound();
        }
    }
}