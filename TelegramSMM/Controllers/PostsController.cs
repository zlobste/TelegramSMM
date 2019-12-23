using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using TelegramSMM.Models;
using TelegramSMM.ViewModels;

namespace TelegramSMM.Controllers
{
    public class PostsController : Controller
    {
        private ApplicationContext db = new ApplicationContext();

        // GET: Posts
        public async Task<ActionResult> Index()
        {

            string UserId = User.Identity.GetUserId();
            var posts = db.Posts.Include(p => p.User);
            var sposts = from a in posts
                where a.User.Id == UserId
                select a;
           
            return View(await sposts.ToListAsync());
        }


        // GET: Channels/Create
        [Authorize]
        public ActionResult Create()
        {

            return View();
        }


        // POST: Posts/Create
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create( Post post , HttpPostedFileBase Picture )
        {
            if (ModelState.IsValid )
            {
                if (Picture != null)
                {
                    string fileName = Guid.NewGuid().ToString() + ".jpeg";
                    Picture.SaveAs(Server.MapPath("~/Images/" + fileName));
                    post.Image = fileName;
                }
                post.UserId = User.Identity.GetUserId();
                db.Posts.Add(post);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(post);
        }

        // GET: Posts/Edit/
        [Authorize]
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Post post = await db.Posts.FindAsync(id);
            
            if (post == null)
            {
                return HttpNotFound();
            }
           
            return View(post);
        }




        // GET: Posts/Details/
        [Authorize]
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Post post = await db.Posts.FindAsync(id);
            if (post == null)
            {
                return HttpNotFound();
            }
            return View(post);
        }




        [Authorize]
        public ActionResult GetChannelsByOrder(int? Id)
        {
            if (Id == null)
            {
                return HttpNotFound();
            }
            Post post = db.Posts.Find(Id);
            List<Order> orders = (from a in db.Orders.ToList()
                where a.PostId == Id
                select a).ToList();
            List<Channel> channels = new List<Channel>();
            List<string> channelsId = new List<string>();
            foreach (var p in orders)
            {
                if (channelsId.IndexOf(db.Channels.Find(p.ChannelId).Id) == -1)
                {
                    channels.Add(db.Channels.Find(p.ChannelId));
                    channelsId.Add(db.Channels.Find(p.ChannelId).Id);
                }
               
            }

            ViewBag.Count = channels.Count;
            ViewBag.Channels = channels;
            ViewBag.PostName = post.Title;
            return View();
        }
        public ActionResult GetTopFourPosts()
        {
            Dictionary<int, int> postnums = new Dictionary<int, int>();
            foreach (var a in db.Orders.ToList())
            {
                if (postnums.ContainsKey(a.PostId.Value))
                {
                    postnums[a.PostId.Value] += 1;
                }
                else
                {
                    postnums.Add(a.PostId.Value, 1);
                }
                
            }
            postnums = postnums.OrderByDescending(p=>p.Value).ToDictionary(pair => pair.Key, pair => pair.Value);

            List<Post> posts  =new List<Post>();
            if (postnums.Count >= 4)
            {
                for (int i = 0; i < 4; i++)
                {
                    posts.Add(db.Posts.Find(postnums.First().Key));
                    postnums.Remove(postnums.First().Key);
                }
              
            }
            else
            {
                int co = postnums.Count;
                for (int i = 0; i < co; i++)
                {
                    posts.Add(db.Posts.Find(postnums.First().Key));
                    postnums.Remove(postnums.First().Key);
                }
            }


            return View(posts);
        }


        // POST: Posts/Edit/
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(Post post, HttpPostedFileBase Picture)
        {
            if (ModelState.IsValid)
            {
                
                string fileName = Guid.NewGuid().ToString() + ".jpeg";
                if (post.Image != fileName && Picture!=null)
                {
                    Picture.SaveAs(Server.MapPath("~/Images/" + fileName));
                    post.Image = fileName;
                }

                post.UserId = User.Identity.GetUserId();
                db.Entry(post).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.UserId = new SelectList(db.Users, "Id", "TelegramAccount", post.UserId);
            return View(post);
        }


        [Authorize]
        [HttpGet]
        public async Task<ActionResult> DeletePost(int? id)
        {
            if (id == null)
            {
                 return HttpNotFound();
            }
            Post post = await db.Posts.FindAsync(id);
            if (post == null)
            {
                return HttpNotFound();
            }

            db.Posts.Remove(post);
            await db.SaveChangesAsync();


            return RedirectToAction("Index");
        }




        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
