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
            var posts = db.Posts.Include(p => p.User);
            return View(await posts.ToListAsync());
        }


        // GET: Channels/Create
        public ActionResult Create()
        {

            return View();
        }


        // POST: Posts/Create
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

        // POST: Posts/Edit/
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(Post post, HttpPostedFileBase Picture)
        {
            if (ModelState.IsValid)
            {
                
                string fileName = Guid.NewGuid().ToString() + ".jpeg";
                if (post.Image != fileName)
                {
                    Picture.SaveAs(Server.MapPath("~/Images/" + fileName));
                    post.Image = fileName;
                }
                
                db.Entry(post).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.UserId = new SelectList(db.Users, "Id", "TelegramAccount", post.UserId);
            return View(post);
        }



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
