using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Transactions.Model;

namespace Core.Infra.Configuration
{
    internal class InvestmentConfiguration : IEntityTypeConfiguration<Investment>
    {
        public void Configure(EntityTypeBuilder<Investment> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Value).IsRequired();

            builder.HasOne(e => e.Asset);
        }
    }
}