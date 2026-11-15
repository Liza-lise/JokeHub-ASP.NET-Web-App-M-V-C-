using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace Jokes_APP_ASP.NET_CORE_WE_APP__mvc_.Models
{
 
        public class Joke
        {
            public int Id { get; set; }

            [Required]
            [StringLength(500)]
            public string JokeQuestion { get; set; } = string.Empty;

            [Required]
            [StringLength(1000)]
            public string JokeAnswer { get; set; } = string.Empty;

        public DateTime DateCreated { get; set; } = DateTime.UtcNow;
        public string? CreatedByUserId { get; set; }

        public IdentityUser? CreatedByUser { get; set; }
    }
}
