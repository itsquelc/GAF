using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using Microsoft.AspNetCore.Identity;

namespace GAF.Api.Models;

[Table("users")]
    public class User : IdentityUser
    {
        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdateAd { get; set; } = DateTime.Now;
    }
