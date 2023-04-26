using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using orientacaoObjeto.SharedContext;

namespace orientacaoObjeto.SubscriptionContext
{
    public class User : Base
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}