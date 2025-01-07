namespace CleanArchitecture.Domain.Abractions;

public record Error(string Code, string Name)
{
    public static Error None = new (string.Empty,string.Empty);
    public static Error NulllValue = new ("Error.NullValue","Un valor Null fue ingresado");

}