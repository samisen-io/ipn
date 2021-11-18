using Microsoft.AspNetCore.Mvc;
using server.Models;
using server.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace server.Controllers;
[ApiController]
[Route("[controller]")]
public class CategoryController : ControllerBase
{

  private readonly ILogger<CategoryController> _logger;
  private readonly ICategoryService _CategoryDBService;

  public CategoryController(ILogger<CategoryController> logger, ICategoryService categoryService)
  {
        _CategoryDBService = categoryService;
    _logger = logger;
  }

  [HttpGet]
  public async Task<IEnumerable<Category>> Get()
  {
    return await _CategoryDBService.FindAll();
  }

  [HttpGet("{id}", Name = "FindCategory")]
  public async Task<ActionResult<Category>> Get(int id)
  {
    var result = await _CategoryDBService.FindOne(id);
    if (result != default)
      return Ok(result);
    else
      return NotFound();
  }

  [HttpPost]
  public async Task<ActionResult<Category>> Insert(Category dto)
  {
    if (dto.id <= 0)
    {
      return BadRequest("Id cannot be set for insert action.");
    }

    var id = await _CategoryDBService.Insert(dto);
    if (id != default)
      return CreatedAtRoute("FindOne", new { id = id }, dto);
    else
      return BadRequest();
  }

  [HttpPut]
  public async Task<ActionResult<Category>> Update(Category dto)
  {
    if (dto.id <= 0)
    {
      return BadRequest("Id should be set for insert action.");
    }

    var result = await _CategoryDBService.Update(dto);
    if (result > 0)
      return NoContent();
    else
      return NotFound();
  }

  [HttpDelete("{id}")]
  public async Task<ActionResult<Category>> Delete(int id)
  {
    var result = await _CategoryDBService.Delete(id);
    if (result > 0)
      return NoContent();
    else
      return NotFound();
  }
}