using CleanArchitecture.Domain.Abractions;

namespace CleanArchitecture.Domain.Reviews;

public static class ReviewErrors
{

    public static readonly Error NotEligible = new(
        "Review.NotElegible",
        "Este review y calificacion para el auto no es elegible porque aun no se completa el alquiler"
    ) ;
}