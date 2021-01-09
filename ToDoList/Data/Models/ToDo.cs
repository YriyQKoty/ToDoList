using System;
using System.Collections.Generic;

namespace ToDoList.Data.Models
{
    public class ToDo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime LastChange { get; set; }
        
        public IEnumerable<ToDoItem> Items { get; set; }
    }
}