using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace QSeconds.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TimeController : ControllerBase
    {
        // put implementation here
        [HttpGet]
        public IActionResult GetTime() {
            // todo: make this use a localization setting
            return Content(DateTime.UtcNow.ToString("HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture));
        }
    }
}