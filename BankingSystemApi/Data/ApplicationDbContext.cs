using BankingSystemApi.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace BankingSystemApi.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<BankAccount> BankAccounts { get; set; }
    }
}
