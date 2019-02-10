using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

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
