namespace Nexus.Api.Data.Entities {
  public abstract class AuditEntity {
    public int Id { get; set; }

    public Guid CreatedById { get; set; }
    public DateTime CreatedOn { get; set; }

    public Guid LastModifiedById { get; set; }
    public DateTime LastModifiedOn { get; set; }
  }
}
