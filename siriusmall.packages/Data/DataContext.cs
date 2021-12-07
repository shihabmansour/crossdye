using Microsoft.EntityFrameworkCore;
using siriusmall.packages.Models;

namespace siriusmall.packages.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<Customer> Customer { get; set; }
    }
}