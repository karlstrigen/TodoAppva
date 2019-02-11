using System;
//This model checks whether or not a given ID is present in the database.
namespace MvcTodoAppva.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}