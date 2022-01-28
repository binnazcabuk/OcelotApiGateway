using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace WCustomerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        public IActionResult Get()
        {
            return Ok(new List<string> {
            "Hilmi", "Hüseyin", "Rıfkı", "Necati", "Şuayip", "Muallim", "Muiddin"
         });
        }
    }
}
