//using Domain.Entities;
//using Microsoft.EntityFrameworkCore;

//namespace Infrastructure.Persistence.Configuration;

//internal class PersonConfiguration : IEntityTypeConfiguration<Person>
//{
//    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Person> builder)
//    {
//        builder.ToTable("Person", "Person");
//        builder.HasKey(p => p.BusinessEntityID);
//        builder.Property(p => p.FirstName)
//            .IsRequired()
//            .HasMaxLength(50);

//        builder.HasMany(p => p.EmailAddresses);

//        builder.HasMany(p => p.PersonPhones);

//        builder.ToTable(tb => tb.UseSqlOutputClause(false));
//    }
//}
