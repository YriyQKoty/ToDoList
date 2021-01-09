using System;

namespace ToDoList.Data.DTO
{
    public class ToDoItemDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsCompleted { get; set; }
        public DateTime LastChange { get; set; }

        public int ToDoListId { get; set; }
    }
}