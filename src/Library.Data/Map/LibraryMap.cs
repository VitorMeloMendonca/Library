using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace Library.Data.Map
{
    internal sealed class LibraryMap : EntityTypeConfiguration<Entity.Library>
    {
        public LibraryMap()
        {
            ToTable("Library");

            HasKey(p => p.LibraryID)
                .Property(p => p.LibraryID).HasColumnName("LibraryID")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(p => p.Name)
                .HasColumnName("Name")
                .IsRequired();
        }
    }
}