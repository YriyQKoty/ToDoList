using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ToDoList.Data.Models.EntityConfigurations
{
    public class ToDoItemConfiguration : IEntityTypeConfiguration<ToDoItem>
    {
        public void Configure(EntityTypeBuilder<ToDoItem> entity)
        {
            entity.HasKey(e => e.Id);

            entity.HasOne(e => e.ToDoList)
                .WithMany(td => td.Items);
        }
    }
}