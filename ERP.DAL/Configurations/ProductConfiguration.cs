using ERP.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ERP.DAL.Configurations;

public class ProductConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        #region Primary Key

        builder.HasKey(x => x.ProductId);
        builder.Property(x => x.ProductId).UseIdentityColumn();

        #endregion

        #region Columns

        builder.Property(x => x.ProductName).HasMaxLength(16).IsRequired();

        #endregion
    }
}