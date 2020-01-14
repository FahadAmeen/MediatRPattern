using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediatRPattern.Models
{
    public class NotificationMessage:INotification
    {
        public string NotifyText { get; set; }
    }
}
