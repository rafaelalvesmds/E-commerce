﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_Commerce.API.Models.Base
{
    public class BaseEntity
    {
        [Key]
        [Column("id")]

        public long Id { get; set; }
    }
}
