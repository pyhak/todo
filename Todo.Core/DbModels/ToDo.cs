using System;
using System.Collections.Generic;
using System.Text;

namespace ToDo.Core.DbModels
{
    public class ToDo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<ToDoItem> Items { get; set; }
    }
}
