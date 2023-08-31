﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TestProject.DataAccess.Concrete.EntityFrameworkCore.Mappings;
using TestProject.Entity.Concrete;

namespace TestProject.DataAccess.Concrete.EntityFrameworkCore
{
    public class TestProjectDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-UGD7FQ4\SQLEXPRESS;Database=TestProject;integrated security=true;Connection Timeout=1800;MultipleActiveResultSets=True");
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration<Category>(new CategoryMap());
            modelBuilder.ApplyConfiguration<Product>(new ProductMap());
            modelBuilder.ApplyConfiguration<ProductImage>(new ProductImageMap());
        }
    }
}
