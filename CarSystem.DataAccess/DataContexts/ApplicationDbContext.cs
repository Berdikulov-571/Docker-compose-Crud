﻿using CarSystem.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace AppartmentSystem.DataAccess.DataContexts
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public virtual DbSet<CarModel> Cars { get; set; }
    }
}