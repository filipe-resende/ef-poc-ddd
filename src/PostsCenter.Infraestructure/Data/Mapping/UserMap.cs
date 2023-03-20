﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PostsCenter.Domain.Entities;

namespace PostsCenter.Infraestructure.Data.Mapping
{
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Name);
            builder.Property(p => p.CreatedAt).HasDefaultValueSql("getdate()");
            builder.Property(p => p.Active).HasDefaultValue(true);
        }
    }
}
