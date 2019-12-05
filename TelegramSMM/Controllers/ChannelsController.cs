using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Security.Policy;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Newtonsoft.Json;
using TelegramSMM.Models;

namespace TelegramSMM.Controllers
{
    public class ChannelsController : Controller
    {
        private ApplicationContext db = new ApplicationContext();
        private const string BOT_KEY = "1038005960:AAE5qMw8hD1eiMCvukU6IQ3QizbfV3BAeow";

        // GET: Channels
        public async Task<ActionResult> Index()
        {
            var channels = db.Channels.Include(c => c.User);
            return View(await channels.ToListAsync());
        }

       

        

        // GET: Channels/Create
        public ActionResult Create()
        {
            
            return View();
        }



        // POST: Channels/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "UserName,PostPrice")] Channel channel)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var httpWebRequest = (HttpWebRequest) WebRequest.Create(
                        "https://api.telegram.org/bot" + BOT_KEY + "/getChat?chat_id=" + channel.UserName);
              

                httpWebRequest.ContentType = "text/json";
                httpWebRequest.Method = "GET";//Можно GET
                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                string photo_file="";
                using (var streamReader = new StreamReader( httpResponse.GetResponseStream()))
                {
                    //ответ от сервера
                    var result = streamReader.ReadToEnd();
                    //Сериализация
                    Item item =  JsonConvert.DeserializeObject<Item>(result);




                  
                    Channel ch = await db.Channels.FindAsync(item.Result.Id.ToString());
                    if (ch != null)
                    {
                        ModelState.AddModelError("", "This channel is not your(((");
                        return View(channel);
                    }

                    channel.Name = item.Result.Title;
                    channel.Id = item.Result.Id.ToString();
                    
                    channel.Type = item.Result.Type;
                    channel.Description = item.Result.Description;
                    channel.Link = "https://t.me/" + item.Result.Username;
                    if (item.Result.Photo != null)
                    {
                        photo_file = item.Result.Photo.Small_file_id;
                    }
                }

                if (photo_file != "" && photo_file != null)
                {
                    httpWebRequest = (HttpWebRequest)WebRequest.Create("https://api.telegram.org/bot" + BOT_KEY + "/getFile?file_id=" + photo_file);
                    httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                    string file_link = "";
                    using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                    {
                        //ответ от сервера
                        var result = streamReader.ReadToEnd();

                        //Сериализация
                        Item item = JsonConvert.DeserializeObject<Item>(result);
                        file_link = item.Result.File_path;
                    }

                    string url = "https://api.telegram.org/file/bot1038005960:AAE5qMw8hD1eiMCvukU6IQ3QizbfV3BAeow/" + file_link;
                    string fileName = Guid.NewGuid().ToString() + ".jpeg";
                    using (WebClient client = new WebClient())
                    {

                        client.DownloadFile(url, AppDomain.CurrentDomain.BaseDirectory + "Images/" + fileName);

                    }
                    channel.Image = fileName;

                }
                

                httpWebRequest = (HttpWebRequest)WebRequest.Create("https://api.telegram.org/bot" + BOT_KEY + "/getChatMembersCount?chat_id=" + channel.UserName);
                httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    //ответ от сервера
                    var result = streamReader.ReadToEnd();

                    //Сериализация
                    CountOfSubscribers item = JsonConvert.DeserializeObject<CountOfSubscribers>(result);
                    channel.CountOfSubscribers = item.Result;
                }

               
                channel.UserId = User.Identity.GetUserId();
                db.Channels.Add(channel);
                await db.SaveChangesAsync();
                }
                catch
                {
                    ModelState.AddModelError("", "We can not find your channel (((");
                    return View(channel);

                }
            }
            return RedirectToAction("Index");
        }


       



        [HttpPost]
        public async Task<ActionResult> Edit(Channel ch )
        {

            Channel channel = await db.Channels.FindAsync(ch.Id);
            if (channel == null)
            {
                return HttpNotFound();
            }

            channel.PostPrice = ch.PostPrice;
            db.Entry(channel).State = EntityState.Modified;
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

       

        // POST: Channels/Delete/5
        [HttpGet]
        public async Task<ActionResult> Delete(string id)
        {

            if (id == null|| id=="")
            {
                return HttpNotFound();
            }
            Channel channel = await db.Channels.FindAsync(id);
            if (channel.Image != null && channel.Image != "")
            {
                string deletePath = @"C:\Users\HP\source\repos\TelegramSMM\TelegramSMM\Images\" + channel.Image;
                System.IO.File.Delete(deletePath);
            }
            db.Channels.Remove(channel);
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

    class Item
    {
        public bool Ok { get; set; }
        public Result Result { get; set; }
    }

    class Result
    {
        public long Id { get; set; }
        public string Title { get; set; }

        public string Username { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public Photo Photo { get; set; }

        public string File_path { get; set; }
    }

    class Photo
    {
        public string Small_file_id { get; set; }
        public string Big_file_id { get; set; }
    }


    class CountOfSubscribers
    {
        public bool Ok { get; set; }
        public int Result { get; set; }
    }
}
