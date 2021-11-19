using Microsoft.AspNetCore.Mvc;
using server.Models;
using server.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace server.Controllers;
[ApiController]
[Route("[controller]")]
public class PostController : ControllerBase
{

  private readonly ILogger<PostController> _logger;
  private readonly IPostService _PostDBService;

  public PostController(ILogger<PostController> logger, IPostService postService)
  {
    _PostDBService = postService;
    _logger = logger;
  }

  [HttpGet]
  public async Task<IEnumerable<Post>> Get()
  {
    return await _PostDBService.FindAll();
  }

  [HttpGet("{id}", Name = "FindPost")]
  public async Task<ActionResult<Post>> Get(int id)
  {
    var result = await _PostDBService.FindOne(id);
    if (result != default)
      return Ok(result);
    else
      return NotFound();
  }

  [HttpPost]
  public async Task<ActionResult<Post>> Insert(Post dto)
  {
   
    var id = await _PostDBService.Insert(dto);
    if (id != default)
      return CreatedAtRoute("FindOne", new { id = id }, dto);
    else
      return BadRequest();
  }

  [HttpPut]
  public async Task<ActionResult<Post>> Update(Post dto)
  {
    if (dto.id <= 0)
    {
      return BadRequest("Id should be set for insert action.");
    }

    var result = await _PostDBService.Update(dto);
    if (result > 0)
      return NoContent();
    else
      return NotFound();
  }

  [HttpDelete("{id}")]
  public async Task<ActionResult<Post>> Delete(int id)
  {
    var result = await _PostDBService.Delete(id);
    if (result > 0)
      return NoContent();
    else
      return NotFound();
  }
}