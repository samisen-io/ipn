using Microsoft.AspNetCore.Mvc;
using server.Models;
using server.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace server.Controllers;
[ApiController]
[Route("[controller]")]
public class PostCategoryController : ControllerBase
{

  private readonly ILogger<PostCategoryController> _logger;
  private readonly IPostCategoryService _PostCategoryDBService;

  public PostCategoryController(ILogger<PostCategoryController> logger, IPostCategoryService postService)
  {
        _PostCategoryDBService = postService;
    _logger = logger;
  }

  [HttpGet]
  public async Task<IEnumerable<PostCategory>> Get()
  {
    return await _PostCategoryDBService.FindAll();
  }

  [HttpGet("{id}", Name = "FindPost_Category")]
  public async Task<ActionResult<PostCategory>> Get(int id)
  {
    var result = await _PostCategoryDBService.FindOne(id);
    if (result != default)
      return Ok(result);
    else
      return NotFound();
  }

  [HttpPost]
  public async Task<ActionResult<PostCategory>> Insert(PostCategory dto)
  {
    if (dto.postId <= 0)
    {
      return BadRequest("Id cannot be set for insert action.");
    }

    var id = await _PostCategoryDBService.Insert(dto);
    if (id != default)
      return CreatedAtRoute("FindOne", new { id = id }, dto);
    else
      return BadRequest();
  }

  [HttpPut]
  public async Task<ActionResult<PostCategory>> Update(PostCategory dto)
  {
    if (dto.postId <= 0)
    {
      return BadRequest("Id should be set for insert action.");
    }

    var result = await _PostCategoryDBService.Update(dto);
    if (result > 0)
      return NoContent();
    else
      return NotFound();
  }

  [HttpDelete("{id}")]
  public async Task<ActionResult<PostCategory>> Delete(int id)
  {
    var result = await _PostCategoryDBService.Delete(id);
    if (result > 0)
      return NoContent();
    else
      return NotFound();
  }
}