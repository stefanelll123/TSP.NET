﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lab004.EF.Entities
{
    public class PhotographFullImage
    {
        [Key]
        public int PhotoId { get; set; }

        public byte[] HighResolutionBits { get; set; }

        [ForeignKey("PhotoId")]
        public virtual Photograph Photograph { get; set; }
    }
}
