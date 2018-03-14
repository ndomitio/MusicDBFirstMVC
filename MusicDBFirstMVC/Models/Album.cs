//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MusicDBFirstMVC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Album
    {
        public int AlbumID { get; set; }
        [Display(Name = "Name")]
        public string AlbumName { get; set; }
        public string JamCity { get; set; }
        [Display(Name = "Date Released")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}")]
        public System.DateTime DateReleased { get; set; }
        [Display(Name = "Album Art")]
        public string AlbumPhoto { get; set; }
        [Display(Name = "Track Listing")]
        public string AlbumPhotoBack { get; set; }
        [Display(Name = "Artist")]
        public int ArtistID { get; set; }

        public virtual Artist Artist { get; set; }
    }
}
