using Assets.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Core.Infra.Configuration
{
    internal class AssetConfiguration : IEntityTypeConfiguration<Asset>
    {
        public void Configure(EntityTypeBuilder<Asset> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Group).IsRequired();

            builder.Property(e => e.Name).IsRequired();
        }
    }
}