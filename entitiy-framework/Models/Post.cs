using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace entitiy_framework.Models
{
    public class Post
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public int AuthorId { get; set; }
        public string Title { get; set; }
        public int Summary { get; set; }
        public string Body { get; set; }
        public string Slug { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastUpdateDate { get; set; }
    }
}