using System;

namespace ToDoList.Data.Models
{
    public class ToDoItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsCompleted { get; set; }
        public DateTime LastChange { get; set; }
        
        public int ToDoId { get; set; }
        public ToDo ToDoList { get; set; }
    }
}