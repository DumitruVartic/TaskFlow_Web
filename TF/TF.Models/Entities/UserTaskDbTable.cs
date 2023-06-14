using System.ComponentModel.DataAnnotations;

namespace TF.Models.Entities
{
    public class UserTaskDbTable
    {
        [Key]
        public Guid UserId { get; set; }
        public Guid TaskId { get; set; }
    }
}
