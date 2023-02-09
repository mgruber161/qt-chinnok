﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QTChinnok.Logic.Entities.App
{
    [Table("tracks")]
    public class Track : VersionEntity
    {
        [Key]
        [Column("TrackId")]
        public override int Id { get => base.Id; internal set => base.Id = value; }

        public int? AlbumId { get; set; }
        public int? GenreId { get; set; }
        public int MediaTypeId { get; set; }
        [MaxLength(200)]
        public string Name { get; set; } = string.Empty;
        [MaxLength(220)]
        public string? Composer { get; set; }
        public int Milliseconds { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
