using System.ComponentModel.DataAnnotations;

namespace TF.Models.Entities
{
    public class UserNoteDbTable
    {
        [Key]
        public Guid UserId { get; set; }
        public Guid NoteId { get; set; }

    }
}
