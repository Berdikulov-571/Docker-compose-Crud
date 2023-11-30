﻿using AppartmentSystem.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace AppartmentSystem.DataAccess.DataContexts
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            Database.Migrate();
        }

        public virtual DbSet<AppartmentModel> Appartments { get; set; }
    }
}