using Domain.Entities;
using System.Text.Json.Serialization;

namespace Application.Features.Users.Dto;

public class UserDto
{
    public Guid Id { get; set; }
    public string Role { get; set; } = "User";
    [JsonPropertyName("username")]
    public string UserName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    [JsonPropertyName("password")]
    public string PasswordHash { get; set; } = string.Empty;

    public UserDto MapUserToDto(User user)
    {
        return new UserDto
        {
            Id = user.Id,
            UserName = user.UserName,
            Email = user.Email,
            Role = user.Role,
            PasswordHash = user.PasswordHash
        };
    }
}
