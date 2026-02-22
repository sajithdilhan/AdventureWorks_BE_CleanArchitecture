using Application.Interfaces;
using Domain.Entities;
using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Infrastructure.Repositories;

internal class UserRepository(ApplicationDbContext dbContext, ILogger<UserRepository> logger) : IUserRepository
{
    public async Task<User?> GetUserByEmailAsync(string email) => await dbContext.Users.FirstOrDefaultAsync(u => u.Email == email);

    public async Task<User?> GetUserByIdAsync(Guid id) => await dbContext.Users.FindAsync(id);

    public async Task<User?> GetUserByUserNameAsync(string userName) => await dbContext.Users.FirstOrDefaultAsync(u => u.UserName == userName);

    public async Task AddUserAsync(User user)
    {
        try
        {
            await dbContext.Users.AddAsync(user);
            await dbContext.SaveChangesAsync();
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "Error occurred while adding user");
            throw;
        }

    }

    public async Task<User> UpdateUserAsync(User user)
    {
        try
        {
            dbContext.Users.Update(user);
            await dbContext.SaveChangesAsync();
            return user;
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "Error occurred while updating user");
            throw;
        }
    }
    public async Task<bool> DeleteUserAsync(Guid id)
    {
        try
        {
            var user = await dbContext.Users.FindAsync(id);
            if (user == null)
                return false;
            dbContext.Users.Remove(user);
            await dbContext.SaveChangesAsync();
            return true;
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "Error occurred while deleting user");
            throw;
        }
       
    }
}
