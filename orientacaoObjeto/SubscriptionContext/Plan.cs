using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using orientacaoObjeto.SharedContext;

namespace orientacaoObjeto.SubscriptionContext
{
    public class Plan : Base
    {
        public string Title { get; set; }
        public decimal Price { get; set; }

    }
}