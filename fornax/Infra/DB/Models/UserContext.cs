using fornax.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace fornax.Infra.DB.Models
{
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions<UserContext> opts): base(opts) { }

        public DbSet<User> Users { get; set; }
    }
}
