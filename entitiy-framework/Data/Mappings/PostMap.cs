using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using entitiy_framework.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace entitiy_framework.Data.Mappings
{
    public class PostMap : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            builder.ToTable("Post");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd()
                .UseIdentityColumn();
            builder.Property(x => x.LastUpdateDate)
                .IsRequired()
                .HasColumnName("LastUpdateDate")
                .HasColumnType("SMALLDATETIME")
                // .HasDefaultValueSql("GETDATE()");
                .HasDefaultValue(DateTime.Now.ToUniversalTime());
            builder.Property(x => x.Title)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnName("Title");
            builder.Property(x => x.Slug)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnName("Slug");
            builder.Property(x => x.CreateDate)
                .IsRequired()
                .HasColumnName("CreateDate")
                .HasColumnType("SMALLDATETIME")
                .HasDefaultValue(DateTime.Now.ToUniversalTime());
            builder.HasIndex(x => x.Slug, "IX_PostSlug")
                .IsUnique();

            // relacionamento
            builder.HasOne(x => x.Author)
                .WithMany(x => x.Posts)
                .HasConstraintName("FK_PostAuthor")
                .OnDelete(DeleteBehavior.Restrict);

            // relacionamento muito p muitos
            builder.HasMany(x => x.Tags)
                .WithMany(x => x.Posts)
                .UsingEntity<Dictionary<String, object>>(
                    "PostTag",
                    post => post.HasOne<Tag>()
                    .WithMany()
                    .HasForeignKey("PostId")
                    .HasConstraintName("FK_PostTag_PostId")
                    .OnDelete(DeleteBehavior.Restrict),
                    tag => tag.HasOne<Post>()
                    .WithMany()
                    .HasForeignKey("TagId")
                    .HasConstraintName("FK_PostTag_TagId")
                    .OnDelete(DeleteBehavior.Restrict)
                );

        }
    }
}