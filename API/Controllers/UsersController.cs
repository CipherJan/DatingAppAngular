using APi.Services.Interface;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UsersController : ControllerBase
{
    private readonly IUserService _userService;

    public UsersController(IUserService userService)
    {
        _userService = userService;
    }

    [HttpGet]
    public async Task<IEnumerable<AppUser>> GetUsers()
    {
        return await _userService.GetUsersAsync();
    }

    [HttpGet("{id}")]
    public async Task<AppUser> GetUser(int id)
    {
        return await _userService.GetUserByIdAsync(id);
    }
}