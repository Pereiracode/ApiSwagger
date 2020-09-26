using ApiSwagger.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApiSwagger.Data.Mappings
{
    public class ToDoMapping : IEntityTypeConfiguration<ToDo>
    {
        public void Configure(EntityTypeBuilder<ToDo> builder)
        {
            builder.HasKey(t => t.Id);

            builder.Property(t => t.Name).IsRequired().HasColumnType("varchar(50)");
            builder.Property(t => t.IsComplete).IsRequired();

            builder.ToTable("Todos");
        }
    }
}
