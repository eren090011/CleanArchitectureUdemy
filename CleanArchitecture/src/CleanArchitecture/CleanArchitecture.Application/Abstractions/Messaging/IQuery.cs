using CleanArchitecture.Domain.Abractions;
using MediatR;

namespace CleanArchitecture.Application.Abstractions.Messaging;

public interface IQuery<TResponse> : IRequest<Result<TResponse>>
{
    
}
