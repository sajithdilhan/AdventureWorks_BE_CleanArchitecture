using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence.Configuration;

internal class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<User> builder)
    {
        builder.ToTable("User", "Identity");
        builder.HasKey(u => u.Id);
        builder.Property(u => u.UserName)
            .IsRequired()
            .HasMaxLength(50);
        builder.Property(u => u.PasswordHash)
            .IsRequired()
            .HasMaxLength(255);
        builder.Property(u => u.Email)
            .IsRequired()
            .HasMaxLength(255);
        builder.Property(u => u.Role)
            .IsRequired()
            .HasMaxLength(50);
        builder.ToTable(tb => tb.UseSqlOutputClause(false));
    }
}
