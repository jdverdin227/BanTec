using Microsoft.EntityFrameworkCore;
using Bantec.Models;

namespace Bantec.Data
{

    public class BantecDbContext : DbContext
    {
        public BantecDbContext(DbContextOptions<BantecDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Wallet> Wallets { get; set; }
        public DbSet<Credit> Credits { get; set; }
        public DbSet<Transactions> Transactions { get; set; }
    }
}
