using Domain.Entities;
using Domain.ValueObjects;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence;

internal class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
{
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);

        base.OnModelCreating(modelBuilder);
    }

    //public DbSet<Person> Persons { get; set; }
    //public DbSet<Email> EmailAddresses { get; set; }
   // public DbSet<Phone> PersonPhones { get; set; }
   // public DbSet<PhoneNumberType> PhoneNumberTypes { get; set; }
    public DbSet<User> Users { get; set; }
}
