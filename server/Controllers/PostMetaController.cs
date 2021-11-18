using Microsoft.AspNetCore.Mvc;
using server.Models;
using server.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace server.Controllers;
[ApiController]
[Route("[controller]")]
public class PostMetaController : ControllerBase
{

  private readonly ILogger<PostMetaController> _logger;
  private readonly IPostMetaService _PostMetaDBService;

  public PostMetaController(ILogger<PostMetaController> logger, IPostMetaService postMetaService)
  {
        _PostMetaDBService = postMetaService;
    _logger = logger;
  }

  [HttpGet]
  public async Task<IEnumerable<PostMeta>> Get()
  {
    return await _PostMetaDBService.FindAll();
  }

  [HttpGet("{id}", Name = "FindPostMeta")]
  public async Task<ActionResult<PostMeta>> Get(int id)
  {
    var result = await _PostMetaDBService.FindOne(id);
    if (result != default)
      return Ok(result);
    else
      return NotFound();
  }

  [HttpPost]
  public async Task<ActionResult<PostMeta>> Insert(PostMeta dto)
  {
    if (dto.id <= 0)
    {
      return BadRequest("Id cannot be set for insert action.");
    }

    var id = await _PostMetaDBService.Insert(dto);
    if (id != default)
      return CreatedAtRoute("FindOne", new { id = id }, dto);
    else
      return BadRequest();
  }

  [HttpPut]
  public async Task<ActionResult<PostMeta>> Update(PostMeta dto)
  {
    if (dto.id <= 0)
    {
      return BadRequest("Id should be set for insert action.");
    }

    var result = await _PostMetaDBService.Update(dto);
    if (result > 0)
      return NoContent();
    else
      return NotFound();
  }

  [HttpDelete("{id}")]
  public async Task<ActionResult<PostMeta>> Delete(int id)
  {
    var result = await _PostMetaDBService.Delete(id);
    if (result > 0)
      return NoContent();
    else
      return NotFound();
  }
}