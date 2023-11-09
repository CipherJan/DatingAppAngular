using API.Entities;

namespace APi.Services.Interface;

public interface IUserService
{
    Task<IEnumerable<AppUser>> GetUsersAsync ();
    Task<AppUser> GetUserByIdAsync(int id);
}