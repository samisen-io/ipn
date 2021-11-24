using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using server.Models;
using server.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace server.Controllers;
[Authorize]
[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{

  private readonly ILogger<UserController> _logger;
  private readonly IUserService _userDBService;

  public UserController(ILogger<UserController> logger, IUserService userService)
  {
    _userDBService = userService;
    _logger = logger;
  }

  [HttpGet]
  public async Task<IEnumerable<User>> Get()
  {
    return await _userDBService.FindAll();
  }

  [AllowAnonymous]
  [HttpPost("authenticate")]
  public async Task<ActionResult<User>> Authenticate([FromBody] Authenticate model)
  {
     
  var user = await _userDBService.Authenticate(model.Username, model.Password);

    if (user == null)
      return BadRequest(new { message = "Username or password is incorrect" });

    return Ok(user);
  }


  [HttpGet("{id}", Name = "FindUser")]
  public async Task<ActionResult<User>> Get(int id)
  {
    var result = await _userDBService.FindOne(id);
    if (result != default)
      return Ok(result);
    else
      return NotFound();
  }

  [AllowAnonymous]
  [HttpPost]
  public async Task<ActionResult<User>> Insert(User dto)
  {
 
    var id = await _userDBService.Insert(dto);
    if (id != default)
      return CreatedAtRoute("FindUser", new { id = id }, dto);
    else
      return BadRequest();
  }

  [HttpPut]
  public async Task<ActionResult<User>> Update(User dto)
  {
    if (dto.id <= 0)
    {
      return BadRequest("Id should be set for insert action.");
    }

    var result = await _userDBService.Update(dto);
    if (result > 0)
      return NoContent();
    else
      return NotFound();
  }

  [HttpDelete("{id}")]
  public async Task<ActionResult<User>> Delete(int id)
  {
    var result = await _userDBService.Delete(id);
    if (result > 0)
      return NoContent();
    else
      return NotFound();
  }
}