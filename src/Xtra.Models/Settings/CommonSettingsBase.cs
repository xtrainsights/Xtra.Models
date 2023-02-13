namespace Xtra.Models.Settings;

public class CommonSettingsBase
{
    public string? KeyVault { get; set; }
    public AADSettings AAD { get; set; } = new();
}