using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace rabbitMQReceive
{
    public class ExecuteParams
    {
        public string ConnectionString { get; set; }
        public string Queue { get; set; }
    }
}