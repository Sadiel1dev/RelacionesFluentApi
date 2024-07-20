using System.Collections.Immutable;
using Core.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructura.Data.Config
{
    public class ClienteConfig : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
          builder.HasMany(x=>x.Items).WithOne(x=>x.Cliente).HasForeignKey(x=>x.ClienteId);
          builder.HasOne(x=>x.Usuario).WithOne(x=>x.Cliente).HasForeignKey<Usuario>(x=>x.ClienteId);
        }
    }
}
