using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;
using System.Xml.Linq;
using Project_Sem_3_Crawl_News.Models;

namespace Project_Sem_3_Crawl_News.Controllers
{
    public class RSSFeedController : Controller
    {
        // GET: RSSFeed
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string RSSURL)
        {
            try
            {
                WebClient wclient = new WebClient();
                string RSSData = wclient.DownloadString(RSSURL);
                var xml = XDocument.Parse(RSSData);
                var RSSFeedData = (from x in xml.Descendants("item")
                    select new RSSFeed
                    {
                        //Title = (string)x.Element("title") != null ? Regex.Match(x.Element("title").Value, @"^.{1,180}\b(?<!\s)").Value : "",
                        Title = (string)x.Element("title").Value,
                        Link = ((string)x.Element("link").Value),
                        Description = Regex.Match(x.Element("description").Value, @"^.{1,180}\b(?<!\s)").Value,
                        PubDate = ((string)x.Element("pubDate"))
                    });
                Console.WriteLine(RSSFeedData + "aaaaaaaaaaaaaa");
                ViewBag.RSSFeed = RSSFeedData;

                ViewBag.URL = RSSURL;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + "error");
            }

            return View();
        }
    }
}