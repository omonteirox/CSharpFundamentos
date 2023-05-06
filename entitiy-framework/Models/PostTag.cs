using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace entitiy_framework.Models
{
    public class PostTag
    {
        public int PostId { get; set; }
        public int TagId { get; set; }
        public IList<User> Users { get; set; }
    }
}