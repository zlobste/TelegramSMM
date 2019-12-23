using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls.Expressions;
using Microsoft.AspNet.Identity;
using TelegramSMM.Models;
using TelegramSMM.ViewModels;

namespace TelegramSMM.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationContext db = new ApplicationContext();

        // GET: Channels

        [HttpGet]
        public async Task<ActionResult> Index()
        {
            if (User.Identity.IsAuthenticated)
            {
                string UserId = User.Identity.GetUserId();
                List<Post> posts = (from a in db.Posts
                    where a.UserId == UserId
                    select a).ToList();
                ViewBag.PostId = new SelectList(posts, "Id", "Title");
                User u = db.Users.FirstOrDefault(m => m.Id == UserId);
                ViewBag.Balance = u.Balance;
            }

            var channels = db.Channels.Include(c => c.User);
            ViewBag.Channels = await channels.ToListAsync();
           
           
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Index(Search search)
        {
            if (User.Identity.IsAuthenticated)
            {
                string UserId = User.Identity.GetUserId();
                List<Post> posts = (from a in db.Posts
                    where a.UserId == UserId
                    select a).ToList();
                ViewBag.PostId = new SelectList(posts, "Id", "Title");
                User u = db.Users.FirstOrDefault(m => m.Id == UserId);
                ViewBag.Balance = u.Balance;
            }

            List<Channel> channels;
            if (search.Text != "" && search.Text != null)
            {
                channels = (from a in db.Channels
                    where (a.Name.ToUpper().Contains(search.Text.ToUpper()) ||
                           search.Text.ToUpper().Contains(a.Name.ToUpper()) ||
                           a.Description.ToUpper().Contains(search.Text.ToUpper()) ||
                           search.Text.ToUpper().Contains(a.Description.ToUpper()) ||
                           a.Link.ToUpper().Contains(search.Text.ToUpper()) ||
                           search.Text.ToUpper().Contains(a.Link.ToUpper()))
                    select a).ToList();
            }
            else
            {
                channels = await db.Channels.ToListAsync();
            }
            


            if (search.MaxPrice != null)
            {
                channels = (from b in channels
                            where b.PostPrice <= search.MaxPrice
                            select b).ToList();
            }
            if (search.MinPrice != null)
            {
                channels = (from c in channels
                    where c.PostPrice >= search.MinPrice
                    select c).ToList();
            }
            if (search.MinSubscribers != null)
            {
                channels = (from d in channels
                    where d.CountOfSubscribers >= search.MinSubscribers
                            select d).ToList();
            }
            if (search.MaxSubscribers != null)
            {
                channels = (from e in channels
                    where e.CountOfSubscribers <= search.MaxSubscribers
                    select e).ToList();
            }

            if (search.Sort.Equals("increasePrice"))
            {
                channels = (from u in channels
                    orderby u.PostPrice 
                    select u).ToList();
            }
            else if (search.Sort.Equals("decreasePrice"))
            {
                channels = (from u in channels
                    orderby u.PostPrice descending
                            select u).ToList();
               
            }
            else if (search.Sort.Equals("increaseSubscribers"))
            {
                channels = (from u in channels
                    orderby u.CountOfSubscribers
                    select u).ToList();

            }
            else if (search.Sort.Equals("decreaseSubscribers"))
            {
                channels = (from u in channels
                    orderby u.CountOfSubscribers descending
                    select u).ToList();
            }

            ViewBag.Channels = channels;

            return View(search);
        }


        [HttpGet]
        public ActionResult GetTopFourChannels()
        {
            List<Channel>channels = db.Channels.Include(c => c.User).ToList();
            

            channels = channels.OrderByDescending(i => i.CountOfSubscribers).ToList();
            List<Channel> TopFour = new List<Channel>();
            TopFour.Add(channels[0]);
            TopFour.Add(channels[1]);
            TopFour.Add(channels[2]);
            TopFour.Add(channels[3]);
            TopFour.OrderByDescending(i => i.CountOfSubscribers);
            ViewBag.Channels = TopFour;

            return View();
        }



    }
} 