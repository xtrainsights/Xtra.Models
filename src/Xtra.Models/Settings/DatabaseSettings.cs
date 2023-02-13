namespace Xtra.Models.Settings;

public record DatabaseSettings
{
    public string? ConnectionString { get; set; }
    public DatabasePlatform Platform { get; set; }
}