using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.Security;
using System.Linq;
using PlazmaBurstMMO.Models;

namespace PlazmaBurstMMO.Controllers
{
    [Route("api/GetMoney")]
    [ApiController]
    public class SendToController : ControllerBase
    {
        public IActionResult GetMoneyResponse([FromHeader] PBData pb2data) => Ok("Awesome! I love you mister " + pb2data.user_login);
    }

}
