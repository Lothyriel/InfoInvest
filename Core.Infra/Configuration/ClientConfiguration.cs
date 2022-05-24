using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Users.Model.Client;

namespace Core.Infra.Configuration
{
    internal class ClientConfiguration : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.HasKey(e => e.Id);

            builder.HasMany(e => e.Investments).WithOne();

            builder.Property(e => e.Name).IsRequired();

            builder.Property(e => e.BirthDate).IsRequired();
        }
    }
}