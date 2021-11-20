using Microsoft.AspNetCore.Mvc;
using server.Models;
using server.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace server.Controllers;

[ApiController]
[Route("[controller]")]
public class MediaController : ControllerBase
{

  private readonly ILogger<MediaController> _logger;
  private readonly IMediaService _MediaDBService;

  public MediaController(ILogger<MediaController> logger, IMediaService MediaService)
  {
    _MediaDBService = MediaService;
    _logger = logger;
  }

  [HttpGet]
  public async Task<IEnumerable<Media>> Get()
  {
    return await _MediaDBService.FindAll();
  }

  [HttpGet("{id}", Name = "FindMedia")]
  public async Task<ActionResult<Media>> Get(int id)
  {
    var result = await _MediaDBService.FindOne(id);
    if (result != default)
      return Ok(result);
    else
      return NotFound();
  }

  [HttpPost]
  public async Task<ActionResult<Media>> Insert(Media dto)
  {
   
    var id = await _MediaDBService.Insert(dto);
    if (id != default)
      return CreatedAtRoute("FindOne", new { id = id }, dto);
    else
      return BadRequest();
  }

  [HttpPut]
  public async Task<ActionResult<Media>> Update(Media dto)
  {
    if (dto.id <= 0)
    {
      return BadRequest("Id should be set for insert action.");
    }

    var result = await _MediaDBService.Update(dto);
    if (result > 0)
      return NoContent();
    else
      return NotFound();
  }

  [HttpDelete("{id}")]
  public async Task<ActionResult<Media>> Delete(int id)
  {
    var result = await _MediaDBService.Delete(id);
    if (result > 0)
      return NoContent();
    else
      return NotFound();
  }
}