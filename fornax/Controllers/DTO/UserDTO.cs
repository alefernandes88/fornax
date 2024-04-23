using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace fornax.Controllers.DTO
{
    public class UserDTO
    {
        public int? Id { get; set; }

        [Required]
        [NotNull]
        [Length(2,50)]
        public string Name { get; set; }

        [Required]
        [NotNull]
        [MinLength(6)]
        public string Pass { get; set; }

        [Required]
        [NotNull]
        [EmailAddress]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public DateTime Initial_date { get; set; }

    }
}
