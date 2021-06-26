using System;
using System.Collections.Generic;
using System.Text;
using Krasinski.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Krasinski_Store.DataAccess.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Category> Category { get; set; }
        public DbSet<Frequency> Frequency { get; set; }
        public DbSet<Service> Service { get; set; }
    }
}
