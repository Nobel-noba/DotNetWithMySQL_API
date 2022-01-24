using Microsoft.EntityFrameworkCore;
using MySql.Data.MySqlClient;
using PracticeA.Models;

namespace PracticeA.Applications
{
    public class OrderContext : DbContext
    {
        public OrderContext(DbContextOptions<OrderContext> options) : base(options) { }
        public DbSet<Orders> Orders { get; set; }
    }
}
