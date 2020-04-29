﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Test.Core.Entities;

namespace Test.Data.EntityConfiguration
{
    public class TestConfiguration : IEntityTypeConfiguration<TestModel>
    {
        public void Configure(EntityTypeBuilder<TestModel> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.IdentityNo).IsRequired().HasMaxLength(11);
            builder.Property(x => x.Name).IsRequired().HasMaxLength(100);
            builder.Property(x => x.SurName).IsRequired().HasMaxLength(100);
            builder.Property(x => x.BirthDate).IsRequired();
            builder.ToTable("Test");


        }
    }
}
