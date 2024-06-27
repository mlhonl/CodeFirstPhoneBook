using CodeFirstPhoneBook.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstPhoneBook.Context
{
    
    public class PhoneDbContext : DbContext
    {
        public DbSet<Contact> Contacts {  get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-GKIAR99\\SQLEXPRESS;Database=PhoneDb;Trusted_Connection=True;");
        }
    }
}
