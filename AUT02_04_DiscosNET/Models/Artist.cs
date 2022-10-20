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
    [Table("Artist")]
    public partial class Artist
    {
        public Artist()
        {
            Albums = new HashSet<Album>();
        }

        [Key]
        public int ArtistId { get; set; }
        [DisplayName("Artista")]
        [StringLength(120, ErrorMessage = "El Campo no puede tener más de 120 caracteres.")]
        [MinLength(2, ErrorMessage = "El Campo no puede tener menos de 2 caracteres.")]
        public string Name { get; set; }

        [InverseProperty("Artist")]
        public virtual ICollection<Album> Albums { get; set; }
    }
}