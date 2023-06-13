using System.ComponentModel.DataAnnotations;

namespace TF.Models.Entities
{
    public class TaskDbTable
    {
        [Key]
        public Guid Id { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string? Title { get; set; }

        [DataType(DataType.Date)]
        public DateTime Deadline { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string? Content { get; set; }
    }
}
