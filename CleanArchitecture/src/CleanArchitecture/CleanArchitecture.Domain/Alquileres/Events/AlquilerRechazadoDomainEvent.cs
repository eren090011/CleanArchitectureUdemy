using CleanArchitecture.Domain.Abractions;

namespace CleanArchitecture.Domain.Alquileres.Events;

public sealed record AlquilerRechazadoDomainEvent(Guid id): IDomainEvent;