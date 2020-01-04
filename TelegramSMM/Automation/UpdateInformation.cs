using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using Newtonsoft.Json;
using Quartz;
using TelegramSMM.Controllers;
using TelegramSMM.Models;

namespace TelegramSMM.Automation
{
    public class UpdateInformation : IJob
    {
        private ApplicationContext db = new ApplicationContext();
        private const string BOT_KEY = "1038005960:AAE5qMw8hD1eiMCvukU6IQ3QizbfV3BAeow";
        public async Task Execute(IJobExecutionContext context)
        {
            foreach (var a in db.Channels)
            {
                var httpWebRequest = (HttpWebRequest)WebRequest.Create(
                "https://api.telegram.org/bot" + BOT_KEY + "/getChat?chat_id=" + a.Id);
               /* if (a.Image != null && a.Image != "")
                {
                    string deletePath = @"C:\Users\HP\source\repos\TelegramSMM\TelegramSMM\Images\" + a.Image;
                    System.IO.File.Delete(deletePath);
                }*/
                httpWebRequest.ContentType = "text/json";
                httpWebRequest.Method = "GET";//Можно GET
                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                string photo_file = "";
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    //ответ от сервера
                    var result = streamReader.ReadToEnd();
                    //Сериализация
                    Item item = JsonConvert.DeserializeObject<Item>(result);

                    a.Name = item.Result.Title;
                    a.UserName = "@" + item.Result.Username;
                    a.Type = item.Result.Type;
                    a.Description = item.Result.Description;
                    a.Link = "https://t.me/" + item.Result.Username;

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
                    a.Image = fileName;
                }
                httpWebRequest = (HttpWebRequest)WebRequest.Create("https://api.telegram.org/bot" + BOT_KEY + "/getChatMembersCount?chat_id=" + a.Id);
                httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    //ответ от сервера
                    var result = streamReader.ReadToEnd();

                    //Сериализация
                    CountOfSubscribers item = JsonConvert.DeserializeObject<CountOfSubscribers>(result);
                    a.CountOfSubscribers = item.Result;
                }

                db.Entry(a).State = EntityState.Modified;
            }
            await db.SaveChangesAsync();
        }
        public void Dispose() { }
    }
}



