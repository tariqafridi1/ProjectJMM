using Microsoft.EntityFrameworkCore;
using ProjectJMM.Models;

namespace ProjectJMM.DBData
{
    public class ApplicationDbContext: DbContext
    {
        public  ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Item> Items { get; set; }
        public DbSet<Expense> Expenses { get; set; }
    }

}
 