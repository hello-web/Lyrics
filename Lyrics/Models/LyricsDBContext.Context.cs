﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Lyrics.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class LyricsDBEntities : DbContext
    {
        public LyricsDBEntities()
            : base("name=LyricsDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<LyricsCategoryTable> LyricsCategoryTable { get; set; }
        public DbSet<LyricsSubCategoryTable> LyricsSubCategoryTable { get; set; }
        public DbSet<lyricsTable> lyricsTable { get; set; }
    }
}
