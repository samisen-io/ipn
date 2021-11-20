using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace server.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class IPFSController : ControllerBase
  {
    [HttpPost]
    public ActionResult Publish()
    {
        return BadRequest();
    }

    
  }
}
