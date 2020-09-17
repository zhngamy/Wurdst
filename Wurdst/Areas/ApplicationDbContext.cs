using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Wurdst.Models;
using Wurdst.Data.Migrations;

namespace Wurdst.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Word> Words { get; set; }

        public DbSet<Tag> Tags { get; set; }

        public DbSet<WordTag> WordTags { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<WordTag>()
                .HasKey(wt => new { wt.WordId, wt.TagId });
            modelBuilder.Entity<WordTag>()
                .HasOne(wt => wt.Word)
                .WithMany(w => w.WordTags)
                .HasForeignKey(wt => wt.WordId);
            modelBuilder.Entity<WordTag>()
                .HasOne(wt => wt.Tag)
                .WithMany(t => t.WordTags)
                .HasForeignKey(t => t.TagId);

            base.OnModelCreating(modelBuilder);
        }

    }


}
