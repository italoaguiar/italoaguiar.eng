using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Site.Model
{
    public class Article
    {
        public DateTime Date { get; set; }

        public string Title { get; set; }

        public string SubTitle { get; set; }

        public Author Author { get; set; }

        public string Url { get; set; }

        public string[] Tags { get; set; }

        public Category Category { get; set; }

        public string Image { get; set; }

        public string Html { get; set; }

        public bool IsActive { get; set; }
    }
}
