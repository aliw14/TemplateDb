using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Podcast1.DataAccessLayer.Entities;

namespace Podcast1.DataAccessLayer
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Footer>  Footers{ get; set; }

        public DbSet<Contact> Contacts { get; set; }


    }
}

