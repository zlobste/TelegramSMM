using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using TelegramSMM.Identity;
using TelegramSMM.Models;

namespace TelegramSMM.Controllers
{
    public class OrdersController : Controller
    {
        private ApplicationContext db = new ApplicationContext();


        private ApplicationUserManager UserManager
        {
            get
            {
                return HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();
            }
        }
        // GET: Orders
        public async Task<ActionResult> Index()
        {
            string UserId = User.Identity.GetUserId();
            var orders = from a in db.Orders.Include(o => o.Channel).Include(o => o.Post)
                where  a.Post.UserId == UserId
                select a;
            return View(await orders.ToListAsync());
        }


        // GET: Orders
        public async Task<ActionResult> GetOrdersToMyChannels()
        {
            
            var orders = from a in db.Orders.Include(o => o.Channel).Include(o => o.Post)
                where a.Renouncement == false
                select a;

            return View(await orders.ToListAsync());
        }




        // POST: Orders/Create
        [HttpPost]
        public async Task<ActionResult> Create(Order order)
        {

            
            if (ModelState.IsValid)
            {
                order.DatePost = DateTime.Now;

                db.Orders.Add(order);
                await db.SaveChangesAsync();

                string UserId = User.Identity.GetUserId();
                User user = await UserManager.FindByEmailAsync(User.Identity.Name);
                
                user.Balance = user.Balance - order.Cost;
                await UserManager.UpdateAsync(user);
               

                return RedirectToAction("Index", "Home");
            }


            return RedirectToAction("Index", "Home");


        }



        [HttpGet]
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            Order order = await db.Orders.FindAsync(id);
            if (order == null)
            {
                return HttpNotFound();
            }
            User user = await UserManager.FindByEmailAsync(User.Identity.Name);
            user.Balance += order.Cost;
            await UserManager.UpdateAsync(user);

            db.Orders.Remove(order);
            await db.SaveChangesAsync();

            return RedirectToAction("Index");
        }



        
        [HttpGet]
        public async Task<ActionResult> ViewСheck(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }


            List<Order> orders =( from a in db.Orders.Include(o => o.Channel).Include(o => o.Post)
                where a.Id == id
                select a).ToList();

            Order order = orders.First();
            if (order == null)
            {
                return HttpNotFound();
            }
            ViewBag.User = await UserManager.FindByEmailAsync(User.Identity.Name);
            return View(order);
        }

        
        [HttpGet]
        public async Task<ActionResult> SalesReceipt(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            List<Order> orders = (from a in db.Orders.Include(o => o.Channel).Include(o => o.Post)
                where a.Id == id
                select a).ToList();

            Order order = orders.First();
            if (order == null)
            {
                return HttpNotFound();
            }
            ViewBag.User = await UserManager.FindByEmailAsync(User.Identity.Name);
            return View(order);
        }


        [HttpGet]
        public async Task<ActionResult> AdminPosted(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            Order order = await db.Orders.FindAsync(id);
            if (order == null)
            {
                return HttpNotFound();
            }

            order.IsDone = true;
            db.Entry(order).State = EntityState.Modified;
            await db.SaveChangesAsync();

            return RedirectToAction("GetOrdersToMyChannels");
        }




        [HttpGet]
        public async Task<ActionResult> ConfirmAdvert(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            Order order = await db.Orders.FindAsync(id);
            if(order==null)
            {
                return HttpNotFound();
            }
            
            User user = await UserManager.FindByEmailAsync(User.Identity.Name);
            user.Balance += order.Cost;
            await UserManager.UpdateAsync(user);
            order.DealCompleted = true;
            db.Entry(order).State = EntityState.Modified;
            await db.SaveChangesAsync();

            return RedirectToAction("Index");
        }





        // GET: Orders/DeleteOrderToChannel/
        public async Task<ActionResult> DeleteOrderToChannel(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            Order order = await db.Orders.FindAsync(id);
            if (order == null)
            {
                return HttpNotFound();
            }

            order.Renouncement = true;
            db.Entry(order).State = EntityState.Modified;
            await db.SaveChangesAsync();

            return RedirectToAction("GetOrdersToMyChannels");
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
