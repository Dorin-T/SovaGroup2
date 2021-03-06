﻿using System;
using System.Data;
using DataAccessLayer.dbDTO;
using Microsoft.EntityFrameworkCore;


namespace DataAccessLayer.dbContext
{
    class SovaDbContext : DbContext
    {
        public DbSet<Post> Posts { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<QuestionSearchResults> Questions { get; set; }
        public DbSet<ReturnSearches> ReturnSearches { get; set; }
        public DbSet<MarkPost> MarkPosts { get; set; }
        public DbSet<ReturnGoodMarks> ReturnGoodMarks { get; set; }
        public DbSet<Marks> Marks { get; set; }
        public DbSet<ReturnVisitedPosts> ReturnVisitedPosts { get; set; }
        public DbSet<ReturnNewestQuestions> ReturnNewestQuestions { get; set; }
        public DbSet<ReturnLinkPosts> ReturnLinkPosts { get; set; }
        public DbSet<ReturnPostTags> ReturnPostTags { get; set; }
        
    

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseMySql(
                "server=wt-220.ruc.dk;database=raw2;uid=raw2;pwd=raw2");
            
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //do we need it because these tables are same within databas schema???
            modelBuilder.Entity<QuestionSearchResults>().Property(x => x.id).HasColumnName("id");
            modelBuilder.Entity<QuestionSearchResults>().Property(x => x.title).HasColumnName("title");
            modelBuilder.Entity<QuestionSearchResults>().Property(x => x.body).HasColumnName("body");
            modelBuilder.Entity<QuestionSearchResults>().Property(x => x.score).HasColumnName("score");
            modelBuilder.Entity<QuestionSearchResults>().Property(x => x.comment_text).HasColumnName("comment_text");
            modelBuilder.Entity<QuestionSearchResults>().Property(x => x.tag_name).HasColumnName("tag_name");




        }



    }
}
