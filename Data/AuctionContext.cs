using Microsoft.EntityFrameworkCore;
using AuctionSystem.Models;

namespace AuctionSystem.Data
{
    public class AuctionContext : DbContext
    {
        public AuctionContext(DbContextOptions<AuctionContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Auction> Auctions { get; set; }
    }
}
