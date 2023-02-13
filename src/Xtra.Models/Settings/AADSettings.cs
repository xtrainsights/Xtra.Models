using System.Security.Cryptography.X509Certificates;


namespace Xtra.Models.Settings;

public class AADSettings
{
    public string? TenantId { get; set; }
    public string? ClientId { get; set; }
    public string? ClientSecret { get; set; }
    public string? CertThumbprint { get; set; }
    public X509Certificate2? Cert { get; set; }
    public bool Interactive { get; set; } = false;
}