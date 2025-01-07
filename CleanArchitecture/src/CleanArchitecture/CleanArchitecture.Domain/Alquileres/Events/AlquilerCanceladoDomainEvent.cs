using CleanArchitecture.Domain.Abractions;

namespace CleanArchitecture.Domain.Alquileres.Events;

public sealed record AlquilerCanceladoDomainEvent(Guid AlquilerID): IDomainEvent;