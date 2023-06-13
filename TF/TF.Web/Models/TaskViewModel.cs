using System.ComponentModel.DataAnnotations;

namespace TF.Web.Models
{
    public class TaskViewModel
    {
        public Guid Id { get; set; }

        public string? Title { get; set; }

        [DataType(DataType.Date)]
        public DateTime Deadline { get; set; }

        public string? Content { get; set; }
    }
}
