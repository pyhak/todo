using Microsoft.EntityFrameworkCore;
using ToDo.Core;

namespace ToDo.Data
{
    public class ApiContext : DbContext
    {
        public ApiContext(DbContextOptions<ApiContext> options)
            : base(options)
        {
        }
        public DbSet<ToDo.Core.DbModels.ToDo> ToDo { get; set; }
        public DbSet<ToDo.Core.DbModels.ToDoItem> Item { get; set; }
    }
}
