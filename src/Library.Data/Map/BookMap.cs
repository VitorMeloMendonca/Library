using Library.Data.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace Library.Data.Map
{
    internal sealed class BookMap : EntityTypeConfiguration<Book>
    {
        public BookMap()
        {
            ToTable("Book");

            HasKey(a => a.BookID)
                .Property(a => a.BookID)
                .HasColumnName("BookID")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(p => p.Title)
                .HasColumnName("Title")
                .IsRequired();

            this.HasOptional(a => a.Author)
                .WithMany()
                .HasForeignKey(a => a.AuthorID);
        }
    }
}