using Application.Common.Enums;
using Application.Common.Results;
using Application.Features.Users.Dto;
using Application.Features.Users.Queries;
using Application.Interfaces;
using MediatR;
using Microsoft.Extensions.Logging;

namespace Application.Features.Users.Handlers;

public class GetUserByIdHandler(IUserRepository userRepository, ILogger<GetUserByIdHandler> logger) : IRequestHandler<GetUserByIdRequest, Result<UserDto>>
{
    public async Task<Result<UserDto>> Handle(GetUserByIdRequest request, CancellationToken cancellationToken)
    {
        var user = await userRepository.GetUserByIdAsync(request.Id);
        if (user is null)
        {
            logger.LogInformation("User not found for Id:{UserId}", request.Id);
            return Result<UserDto>.Failure(ErrorType.NotFound);
        }

        logger.LogInformation("User found for Id:{UserId}", request.Id);
        var userDto = new UserDto().MapUserToDto(user);
        return Result<UserDto>.Success(userDto);
    }
}
