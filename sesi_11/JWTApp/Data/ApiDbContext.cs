using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

using JWTApp.Models;

namespace JWTApp.Data
{
    public class ApiDbContext : IdentityDbContext
    {
        public virtual DbSet<UserData> Items { get; set; }
        public virtual DbSet<RefreshToken> RefreshTokens { get; set; }
        public ApiDbContext(DbContextOptions<ApiDbContext> options)
            : base(options)
        {

        }
    }
}