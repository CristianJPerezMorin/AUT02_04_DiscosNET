﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AUT02_04_DiscosNET.Models
{
    [Table("Album")]
    [Index("ArtistId", Name = "IFK_AlbumArtistId")]
    public partial class Album
    {
        public Album()
        {
            Tracks = new HashSet<Track>();
        }

        [Key]
        public int AlbumId { get; set; }
        [Required(ErrorMessage = "El Campo es Obligatorio.")]
        [DisplayName("Titulo")]
        [StringLength(160, ErrorMessage = "El Campo no puede tener más de 160 caracteres.")]
        [MinLength(2, ErrorMessage = "El Campo no puede tener menos de 2 caracteres.")]
        public string Title { get; set; }
        
        public int ArtistId { get; set; }
        [DisplayName("Artistas")]
        [ForeignKey("ArtistId")]
        [InverseProperty("Albums")]
        public virtual Artist Artist { get; set; }
        [InverseProperty("Album")]
        public virtual ICollection<Track> Tracks { get; set; }
    }
}