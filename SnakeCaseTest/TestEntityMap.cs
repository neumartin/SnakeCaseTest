using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeCaseTest
{
    public class TestEntityMap
    {
        public TestEntityMap(EntityTypeBuilder<TestEntity> entityBuilder)
        {
            //Table
            entityBuilder.ToTable("TestEntities");

            //Primary Key
            entityBuilder.HasKey(e => e.Id);

            //Properties
            entityBuilder.Property(e => e.Name).HasMaxLength(400);

            //Relations

            //Indexs
            entityBuilder.HasIndex(e => new { e.IdEmpresa, e.Codigo });
        }
    }
}
