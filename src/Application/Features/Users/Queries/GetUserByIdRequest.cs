using Application.Common.Results;
using Application.Features.Users.Dto;
using MediatR;

namespace Application.Features.Users.Queries;

public class GetUserByIdRequest : IRequest<Result<UserDto>>
{
    public Guid Id { get; set; }

    public GetUserByIdRequest(Guid id)
    {
        Id = id;
    }
}
