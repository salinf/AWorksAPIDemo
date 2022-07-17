using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

using AWorksDataModels;

namespace AWorksAPIDemo.ORM
{
    public class AdventureWorksContext : DbContext
    {
        public AdventureWorksContext(DbContextOptions<AdventureWorksContext> options) : base(options)
        {
        }

        public DbSet<test456> Test456 { get; set; }
        public DbSet<Person> Person { get; set; }
        public DbSet<Address> Address { get; set; }
       

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Person was configured with data annotations to have an example of how to do it that way
            //

            modelBuilder.Entity<Address>().ToTable("Address", schema: "Person")
                .HasKey(k => k.AddressID);

            modelBuilder.Entity<Address>().ToTable("Address", schema: "Person")
                .Property(b => b.AddressID)
                .ValueGeneratedOnAdd();
               
                
                //.HasMany(c => c.Instructors)
                //.WithMany(i => i.Courses);
           
        }
    }
}

