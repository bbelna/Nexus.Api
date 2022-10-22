namespace Nexus.Api.Data.Entities {
  public class SystemRecord : AuditEntity {
    public string Key { get; set; } = string.Empty;
    public string Value { get; set; } = string.Empty;
  }
}