namespace Unleash.Api.Configuration;

public record UnleashClientSettings
{
    public string? ApplicationName { get; init; }
    public string? BaseAddress { get; init; }
    public string? AuthToken { get; init; }
}
