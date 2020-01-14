using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatRPattern.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MediatRPattern.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        private readonly INotifierMediatrService _notifierMediatrService;

        public HomeController(INotifierMediatrService notifierMediatrService)
        {
            _notifierMediatrService = notifierMediatrService;
        }

        [HttpGet("")]
        public ActionResult<string> NotifyAll()
        {
            _notifierMediatrService.Notify("This is a test notification");
            return "Completed";
        }
    }
}
