using System.Collections.Generic;

namespace KooliProjekt.Application.Data
{
    public class ToDoList
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<ToDoItem> Items { get; set; } = new List<ToDoItem>();
    }
}