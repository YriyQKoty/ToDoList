using System;
using System.Collections.Generic;
using ToDoList.Data.Models;

namespace ToDoList.Data.DTO
{
    public class ToDoDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime LastChange { get; set; }
        
        public IEnumerable<ToDoItemDto> Items { get; set; }
        
    }
}