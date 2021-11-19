using Microsoft.AspNetCore.Mvc;
using server.Models;
using server.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace server.Controllers;
[ApiController]
[Route("[controller]")]
public class PostCommentController : ControllerBase
{

  private readonly ILogger<PostCommentController> _logger;
  private readonly IPostCommentService _PostCommentDBService;

  public PostCommentController(ILogger<PostCommentController> logger, IPostCommentService postService)
  {
    _PostCommentDBService = postService;
    _logger = logger;
  }

  [HttpGet]
  public async Task<IEnumerable<PostComment>> Get()
  {
    return await _PostCommentDBService.FindAll();
  }

  [HttpGet("{id}", Name = "FindPostComment")]
  public async Task<ActionResult<PostComment>> Get(int id)
  {
    var result = await _PostCommentDBService.FindOne(id);
    if (result != default)
      return Ok(result);
    else
      return NotFound();
  }

  [HttpPost]
  public async Task<ActionResult<PostComment>> Insert(PostComment dto)
  {
 
    var id = await _PostCommentDBService.Insert(dto);
    if (id != default)
      return CreatedAtRoute("FindOne", new { id = id }, dto);
    else
      return BadRequest();
  }

  [HttpPut]
  public async Task<ActionResult<PostComment>> Update(PostComment dto)
  {
    if (dto.id <= 0)
    {
      return BadRequest("Id should be set for insert action.");
    }

    var result = await _PostCommentDBService.Update(dto);
    if (result > 0)
      return NoContent();
    else
      return NotFound();
  }

  [HttpDelete("{id}")]
  public async Task<ActionResult<Post>> Delete(int id)
  {
    var result = await _PostCommentDBService.Delete(id);
    if (result > 0)
      return NoContent();
    else
      return NotFound();
  }
}