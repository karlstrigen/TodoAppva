using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

//Created when scaffolding the ListItem model.
//This code takes care of the EF core functionality for the ListItem model. 
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
