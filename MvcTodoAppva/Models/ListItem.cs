using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

//This is the model for the items on the to do list, and as such it also describes the attributes which will be stored in the database
//for each list entry.
namespace MvcTodoAppva.Models
{
    public class ListItem
    {
        public int ID { get; set; }

        [Display(Name = "What to do")]
        public string Text { get; set; }

        [Display(Name = "When to do it")]
        [DataType(DataType.Date)]
        public DateTime DoneDate { get; set; }
    }
}
