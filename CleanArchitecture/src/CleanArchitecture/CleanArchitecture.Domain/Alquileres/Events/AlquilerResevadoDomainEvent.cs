using CleanArchitecture.Domain.Abractions;

namespace  CleanArchitecture.Domain.Alquileres.Events;

public sealed record AlquilerResevadoDomainEvent(Guid AlquilerId):IDomainEvent;