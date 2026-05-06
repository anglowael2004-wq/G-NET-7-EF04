using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    internal class bankdbcontext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=bankdb;Trusted_Connection=True;TrustServerCertificate=True");
            

        }
        
        public DbSet<Branch> Branches { get; set; }
        public DbSet<Manager> Managers { get; set; }
        public DbSet<Account> Accounts { get; set; }    
        public DbSet<Customer> Customers { get; set; }
        public DbSet<CustomerAccount> CustomerAccounts { get; set; }
         public DbSet<Transaction> Transactions { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CustomerAccount>()
                .HasKey(ca => new { ca.CustomerId, ca.AccountNumber });
            modelBuilder.Entity<CustomerAccount>()
                .HasOne(ca => ca.customer)
                .WithMany(c => c.Accounts)
                .HasForeignKey(ca => ca.CustomerId);
            modelBuilder.Entity<CustomerAccount>()
                .HasOne(ca => ca.account)
                .WithMany(a => a.customers)
                .HasForeignKey(ca => ca.AccountNumber);
            modelBuilder.Entity<Branch>()
                .HasOne(b => b.manager)
                .WithOne(m => m.branch)
                .HasForeignKey<Manager>(m => m.branchCode);
            modelBuilder.Entity<Branch>().HasKey(b=>b.Code);
        }
    }
}
