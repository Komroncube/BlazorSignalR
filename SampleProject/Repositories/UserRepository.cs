using BlazorSignalR.Data;
using BlazorSignalR.Models;
using SampleProject.Exceptions;

namespace BlazorSignalR.Repositories;

public class UserRepository : IUserRepository
{
    private readonly ApplicationDbContext _dbContext;

    public UserRepository(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public User AddUser(User user)
    {
        var check = _dbContext.Users.FirstOrDefault(u => u.Id == user.Id);
        if (check is not null) 
        {
            throw new DublicateKeyExceptions();
        }
        var entry = _dbContext.Users.Add(user);
        _dbContext.SaveChanges();
        return entry.Entity;
    }

    public IEnumerable<User> GetUsers()
    {
        return _dbContext.Users;
    }
}
