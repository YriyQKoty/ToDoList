using System.Linq;
using ToDoList.Data.DTO;
using ToDoList.Data.Models;

namespace ToDoList.Extensions
{
    public static class ModelsExtensions
    {
        public static ToDoDto MapToDto(this ToDo toDo)
        {
            return new ToDoDto()
            {
                Id = toDo.Id,
                Name = toDo.Name,
                DateCreated = toDo.DateCreated,
                LastChange = toDo.LastChange,
                Items = toDo.Items.Select(d => d.MapToDto()).ToList()
            };
        }

        public static ToDoItemDto MapToDto(this ToDoItem toDoItem)
        {
            return new ToDoItemDto()
            {
                Id = toDoItem.Id,
                Name = toDoItem.Name,
                LastChange = toDoItem.LastChange,
                IsCompleted = toDoItem.IsCompleted,
                ToDoListId = toDoItem.ToDoId
            };
        }
    }
}