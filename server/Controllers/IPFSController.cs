using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using server.Services;

namespace server.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class IPFSController : ControllerBase
  {
    private readonly ILogger<PostController> _logger;
    private readonly IPostService _PostDBService;

    public IPFSController(ILogger<PostController> logger, IPostService postService)
    {
      _PostDBService = postService;
      _logger = logger;
    }

    [HttpPost]
    public async Task<ActionResult> Publish(int postId)
    {
      if (postId > 0)
      {
        var post = await _PostDBService.FindOne(postId);

        return Ok();
      }
      else
      {
        return BadRequest();
      }
    }

    
  }
}
