using CleanArchitecture.Application.Abstractions.Messaging;

namespace CleanArchitecture.Application.Vehiculos.SearchVeahiculos;

public record SearchVehiculosQuery(
    DateOnly fechaInicio,
    DateOnly fechaFin
):IQuery<IReadOnlyList<VehiculoResponse>>;
