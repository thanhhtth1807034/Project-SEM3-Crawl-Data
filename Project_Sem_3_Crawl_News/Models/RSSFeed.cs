using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Project_Sem_3_Crawl_News.Models
{
    public class RSSFeed
    {
        [Key] public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Link { get; set; }
        public string Category { get; set; }
        public string PubDate { get; set; }
    }
}