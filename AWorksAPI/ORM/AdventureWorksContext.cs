﻿using System;
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
        public DbSet<AddressType> AddressType { get; set; }
        public DbSet<CountryRegion> CountryRegion { get; set; }
        public DbSet<EmailAddress> EmailAddress { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Person was configured with data annotations to have an example of how to do it that way
            //

            modelBuilder.Entity<Address>().ToTable("Address", schema: "Person")
                .HasKey(k => k.AddressID);

            modelBuilder.Entity<Address>().ToTable("Address", schema: "Person")
                .Property(b => b.AddressID)
                .ValueGeneratedOnAdd();
            modelBuilder.Entity<Address>().Ignore(c => c.IsComplexType);

            modelBuilder.Entity<AddressType>().ToTable("AddressType", schema: "Person")
               .HasKey(k => k.AddressTypeID);
            modelBuilder.Entity<AddressType>().Ignore(c => c.IsComplexType);

            modelBuilder.Entity<CountryRegion>().ToTable("CountryRegion", schema: "Person")
               .HasKey(k => k.CountryRegionCode);
            modelBuilder.Entity<CountryRegion>().Ignore(c => c.IsComplexType);

            modelBuilder.Entity<EmailAddress>().ToTable("EmailAddress", schema: "Person")
               .HasKey(k => new { k.BusinessEntityId, k.EmailAddressId });
            modelBuilder.Entity<EmailAddress>().Ignore(c => c.KeyType); //cannot have a property with Type as a type, entity just throws exceptions must be ignored on everything
            modelBuilder.Entity<EmailAddress>().Ignore(c => c.IsComplexType);
        }
    }
}

