using Jokes_APP_ASP.NET_CORE_WE_APP__mvc_.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace Jokes_APP_ASP.NET_CORE_WE_APP__mvc_.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Joke> Jokes { get; set; }
    }
}
