using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using UserManager.Entities;

namespace UserManager.Repositories
{
    public class UserManagerDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Phone> Phones { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Price> Prices { get; set; }
        public UserManagerDbContext()
            : base(@"Server=DESKTOP-34I4EIS ;Database=SQL1;Trusted_Connection=True;")
        {
            Users = Set<User>();
            Contacts = Set<Contact>();
            Phones = Set<Phone>();
            Books = Set<Book>();
            Prices = Set<Price>();
        }
    }
}