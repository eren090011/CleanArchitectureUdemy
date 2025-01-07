using CleanArchitecture.Domain.Abractions;
using MediatR;

namespace CleanArchitecture.Application.Abstractions.Messaging;

public interface ICommand : IRequest<Result>, IBaseCommand
{
    
}

public interface ICommand<TRespons> : IRequest<Result<TRespons>> , IBaseCommand
{

}

public interface IBaseCommand{

}