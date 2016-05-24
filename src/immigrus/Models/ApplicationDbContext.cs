﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Data.Entity;
using immigrus.Models;

namespace immigrus.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
        public DbSet<Faq> Faq { get; set; }
        public DbSet<Clients> Clients { get; set; }
        public DbSet<Enfants> Enfants { get; set; }
        public DbSet<Actualite> Actualite { get; set; }
        public DbSet<FlashInfo> FlashInfo { get; set; }
        public DbSet<Photo> Photo { get; set; }


    }
}
