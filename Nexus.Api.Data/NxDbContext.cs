using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Nexus.Api.Data.Entities;

namespace Nexus.Api.Data {
  public class NxDbContext : IdentityDbContext<AspUser, AspRole, Guid> {
    public DbSet<SystemRecord> SystemRecords { get; set; } = null!;

    public DbSet<AspUser> AspUsers { get; set; } = null!;
    public DbSet<AspRole> AspRoles { get; set; } = null!;
  }
}
