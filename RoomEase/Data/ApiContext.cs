using Microsoft.EntityFrameworkCore;
using RoomEase.Models;

namespace RoomEase.Data
{
    public class ApiContext : DbContext
    {
        public DbSet<SharedExpense> Expenses { get; set; }
        public DbSet<ChoresList> Chores { get; set; }

        public ApiContext(DbContextOptions<ApiContext> options) : base(options) { }
    }
}