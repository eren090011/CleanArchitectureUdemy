using CleanArchitecture.Domain.Abractions;

namespace CleanArchitecture.Domain.Reviews.Events;

public sealed record ReviewCreatedDomainEvent(Guid AlquilerId):IDomainEvent;