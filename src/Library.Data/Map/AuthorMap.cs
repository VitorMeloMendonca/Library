using Library.Data.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace Library.Data.Map
{
    internal sealed class AuthorMap : EntityTypeConfiguration<Author>
    {
        public AuthorMap()
        {
            ToTable("Author");

            HasKey(a => a.AuthorID)
                .Property(a => a.AuthorID)
                .HasColumnName("AuthorID")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(a => a.Name)
                .HasColumnName("Name")
                .IsRequired();
        }
    }
}