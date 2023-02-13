namespace Xtra.Models.Settings;

public record CommonSettingsBase
{
    public string? KeyVault { get; set; }
    public AADSettings AAD { get; set; } = new();
}