using MediatR;
using MediatRPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediatRPattern.Services
{
    public class NotifierMediatrService : INotifierMediatrService
    {
        private readonly IMediator _mediator;
        public NotifierMediatrService(IMediator mediator)
        {
            _mediator = mediator;
        }
        public void Notify(string notifyText)
        {
            _mediator.Publish(new NotificationMessage { NotifyText = notifyText });
        }
    }
}
