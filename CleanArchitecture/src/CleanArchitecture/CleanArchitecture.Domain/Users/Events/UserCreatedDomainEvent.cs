using CleanArchitecture.Domain.Abractions;

namespace CleanArchitecture.Domain.Users.Events;

public sealed record UserCreateDomainEvent(Guid Id) : IDomainEvent
{
    

}