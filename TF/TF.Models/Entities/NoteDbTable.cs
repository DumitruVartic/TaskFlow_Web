using System.ComponentModel.DataAnnotations;

namespace TF.Models.Entities
{
    public class NoteDbTable
    {
        [Key]
        public Guid Id { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string? Title { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string? Content { get; set; }
    }
}
