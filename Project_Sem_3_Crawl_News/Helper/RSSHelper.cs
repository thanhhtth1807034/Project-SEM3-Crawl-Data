//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.Xml.Linq;
//using System.Xml.XPath;
//using Project_Sem_3_Crawl_News.Models;

//namespace Project_Sem_3_Crawl_News.Helper
//{
//    public class RSSHelper
//    {
//        public static List<News> read(string url)
//        {
//            string RSSFeedUrl = url;

//            List<News> listNews = new List<News>();
//            try
//            {
//                XDocument xDocument = new XDocument();
//                xDocument = XDocument.Load(RSSFeedUrl);
//                var items = (from x in xDocument.Descendants("news")
//                    select new
//                    {
//                        title = x.Element("title").Value,
//                        link = x.Element("link").Value,
//                        description = x.Element("description").Value,
//                        pubDate = x.Element("pubDate").Value
//                    });
//                if (items != null)
//                {
//                    foreach (var i in items)
//                    {
//                        News n = new News
//                        {
//                            Title = i.title,
//                            Link =  i.link,
//                            Description = i.description,
//                            PublistDate = i.pubDate
//                        };
//                        listNews.Add(n);
//                    }
//                }

//                //XPathDocument doc = new XPathDocument(url);
//                //XPathNavigator navigator = doc.CreateNavigator();
//                //XPathNodeIterator nodes = navigator.Select("//news");
//                //while (nodes.MoveNext())
//                //{
//                //    XPathNavigator node = nodes.Current;
//                //    listNews.Add(new News
//                //    {
//                //        Category = node.SelectSingleNode("category").Value,
//                //        Description = node.SelectSingleNode("description").Value,
//                //        Guid = node.SelectSingleNode("guid").Value,
//                //        Link = node.SelectSingleNode("link").Value,
//                //        Title = node.SelectSingleNode("title").Value,
//                //        PubDate = node.SelectSingleNode("pubDate").Value,

//                //    });
//                //}
//            }
//            catch 
//            {
//                listNews = null;
//            }

//            return listNews;
//        }
//    }
//}