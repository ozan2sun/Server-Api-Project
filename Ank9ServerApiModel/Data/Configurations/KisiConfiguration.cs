using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ank9ServerApiModel.Data.Configurations
{
    public class KisiConfiguration : IEntityTypeConfiguration<Kisi>
    {
        public void Configure(EntityTypeBuilder<Kisi> builder)
        {
            builder.Property(x => x.Id).IsRequired().UseIdentityColumn();
            builder.Property(x => x.Ad).IsRequired().HasMaxLength(20);
            builder.Property(x => x.Tc).IsRequired();
            builder.Property(x => x.Soyad).IsRequired().HasMaxLength(50);
            builder.Property(x => x.cinsiyet).HasConversion(new EnumToStringConverter<Cinsiyet>());
            builder.HasIndex(x => x.Tc).IsUnique();
            builder.HasKey(x => x.Id);
        }
    }
}
