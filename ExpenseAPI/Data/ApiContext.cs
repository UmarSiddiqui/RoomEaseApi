using ExpenseAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace ExpenseAPI.Data
{
    public class ApiContext : DbContext
    {


        public DbSet<SharedExpense> Expenses { get; set; }


        public ApiContext(DbContextOptions<ApiContext> options)
            : base(options)

        {

        }

    }

}
