namespace CleanArchitecture.Application.Abstractions.Clock;

public interface IDateTimerProvider
{
    DateTime currentTime{get;}
}