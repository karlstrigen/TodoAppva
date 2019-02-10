using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MvcTodoAppva.Models
{
    public class MvcTodoAppvaContext : DbContext
    {
        public MvcTodoAppvaContext (DbContextOptions<MvcTodoAppvaContext> options)
            : base(options)
        {
        }

        public DbSet<MvcTodoAppva.Models.ListItem> ListItem { get; set; }
    }
}
