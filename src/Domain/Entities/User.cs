using Domain.Enums;
using Domain.Exceptions;

namespace Domain.Entities;

public class User
{
    public Guid Id { get; }
    public string UserName { get; }
    public string PasswordHash { get; }
    public string Email { get; }
    public string Role { get; }

    public User(Guid id, string userName, string password, string email, string role)
    {
        if (id == Guid.Empty)
        {
            throw new DomainException("Id is required!", DomainExceptionCodes.InvalidInput);
        }

        Id = id;
        UserName = userName ?? throw new DomainException("UserName is required!", DomainExceptionCodes.InvalidInput);
        PasswordHash = password ?? throw new DomainException("Password is required!", DomainExceptionCodes.InvalidInput);
        Email = email ?? throw new DomainException("Email is required!", DomainExceptionCodes.InvalidInput);
        Role = role ?? throw new DomainException("Role is required!", DomainExceptionCodes.InvalidInput);
    }
}