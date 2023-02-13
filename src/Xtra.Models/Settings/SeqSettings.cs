namespace Xtra.Models.Settings;

public record SeqSettings
{
    public bool Enabled { get; set; }
    public string? ServerUrl { get; set; }
    public string? ApiKey { get; set; }
}