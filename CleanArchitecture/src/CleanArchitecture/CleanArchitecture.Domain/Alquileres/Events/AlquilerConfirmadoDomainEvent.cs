using CleanArchitecture.Domain.Abractions;

namespace CleanArchitecture.Domain.Alquileres.Events;
public sealed record AlquilerConfirmadoDomainEvent(Guid AlquilerId): IDomainEvent;