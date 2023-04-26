using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace orientacaoObjeto.NotificationContext
{
    public sealed class Notification
    {
        public Notification(string property, string message)
        {
            Property = property;
            Message = message;
        }
        public Notification()
        {

        }
        public string Property { get; set; }
        public string Message { get; set; }

    }
}