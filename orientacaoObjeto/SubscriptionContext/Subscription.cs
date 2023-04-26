using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using orientacaoObjeto.SharedContext;

namespace orientacaoObjeto.SubscriptionContext
{
    public class Subscription : Base
    {
        public Plan Plan { get; set; }
        public User User { get; set; }

        public DateTime? endDate { get; set; }

        public bool isInactive => endDate <= DateTime.Now;
    }
}