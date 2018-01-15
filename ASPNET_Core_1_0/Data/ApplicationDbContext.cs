﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ASPNET_Core_1_0.Models;

namespace ASPNET_Core_1_0.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }

        public DbSet<ASPNET_Core_1_0.Models.Produto> Produto { get; set; }

        public DbSet<ASPNET_Core_1_0.Models.Cliente> Cliente { get; set; }

        public DbSet<ASPNET_Core_1_0.Models.Pedidos> Pedidos { get; set; }
    }
}
