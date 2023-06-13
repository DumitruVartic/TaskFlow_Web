using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static TF.Models.Enums.Role;

namespace TF.Models.Entities
{
    internal class UserDbModel
    {
        public Guid Id { get; set; }
        public URoles Role { get; set; } = URoles.user;
        
        [Required(AllowEmptyStrings = false)]
        [StringLength(50, MinimumLength = 3)]
        [DisplayName("Username")]
        public string? Username { get; set; }

        [Required(AllowEmptyStrings = false)]
        [StringLength(50, MinimumLength = 3)]
        public string? Password { get; set; }
        public string? Email { get; set; }
    }
}
