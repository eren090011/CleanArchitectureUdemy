using CleanArchitecture.Domain.Abractions;

namespace CleanArchitecture.Domain.Vehiculos;

public static class VehiculoErrors
{
    public static Error NotFound = new(
        "Vehiculo.Found",
        "No existe un vehiculo coneste id"
    );
}