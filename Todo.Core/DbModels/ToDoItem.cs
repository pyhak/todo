using System;
using System.Collections.Generic;
using System.Text;

namespace ToDo.Core.DbModels
{
    public class ToDoItem
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public bool IsDone { get; set; }
    }
}
