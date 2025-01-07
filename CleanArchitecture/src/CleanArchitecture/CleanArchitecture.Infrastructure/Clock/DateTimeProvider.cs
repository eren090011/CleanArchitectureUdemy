using CleanArchitecture.Application.Abstractions.Clock;

namespace CleanArchitecture.Infrastructure.Clock;

internal sealed class DateTimeProvider : IDateTimerProvider
{
    public DateTime currentTime => DateTime.UtcNow;
}