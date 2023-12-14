using BlazorSignalR.Models;

namespace BlazorSignalR.Repositories;

public interface IUserRepository
{
    public IEnumerable<User> GetUsers();
    public User AddUser(User user);
}
