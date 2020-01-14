using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediatRPattern.Services
{
    public interface INotifierMediatrService
    {
        void Notify(string notifyText);
    }
}
