//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class LyricsCategoryTable
    {
        public LyricsCategoryTable()
        {
            this.LyricsSubCategoryTable = new HashSet<LyricsSubCategoryTable>();
            this.lyricsTable = new HashSet<lyricsTable>();
        }
    
        public int category_id { get; set; }
        public string category_name { get; set; }
    
        public virtual ICollection<LyricsSubCategoryTable> LyricsSubCategoryTable { get; set; }
        public virtual ICollection<lyricsTable> lyricsTable { get; set; }
    }
}
